Imports System.IO
Imports System.Threading
Imports MetroFramework

Public Enum PrintMode
    NineCards = 1
    TenCard = 2
End Enum
Public Class Form1

    Private Const SizeA4_Width As Integer = 2480
    Private Const SizeA4_Height As Integer = 3508
    Private Const YgoSize_Width As Integer = 697
    Private Const YgoSize_Height As Integer = 1016

    Private marginWidth As Integer = 0
    Private marginHeight As Integer = 0

    Private marginWidth_10 As Integer = 0
    Private marginHeight_10 As Integer = 0

    Private currentPage As Integer = 0
    Private maxPage As Integer = 0

    Private list As List(Of Image)
    Private printList As List(Of Image)

    Private PntMode As PrintMode = PrintMode.NineCards

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Event"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list = New List(Of Image)
        printList = New List(Of Image)
        MetroComboBox1.SelectedIndex = 1
        txtSavePath.Text = My.Settings.SavePath
        txtPath.Text = My.Settings.LoadPath

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.LoadPath = txtPath.Text
        My.Settings.SavePath = txtSavePath.Text
        My.Settings.Save()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim dialog As New FolderBrowserDialog()

        If dialog.ShowDialog() = DialogResult.OK Then
            Me.txtPath.Text = dialog.SelectedPath
        End If

        dialog.Dispose()
    End Sub

    Private Sub btnSaveBrowse_Click(sender As Object, e As EventArgs) Handles btnSaveBrowse.Click
        Dim dialog As New FolderBrowserDialog()

        If dialog.ShowDialog() = DialogResult.OK Then
            Me.txtSavePath.Text = dialog.SelectedPath
        End If

        dialog.Dispose()
    End Sub

    Private Sub btnLoadList_Click(sender As Object, e As EventArgs) Handles btnLoadList.Click

        Dim fullpath As String = Me.txtPath.Text

        If fullpath = String.Empty Then
            Exit Sub
        End If

        Try
            Dim FileDirectory As New IO.DirectoryInfo(fullpath)
            Dim FileJpg As IO.FileInfo() = FileDirectory.GetFiles("*.jpg")
            Dim FilePng As IO.FileInfo() = FileDirectory.GetFiles("*.png")
            Dim FileBmp As IO.FileInfo() = FileDirectory.GetFiles("*.bmp")

            Dim dt As New DataTable
            dt.Columns.Add("Page")
            dt.Columns.Add("Path")
            dt.Columns.Add("FileName")
            dt.Columns.Add("Extension")

            Dim count As Integer = 1

            For Each File As IO.FileInfo In FileJpg
                dt.Rows.Add(Me.CreateRow(File, count, dt))
                count += 1
            Next
            For Each File As IO.FileInfo In FilePng
                dt.Rows.Add(Me.CreateRow(File, count, dt))
                count += 1
            Next
            For Each File As IO.FileInfo In FileBmp
                dt.Rows.Add(Me.CreateRow(File, count, dt))
                count += 1
            Next

            MetroTabControl1.SelectTab(0)

            grdImageList.DataSource = dt
            grdImageList.AutoResizeColumn(1)
            grdImageList.AutoResizeColumn(2)

            btnPreLoad.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreLoad_Click(sender As Object, e As EventArgs) Handles btnPreLoad.Click

        If grdImageList.RowCount = 0 Then
            Exit Sub
        End If

        currentPage = 0
        maxPage = 0
        lbPageNum.Text = "0/0"
        Me.MetroProgressBar1.Maximum = (grdImageList.RowCount - 1) * 2
        MetroProgressBar1.Value = 0
        MetroProgressBar1.Step = 1

        Me.MakeButton_Disable(False)

        Dim thread As New Thread(AddressOf MakePrintImage)
        thread.IsBackground = True
        thread.Start()
        'Me.MakePrintImage()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtSavePath.Text = String.Empty Then
                Exit Sub
            End If

            Dim count As Integer = 0
            For Each img As Image In printList
                img.Save(txtSavePath.Text & "\PrintMaker_" & count & ".jpg", Imaging.ImageFormat.Jpeg)
                count += 1
            Next

            MetroMessageBox.Show(Me, "Save Complete", "Message")
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message)
        End Try

    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Try
            If currentPage > 0 Then
                currentPage = currentPage - 1
                lbPageNum.Text = (currentPage + 1) & "/" & maxPage
                pbPreviewImage.Image = printList(currentPage)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message)
        End Try

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Try
            If currentPage < (maxPage - 1) Then
                currentPage = currentPage + 1
                lbPageNum.Text = (currentPage + 1) & "/" & maxPage
                pbPreviewImage.Image = printList(currentPage)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message)
        End Try

    End Sub


#End Region

