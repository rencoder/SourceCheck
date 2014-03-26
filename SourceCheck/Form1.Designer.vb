<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SourceCheckerForm
    Inherits System.Windows.Forms.Form

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
        Dim Label1 As System.Windows.Forms.Label
        Dim TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
        Dim FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Dim TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Me.txtSourcePath = New System.Windows.Forms.TextBox()
        Me.GridInformation = New System.Windows.Forms.DataGridView()
        Me.colHash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRelativePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOccurrence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtExcelPath = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMessageHeader = New System.Windows.Forms.TextBox()
        Me.txtFileNameHeader = New System.Windows.Forms.TextBox()
        Me.chkCase = New System.Windows.Forms.CheckBox()
        Me.chkRemoveSplChars = New System.Windows.Forms.CheckBox()
        Me.btnRunCheck = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.ProgressBarLoading = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsslTimeTaken = New System.Windows.Forms.ToolStripStatusLabel()
        Label1 = New System.Windows.Forms.Label()
        TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        CType(Me.GridInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(3, 6)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(75, 17)
        Label1.TabIndex = 1
        Label1.Text = "Source Path"
        '
        'TableLayoutPanel1
        '
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        TableLayoutPanel1.Controls.Add(Me.txtSourcePath, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Me.GridInformation, 1, 5)
        TableLayoutPanel1.Controls.Add(Label2, 0, 1)
        TableLayoutPanel1.Controls.Add(Me.txtExcelPath, 1, 1)
        TableLayoutPanel1.Controls.Add(Label3, 0, 2)
        TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        TableLayoutPanel1.Controls.Add(Label4, 0, 3)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 1, 3)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 1, 4)
        TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        TableLayoutPanel1.Size = New System.Drawing.Size(907, 537)
        TableLayoutPanel1.TabIndex = 2
        '
        'txtSourcePath
        '
        Me.txtSourcePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSourcePath.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.txtSourcePath.Location = New System.Drawing.Point(84, 3)
        Me.txtSourcePath.Name = "txtSourcePath"
        Me.txtSourcePath.ReadOnly = True
        Me.txtSourcePath.Size = New System.Drawing.Size(820, 24)
        Me.txtSourcePath.TabIndex = 0
        Me.txtSourcePath.Text = "(double click to open Folder Dialog)"
        '
        'GridInformation
        '
        Me.GridInformation.AllowUserToAddRows = False
        Me.GridInformation.AllowUserToDeleteRows = False
        Me.GridInformation.AllowUserToOrderColumns = True
        Me.GridInformation.AllowUserToResizeRows = False
        Me.GridInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridInformation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHash, Me.colRelativePath, Me.colMessage, Me.colOccurrence, Me.colLineNumber})
        TableLayoutPanel1.SetColumnSpan(Me.GridInformation, 2)
        Me.GridInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInformation.Location = New System.Drawing.Point(0, 143)
        Me.GridInformation.Margin = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.GridInformation.Name = "GridInformation"
        Me.GridInformation.ReadOnly = True
        Me.GridInformation.RowHeadersVisible = False
        Me.GridInformation.RowTemplate.Height = 40
        Me.GridInformation.Size = New System.Drawing.Size(907, 392)
        Me.GridInformation.TabIndex = 2
        '
        'colHash
        '
        Me.colHash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colHash.HeaderText = "#"
        Me.colHash.Name = "colHash"
        Me.colHash.ReadOnly = True
        Me.colHash.Width = 35
        '
        'colRelativePath
        '
        Me.colRelativePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colRelativePath.DataPropertyName = "File Name"
        Me.colRelativePath.HeaderText = "Relative Path"
        Me.colRelativePath.Name = "colRelativePath"
        Me.colRelativePath.ReadOnly = True
        Me.colRelativePath.Width = 200
        '
        'colMessage
        '
        Me.colMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMessage.DataPropertyName = "Message"
        Me.colMessage.HeaderText = "Message"
        Me.colMessage.Name = "colMessage"
        Me.colMessage.ReadOnly = True
        Me.colMessage.Width = 400
        '
        'colOccurrence
        '
        Me.colOccurrence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colOccurrence.HeaderText = "Occurrence"
        Me.colOccurrence.Name = "colOccurrence"
        Me.colOccurrence.ReadOnly = True
        '
        'colLineNumber
        '
        Me.colLineNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colLineNumber.HeaderText = "Line Number"
        Me.colLineNumber.Name = "colLineNumber"
        Me.colLineNumber.ReadOnly = True
        Me.colLineNumber.Width = 110
        '
        'Label2
        '
        Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(3, 36)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 17)
        Label2.TabIndex = 1
        Label2.Text = "Excel Path"
        '
        'txtExcelPath
        '
        Me.txtExcelPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExcelPath.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.txtExcelPath.Location = New System.Drawing.Point(84, 33)
        Me.txtExcelPath.Name = "txtExcelPath"
        Me.txtExcelPath.ReadOnly = True
        Me.txtExcelPath.Size = New System.Drawing.Size(820, 24)
        Me.txtExcelPath.TabIndex = 3
        Me.txtExcelPath.Text = "(double click to open Windows Explorer)"
        '
        'Label3
        '
        Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(3, 66)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 17)
        Label3.TabIndex = 1
        Label3.Text = "Headers"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtMessageHeader, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFileNameHeader, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(81, 60)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(826, 30)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'txtMessageHeader
        '
        Me.txtMessageHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMessageHeader.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessageHeader.Location = New System.Drawing.Point(416, 3)
        Me.txtMessageHeader.Name = "txtMessageHeader"
        Me.txtMessageHeader.ReadOnly = True
        Me.txtMessageHeader.Size = New System.Drawing.Size(407, 23)
        Me.txtMessageHeader.TabIndex = 1
        Me.txtMessageHeader.Text = "Message: default is ""Message"" (double click to change)"
        '
        'txtFileNameHeader
        '
        Me.txtFileNameHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFileNameHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.txtFileNameHeader.Location = New System.Drawing.Point(3, 3)
        Me.txtFileNameHeader.Name = "txtFileNameHeader"
        Me.txtFileNameHeader.ReadOnly = True
        Me.txtFileNameHeader.Size = New System.Drawing.Size(407, 24)
        Me.txtFileNameHeader.TabIndex = 0
        Me.txtFileNameHeader.Text = "File Name: default is ""File Name"" (double click to change)"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(3, 95)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(51, 17)
        Label4.TabIndex = 1
        Label4.Text = "Options"
        '
        'TableLayoutPanel4
        '
        TableLayoutPanel4.AutoSize = True
        TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.80145!))
        TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58596!))
        TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.73366!))
        TableLayoutPanel4.Controls.Add(Me.chkCase, 0, 0)
        TableLayoutPanel4.Controls.Add(Me.chkRemoveSplChars, 1, 0)
        TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        TableLayoutPanel4.Location = New System.Drawing.Point(81, 90)
        TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel4.Size = New System.Drawing.Size(826, 27)
        TableLayoutPanel4.TabIndex = 5
        '
        'chkCase
        '
        Me.chkCase.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkCase.AutoSize = True
        Me.chkCase.Checked = True
        Me.chkCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCase.Location = New System.Drawing.Point(3, 3)
        Me.chkCase.Name = "chkCase"
        Me.chkCase.Size = New System.Drawing.Size(105, 21)
        Me.chkCase.TabIndex = 7
        Me.chkCase.Text = "Case Sensitive"
        Me.chkCase.UseVisualStyleBackColor = True
        '
        'chkRemoveSplChars
        '
        Me.chkRemoveSplChars.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkRemoveSplChars.AutoSize = True
        Me.chkRemoveSplChars.Checked = True
        Me.chkRemoveSplChars.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRemoveSplChars.Location = New System.Drawing.Point(116, 3)
        Me.chkRemoveSplChars.Name = "chkRemoveSplChars"
        Me.chkRemoveSplChars.Size = New System.Drawing.Size(127, 21)
        Me.chkRemoveSplChars.TabIndex = 7
        Me.chkRemoveSplChars.Text = "Remove Period (.)"
        Me.chkRemoveSplChars.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(Me.btnRunCheck)
        FlowLayoutPanel1.Controls.Add(Me.btnReset)
        FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        FlowLayoutPanel1.Location = New System.Drawing.Point(81, 117)
        FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New System.Drawing.Size(823, 25)
        FlowLayoutPanel1.TabIndex = 6
        '
        'btnRunCheck
        '
        Me.btnRunCheck.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRunCheck.Location = New System.Drawing.Point(717, 0)
        Me.btnRunCheck.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRunCheck.Name = "btnRunCheck"
        Me.btnRunCheck.Size = New System.Drawing.Size(106, 25)
        Me.btnRunCheck.TabIndex = 8
        Me.btnRunCheck.Text = "Run Checks"
        Me.btnRunCheck.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnReset.Location = New System.Drawing.Point(611, 0)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 25)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanel3.Controls.Add(Me.StatusBar, 0, 1)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.90747!))
        TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.092527!))
        TableLayoutPanel3.Size = New System.Drawing.Size(907, 562)
        TableLayoutPanel3.TabIndex = 4
        '
        'StatusBar
        '
        Me.StatusBar.AutoSize = False
        Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusBar.GripMargin = New System.Windows.Forms.Padding(1)
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBarLoading, Me.tsslTimeTaken})
        Me.StatusBar.Location = New System.Drawing.Point(0, 538)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(907, 24)
        Me.StatusBar.TabIndex = 3
        Me.StatusBar.Text = "StatusStrip1"
        '
        'ProgressBarLoading
        '
        Me.ProgressBarLoading.Name = "ProgressBarLoading"
        Me.ProgressBarLoading.Size = New System.Drawing.Size(100, 18)
        Me.ProgressBarLoading.Visible = False
        '
        'tsslTimeTaken
        '
        Me.tsslTimeTaken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslTimeTaken.Name = "tsslTimeTaken"
        Me.tsslTimeTaken.Size = New System.Drawing.Size(75, 19)
        Me.tsslTimeTaken.Text = "Time Taken: "
        '
        'SourceCheckerForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(907, 562)
        Me.Controls.Add(TableLayoutPanel3)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.MinimumSize = New System.Drawing.Size(923, 600)
        Me.Name = "SourceCheckerForm"
        Me.ShowIcon = False
        Me.Text = "Source Checker"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(Me.GridInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSourcePath As System.Windows.Forms.TextBox
    Friend WithEvents GridInformation As System.Windows.Forms.DataGridView
    Friend WithEvents txtExcelPath As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtMessageHeader As System.Windows.Forms.TextBox
    Friend WithEvents txtFileNameHeader As System.Windows.Forms.TextBox
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents ProgressBarLoading As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tsslTimeTaken As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnRunCheck As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents chkRemoveSplChars As System.Windows.Forms.CheckBox
    Friend WithEvents colHash As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRelativePath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMessage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOccurrence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLineNumber As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
