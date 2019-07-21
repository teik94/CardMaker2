<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.grdImageList = New MetroFramework.Controls.MetroGrid()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.lbPageNum = New MetroFramework.Controls.MetroLabel()
        Me.BtnNext = New MetroFramework.Controls.MetroButton()
        Me.BtnPrevious = New MetroFramework.Controls.MetroButton()
        Me.pbPreviewImage = New System.Windows.Forms.PictureBox()
        Me.btnPreLoad = New MetroFramework.Controls.MetroButton()
        Me.controlPanel = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtSavePath = New MetroFramework.Controls.MetroTextBox()
        Me.btnSaveBrowse = New MetroFramework.Controls.MetroButton()
        Me.txtPath = New MetroFramework.Controls.MetroTextBox()
        Me.btnBrowse = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.btnLoadList = New MetroFramework.Controls.MetroButton()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.grdImageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.pbPreviewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.controlPanel.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroProgressBar1.Location = New System.Drawing.Point(0, 78)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(1018, 23)
        Me.MetroProgressBar1.Step = 1
        Me.MetroProgressBar1.TabIndex = 0
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1018, 537)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.grdImageList)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1010, 495)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Image List"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'grdImageList
        '
        Me.grdImageList.AllowUserToResizeRows = False
        Me.grdImageList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdImageList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdImageList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdImageList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdImageList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdImageList.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdImageList.EnableHeadersVisualStyles = False
        Me.grdImageList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdImageList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdImageList.Location = New System.Drawing.Point(14, 15)
        Me.grdImageList.Name = "grdImageList"
        Me.grdImageList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdImageList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdImageList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdImageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdImageList.Size = New System.Drawing.Size(975, 447)
        Me.grdImageList.TabIndex = 2
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.lbPageNum)
        Me.MetroTabPage2.Controls.Add(Me.BtnNext)
        Me.MetroTabPage2.Controls.Add(Me.BtnPrevious)
        Me.MetroTabPage2.Controls.Add(Me.pbPreviewImage)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1010, 495)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Preview"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'lbPageNum
        '
        Me.lbPageNum.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbPageNum.Location = New System.Drawing.Point(440, 449)
        Me.lbPageNum.Name = "lbPageNum"
        Me.lbPageNum.Size = New System.Drawing.Size(97, 31)
        Me.lbPageNum.TabIndex = 4
        Me.lbPageNum.Text = "0 / 0"
        Me.lbPageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FloralWhite
        Me.BtnNext.BackgroundImage = Global.PrintMaker2018.My.Resources.Resources.arrow_33_512
        Me.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNext.Location = New System.Drawing.Point(692, 172)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(107, 108)
        Me.BtnNext.TabIndex = 3
        Me.BtnNext.UseCustomBackColor = True
        Me.BtnNext.UseSelectable = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FloralWhite
        Me.BtnPrevious.BackgroundImage = Global.PrintMaker2018.My.Resources.Resources.arrow_98_512
        Me.BtnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrevious.Location = New System.Drawing.Point(183, 172)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(107, 108)
        Me.BtnPrevious.TabIndex = 3
        Me.BtnPrevious.UseCustomBackColor = True
        Me.BtnPrevious.UseSelectable = True
        '
        'pbPreviewImage
        '
        Me.pbPreviewImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPreviewImage.Location = New System.Drawing.Point(330, 15)
        Me.pbPreviewImage.Name = "pbPreviewImage"
        Me.pbPreviewImage.Size = New System.Drawing.Size(312, 431)
        Me.pbPreviewImage.TabIndex = 2
        Me.pbPreviewImage.TabStop = False
        '
        'btnPreLoad
        '
        Me.btnPreLoad.BackColor = System.Drawing.Color.FloralWhite
        Me.btnPreLoad.Enabled = False
        Me.btnPreLoad.Location = New System.Drawing.Point(862, 20)
        Me.btnPreLoad.Name = "btnPreLoad"
        Me.btnPreLoad.Size = New System.Drawing.Size(69, 38)
        Me.btnPreLoad.TabIndex = 3
        Me.btnPreLoad.Text = "PreLoad"
        Me.btnPreLoad.UseCustomBackColor = True
        Me.btnPreLoad.UseSelectable = True
        '
        'controlPanel
        '
        Me.controlPanel.Controls.Add(Me.MetroLabel2)
        Me.controlPanel.Controls.Add(Me.MetroLabel1)
        Me.controlPanel.Controls.Add(Me.txtSavePath)
        Me.controlPanel.Controls.Add(Me.btnSaveBrowse)
        Me.controlPanel.Controls.Add(Me.txtPath)
        Me.controlPanel.Controls.Add(Me.btnBrowse)
        Me.controlPanel.Controls.Add(Me.btnSave)
        Me.controlPanel.Controls.Add(Me.btnLoadList)
        Me.controlPanel.Controls.Add(Me.btnPreLoad)
        Me.controlPanel.Controls.Add(Me.MetroProgressBar1)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.controlPanel.HorizontalScrollbarBarColor = True
        Me.controlPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.controlPanel.HorizontalScrollbarSize = 10
        Me.controlPanel.Location = New System.Drawing.Point(20, 603)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Size = New System.Drawing.Size(1018, 101)
        Me.controlPanel.TabIndex = 4
        Me.controlPanel.VerticalScrollbarBarColor = True
        Me.controlPanel.VerticalScrollbarHighlightOnWheel = False
        Me.controlPanel.VerticalScrollbarSize = 10
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(4, 43)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Load Path"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(5, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Save Path"
        '
        'txtSavePath
        '
        '
        '
        '
        Me.txtSavePath.CustomButton.Image = Nothing
        Me.txtSavePath.CustomButton.Location = New System.Drawing.Point(548, 1)
        Me.txtSavePath.CustomButton.Name = ""
        Me.txtSavePath.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSavePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSavePath.CustomButton.TabIndex = 1
        Me.txtSavePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSavePath.CustomButton.UseSelectable = True
        Me.txtSavePath.CustomButton.Visible = False
        Me.txtSavePath.Lines = New String() {"C:\Users\Admin\Desktop\Test"}
        Me.txtSavePath.Location = New System.Drawing.Point(76, 14)
        Me.txtSavePath.MaxLength = 32767
        Me.txtSavePath.Name = "txtSavePath"
        Me.txtSavePath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSavePath.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSavePath.SelectedText = ""
        Me.txtSavePath.SelectionLength = 0
        Me.txtSavePath.SelectionStart = 0
        Me.txtSavePath.ShortcutsEnabled = True
        Me.txtSavePath.Size = New System.Drawing.Size(570, 23)
        Me.txtSavePath.TabIndex = 4
        Me.txtSavePath.Text = "C:\Users\Admin\Desktop\Test"
        Me.txtSavePath.UseSelectable = True
        Me.txtSavePath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSavePath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSaveBrowse
        '
        Me.btnSaveBrowse.BackColor = System.Drawing.Color.FloralWhite
        Me.btnSaveBrowse.Location = New System.Drawing.Point(652, 14)
        Me.btnSaveBrowse.Name = "btnSaveBrowse"
        Me.btnSaveBrowse.Size = New System.Drawing.Size(88, 23)
        Me.btnSaveBrowse.TabIndex = 3
        Me.btnSaveBrowse.Text = "Browse"
        Me.btnSaveBrowse.UseCustomBackColor = True
        Me.btnSaveBrowse.UseSelectable = True
        '
        'txtPath
        '
        '
        '
        '
        Me.txtPath.CustomButton.Image = Nothing
        Me.txtPath.CustomButton.Location = New System.Drawing.Point(547, 1)
        Me.txtPath.CustomButton.Name = ""
        Me.txtPath.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPath.CustomButton.TabIndex = 1
        Me.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPath.CustomButton.UseSelectable = True
        Me.txtPath.CustomButton.Visible = False
        Me.txtPath.Lines = New String() {"C:\Users\Admin\Desktop\Test"}
        Me.txtPath.Location = New System.Drawing.Point(76, 43)
        Me.txtPath.MaxLength = 32767
        Me.txtPath.Name = "txtPath"
        Me.txtPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPath.SelectedText = ""
        Me.txtPath.SelectionLength = 0
        Me.txtPath.SelectionStart = 0
        Me.txtPath.ShortcutsEnabled = True
        Me.txtPath.Size = New System.Drawing.Size(569, 23)
        Me.txtPath.TabIndex = 4
        Me.txtPath.Text = "C:\Users\Admin\Desktop\Test"
        Me.txtPath.UseSelectable = True
        Me.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FloralWhite
        Me.btnBrowse.Location = New System.Drawing.Point(651, 43)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(88, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseCustomBackColor = True
        Me.btnBrowse.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FloralWhite
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(937, 20)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 38)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseSelectable = True
        '
        'btnLoadList
        '
        Me.btnLoadList.BackColor = System.Drawing.Color.FloralWhite
        Me.btnLoadList.Location = New System.Drawing.Point(787, 20)
        Me.btnLoadList.Name = "btnLoadList"
        Me.btnLoadList.Size = New System.Drawing.Size(69, 38)
        Me.btnLoadList.TabIndex = 3
        Me.btnLoadList.Text = "LoadList"
        Me.btnLoadList.UseCustomBackColor = True
        Me.btnLoadList.UseSelectable = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"9 Cards", "10 Cards"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(366, 33)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(218, 29)
        Me.MetroComboBox1.TabIndex = 5
        Me.MetroComboBox1.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 724)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.controlPanel)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "YGO Print Maker 2018"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.grdImageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        CType(Me.pbPreviewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.controlPanel.ResumeLayout(False)
        Me.controlPanel.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grdImageList As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnPreLoad As MetroFramework.Controls.MetroButton
    Friend WithEvents controlPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtPath As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBrowse As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnNext As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnPrevious As MetroFramework.Controls.MetroButton
    Friend WithEvents pbPreviewImage As PictureBox
    Friend WithEvents btnLoadList As MetroFramework.Controls.MetroButton
    Friend WithEvents txtSavePath As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSaveBrowse As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbPageNum As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
End Class