#Region "Method"

    Private Sub LoadList(mode As PrintMode)

    End Sub

    Private Sub MakeButton_Disable(enable As Boolean)

        Me.btnBrowse.Enabled = enable
        Me.btnLoadList.Enabled = enable
        Me.BtnNext.Enabled = enable
        Me.btnPreLoad.Enabled = enable
        Me.BtnPrevious.Enabled = enable
        Me.btnSave.Enabled = enable
        Me.btnSaveBrowse.Enabled = enable

    End Sub

    Private Function GetItemEachPage() As Integer
        Dim itemEachPage As Integer
        If PntMode = PrintMode.NineCards Then
            itemEachPage = 9
        ElseIf PntMode = PrintMode.TenCard Then
            itemEachPage = 10
        End If
        Return itemEachPage
    End Function

    Private Function CreateRow(File As IO.FileInfo, count As Integer, dt As DataTable) As DataRow

        Dim row As DataRow = dt.NewRow
        row(0) = Math.Ceiling(count / GetItemEachPage())
        row(1) = File.DirectoryName
        row(2) = File.FullName.Replace(File.DirectoryName & "\", "")
        row(3) = File.Extension

        Return row
    End Function

    Private Sub SettingMargin()
        marginWidth = (SizeA4_Width - YgoSize_Width * 3) / 4
        marginWidth = marginWidth + 15
        marginHeight = (SizeA4_Height - YgoSize_Height * 3) / 4
        marginHeight = marginHeight + 15

        marginWidth_10 = (SizeA4_Width - YgoSize_Height * 2) / 2
        marginWidth_10 = marginWidth_10
        marginHeight_10 = (SizeA4_Height - ((YgoSize_Width + YgoSize_Width + YgoSize_Height + YgoSize_Height))) / 2
        marginHeight_10 = marginHeight_10

        If PntMode = PrintMode.TenCard Then
            marginWidth = (SizeA4_Width - YgoSize_Width * 3) / 2
            marginWidth = marginWidth
            marginHeight = marginHeight_10 + YgoSize_Width * 2
            marginHeight = marginHeight
        End If
        'Console.WriteLine(marginWidth_10)
        'Console.WriteLine(marginHeight_10)
    End Sub

    ''' <summary>
    ''' Lay image
    ''' </summary>
    ''' <param name="path">đâs</param>
    ''' <returns>đâsd</returns>
    Private Function GetImage(path As String) As Bitmap

        Dim bm_source As New Bitmap(Image.FromFile(path))

        ' Make a bitmap for the result.
        Dim bm_dest As New Bitmap(YgoSize_Width, YgoSize_Height)

        ' Make a Graphics object for the result Bitmap.
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

        ' Copy the source image into the destination bitmap.
        gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width, bm_dest.Height)

        GC.Collect()
        GC.WaitForPendingFinalizers()
        gr_dest.Dispose()
        GC.Collect()
        GC.WaitForPendingFinalizers()

        Return bm_dest
    End Function

    ''' <summary>
    ''' hghjgjhgjh
    ''' </summary>
    ''' <param name="gr_dest">dkasdkas</param>
    ''' <param name="img"></param>
    ''' <param name="count"></param>
    Private Sub PlaceImage(ByRef gr_dest As Graphics, ByRef img As Image, count As Integer)

        ' hgjhgjhg
        If PntMode = PrintMode.NineCards Then
            Select Case count
                Case 1
                    gr_dest.DrawImage(img, marginWidth, marginHeight, YgoSize_Width, YgoSize_Height)
                Case 2
                    gr_dest.DrawImage(img, (marginWidth * 2) + YgoSize_Width, marginHeight, YgoSize_Width, YgoSize_Height)
                Case 3
                    gr_dest.DrawImage(img, (marginWidth * 3) + (YgoSize_Width * 2), marginHeight, YgoSize_Width, YgoSize_Height)
                Case 4
                    gr_dest.DrawImage(img, marginWidth, marginHeight * 2 + YgoSize_Height, YgoSize_Width, YgoSize_Height)
                Case 5
                    gr_dest.DrawImage(img, (marginWidth * 2) + YgoSize_Width, marginHeight * 2 + YgoSize_Height, YgoSize_Width, YgoSize_Height)
                Case 6
                    gr_dest.DrawImage(img, (marginWidth * 3) + YgoSize_Width * 2, marginHeight * 2 + YgoSize_Height, YgoSize_Width, YgoSize_Height)
                Case 7
                    gr_dest.DrawImage(img, marginWidth, marginHeight * 3 + YgoSize_Height * 2, YgoSize_Width, YgoSize_Height)
                Case 8
                    gr_dest.DrawImage(img, (marginWidth * 2) + YgoSize_Width, marginHeight * 3 + YgoSize_Height * 2, YgoSize_Width, YgoSize_Height)
                Case 9
                    gr_dest.DrawImage(img, (marginWidth * 3) + YgoSize_Width * 2, marginHeight * 3 + YgoSize_Height * 2, YgoSize_Width, YgoSize_Height)
                Case Else
                    Exit Sub
            End Select
        ElseIf PntMode = PrintMode.TenCard Then
            Select Case count
                Case 1
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    gr_dest.DrawImage(img, marginWidth_10, marginHeight_10, YgoSize_Height, YgoSize_Width)
                Case 2
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    gr_dest.DrawImage(img, marginWidth_10 + YgoSize_Height + 5, marginHeight_10, YgoSize_Height, YgoSize_Width)
                Case 3
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    gr_dest.DrawImage(img, marginWidth_10, marginHeight_10 + YgoSize_Width + 5, YgoSize_Height, YgoSize_Width)
                Case 4
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    gr_dest.DrawImage(img, marginWidth_10 + YgoSize_Height + 5, marginHeight_10 + YgoSize_Width + 5, YgoSize_Height, YgoSize_Width)
                Case 5
                    gr_dest.DrawImage(img, marginWidth, marginHeight + 10, YgoSize_Width, YgoSize_Height)
                Case 6
                    gr_dest.DrawImage(img, marginWidth + YgoSize_Width + 5, marginHeight + 10, YgoSize_Width, YgoSize_Height)
                Case 7
                    gr_dest.DrawImage(img, marginWidth + YgoSize_Width * 2 + 10, marginHeight + 10, YgoSize_Width, YgoSize_Height)
                Case 8
                    gr_dest.DrawImage(img, marginWidth, marginHeight + YgoSize_Height + 15, YgoSize_Width, YgoSize_Height)
                Case 9
                    gr_dest.DrawImage(img, marginWidth + YgoSize_Width + 5, marginHeight + YgoSize_Height + 15, YgoSize_Width, YgoSize_Height)
                Case 10
                    gr_dest.DrawImage(img, marginWidth + YgoSize_Width * 2 + 10, marginHeight + YgoSize_Height + 15, YgoSize_Width, YgoSize_Height)
                Case Else
                    Exit Sub
            End Select
        End If


    End Sub

    Private Sub MakePrintImage()
        Try

            Dim dt As DataTable = grdImageList.DataSource
            If dt Is Nothing Then
                Exit Sub
            End If

            For Each img As Image In list
                img.Dispose()
            Next

            For Each img As Image In printList
                img.Dispose()
            Next

            printList.Clear()
            list.Clear()

            GC.Collect()
            GC.WaitForPendingFinalizers()

            Me.SettingMargin()
            maxPage = Math.Ceiling(dt.Rows.Count / GetItemEachPage())

            For Each row As DataRow In dt.Rows
                Dim path As String = row(1) & "\" & row(2)
                list.Add(Me.GetImage(path))
                Me.Invoke(New Action(Sub() Me.LoadImageProgress()))
                'pbPreviewImage.Image = Me.GetImage(path)
            Next

            Dim count As Integer = 1

            Dim z As Integer = 1
            Dim bm_dest As New Bitmap(SizeA4_Width, SizeA4_Height)
            Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
            Using br As New SolidBrush(Color.White)
                gr_dest.FillRectangle(br, 0, 0, bm_dest.Width, bm_dest.Height)
            End Using


            printList.Add(bm_dest)

            For Each img As Image In list
                If count <= GetItemEachPage() Then

                    PlaceImage(gr_dest, img, count)
                    count += 1
                    z += 1
                Else
                    count = 1
                    gr_dest.Dispose()
                    bm_dest = New Bitmap(SizeA4_Width, SizeA4_Height)
                    gr_dest = Graphics.FromImage(bm_dest)

                    Using br As New SolidBrush(Color.White)
                        gr_dest.FillRectangle(br, 0, 0, bm_dest.Width, bm_dest.Height)
                    End Using

                    printList.Add(bm_dest)
                    PlaceImage(gr_dest, img, count)
                    count += 1
                End If
                Me.Invoke(New Action(Sub() Me.LoadImageProgress()))
            Next

            gr_dest.Dispose()

            Me.Invoke(New Action(Sub() Me.LoadImage_CallBack()))
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message)
        End Try


    End Sub

    Private Sub LoadImage_CallBack()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            For Each img As Image In list
                img.Dispose()
            Next
            list.Clear()
            GC.Collect()
            GC.WaitForPendingFinalizers()

            pbPreviewImage.Image = printList(0)
            pbPreviewImage.SizeMode = PictureBoxSizeMode.StretchImage

            MetroTabControl1.SelectTab(1)
            lbPageNum.Text = (currentPage + 1) & "/" & maxPage

            Me.MakeButton_Disable(True)

            MetroMessageBox.Show(Me, "Load images and drop into template complete!", "Message")

        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message)
        End Try

    End Sub

    Private Sub LoadImageProgress()

        MetroProgressBar1.PerformStep()

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        Select Case MetroComboBox1.SelectedIndex
            Case 0
                Me.PntMode = PrintMode.NineCards
            Case 1
                Me.PntMode = PrintMode.TenCard
        End Select

        If Not txtPath.Text = String.Empty Then
            btnLoadList_Click(btnLoadList, Nothing)
        End If

    End Sub


#End Region


End Class
