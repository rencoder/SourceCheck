Imports System.IO
Imports System.Data.OleDb

Friend Class SourceCheckerForm
    Private SourcePath$ = String.Empty
    Private ExcelPath$ = String.Empty
    Private InternalGridSyncTable As New DataTable()            'Not sure whether this is required; may be removed later
    Private SearchPattern$ = "*.*"
    Private SourceContents As New Dictionary(Of String, String())
    Private ExcelFileList As New HashSet(Of String)
    Private ExcelContents As New List(Of KeyValuePair(Of String, String))
    Private TEMPTIME As New Stopwatch()
    Private WithEvents BackgroundChecks As New System.ComponentModel.BackgroundWorker() With {.WorkerReportsProgress = True}

#Region "User Interaction Handlers"
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub HeaderTextBoxes_DoubleClick(sender As Object, e As EventArgs) Handles txtFileNameHeader.DoubleClick, txtMessageHeader.DoubleClick
        CType(sender, TextBox).ReadOnly = False
        If CType(sender, TextBox).Name.Equals("txtExtension") Then
            CType(sender, TextBox).Text = "cs; vb; js; aspx"
        End If
    End Sub

    Private Sub HeaderFocusLost(sender As Object, e As EventArgs) Handles txtFileNameHeader.LostFocus, txtMessageHeader.LostFocus
        CType(sender, TextBox).ReadOnly = True
        If Not txtFileNameHeader.Text.Equals(My.Resources.ResourceFileNameHeader, StringComparison.Ordinal) Then
            colRelativePath.DataPropertyName = txtFileNameHeader.Text.Trim()
        End If

        If Not txtMessageHeader.Text.Equals(My.Resources.ResourceMessageHeader, StringComparison.Ordinal) Then
            colMessage.DataPropertyName = txtMessageHeader.Text.Trim()
        End If
    End Sub

    Private Sub txtExtension_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse e.KeyChar = ChrW(8))
    End Sub

    Private Sub UpdateGrid()
        For Each item In ExcelContents
            GridInformation.Rows.Add(item.Key, item.Value, String.Empty, String.Empty)
        Next
    End Sub

    Private Sub txtSourcePath_DoubleClick(sender As Object, e As EventArgs) Handles txtSourcePath.DoubleClick
        Using folderBrowserDialogue As New FolderBrowserDialog
            If Windows.Forms.DialogResult.OK = folderBrowserDialogue.ShowDialog() AndAlso Directory.Exists(folderBrowserDialogue.SelectedPath) Then
                txtSourcePath.Text = folderBrowserDialogue.SelectedPath & "\"
                SourcePath = txtSourcePath.Text
            End If
        End Using
    End Sub

    Private Sub txtExcelPath_DoubleClick(sender As Object, e As EventArgs) Handles txtExcelPath.DoubleClick
        Using openFileDialogue As New OpenFileDialog
            If Windows.Forms.DialogResult.OK = openFileDialogue.ShowDialog() Then
                Dim finfo As New FileInfo(openFileDialogue.FileName)
                If finfo.Exists() Then
                    txtExcelPath.Text = openFileDialogue.FileName
                    ExcelPath = txtExcelPath.Text
                End If
            End If
        End Using
    End Sub

    Private Sub btnRunCheck_Click(sender As Object, e As EventArgs) Handles btnRunCheck.Click
        TEMPTIME.Start()

        GetExcelContents()
        TEMPTIME.Stop()
        tsslTimeTaken.Text = "Time Taken: " & CStr(TEMPTIME.Elapsed.TotalMilliseconds)
    End Sub
#End Region

    Private Sub GetExcelContents()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ExcelPath & ";Extended Properties=Excel 12.0;")
        Dim da As New OleDbDataAdapter("select * from [ErrorMessages$]", con)
        Dim excelTable As New DataTable()
        da.Fill(excelTable)
        Dim fileColName = excelTable.Columns(0).ColumnName
        Dim msgColName = excelTable.Columns(1).ColumnName

        For Each row As DataRow In excelTable.Rows()
            If Not IsDBNull(row(fileColName)) And Not IsDBNull(row(msgColName)) Then
                ExcelContents.Add(New KeyValuePair(Of String, String)(System.Text.RegularExpressions.Regex.Replace(row(fileColName).ToString(), " ?\(.*?\)", String.Empty), If(chkRemoveSplChars.Checked, row(msgColName).ToString.Trim.TrimEnd("."c), row(msgColName))))
                ExcelFileList.Add(System.Text.RegularExpressions.Regex.Replace(row(fileColName).ToString(), " ?\(.*?\)", String.Empty))
            End If
        Next
        UpdateGrid()
        ProgressBarLoading.Minimum = 0
        ProgressBarLoading.Maximum = ExcelContents.Count() + 1
        ProgressBarLoading.Visible = True
        GetSourceContentsFromExcelContents()
        BackgroundChecks.RunWorkerAsync()
    End Sub

    Private Sub GetSourceContentsFromExcelContents()
        Dim fileList = Directory.GetFiles(SourcePath, SearchPattern, SearchOption.AllDirectories)
        Dim wantedFiles = fileList.Where(Function(c) Not (c.EndsWith("png") OrElse c.EndsWith("jpg") OrElse c.EndsWith("jpeg"))).ToList()

        For Each filePath In wantedFiles
            Dim relativePath$ = GetRelativePath(filePath)
            If ExcelFileList.Contains(relativePath) Then
                SourceContents.Add(relativePath, File.ReadAllLines(filePath))
            End If
        Next
    End Sub

    Private Function GetRelativePath(filePath$) As String
        Return filePath.Replace(SourcePath, String.Empty)
    End Function

    Private Function PrefixPath(filePath$) As String
        Return String.Concat(SourcePath, filePath)
    End Function

    Private Sub BackgroundChecks_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundChecks.DoWork
        RunChecks()
    End Sub

    Private Sub BackgroundChecks_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundChecks.ProgressChanged
        ProgressBarLoading.Value = e.ProgressPercentage
    End Sub

    Private Sub RunChecks()
        Dim count As Integer = 0
        For Each fileNameMessagePair In ExcelContents
            If SourceContents.ContainsKey(fileNameMessagePair.Key) Then
                UpdateGridColumns(GridInformation, fileNameMessagePair, CheckSourceContents(SourceContents(fileNameMessagePair.Key), fileNameMessagePair))
            End If
            count += 1
            BackgroundChecks.ReportProgress(count)
        Next

    End Sub

    Private Function CheckSourceContents(ByVal sourceString() As String, pair As KeyValuePair(Of String, String))
        If True = chkCase.Checked Then
            For i = 0 To sourceString.Length - 1
                If sourceString(i).Contains(pair.Value) Then
                    Return i + 1
                End If
            Next
        Else
            For i = 0 To sourceString.Length - 1
                If sourceString(i).IndexOf(pair.Value, StringComparison.OrdinalIgnoreCase) >= 0 Then
                    Return i + 1
                End If
            Next
        End If
        Return -1
    End Function

    Private Sub UpdateGridColumns(ByVal grid As DataGridView, ByVal pair As KeyValuePair(Of String, String), ByVal lineNoOrNegative As Integer)
        For Each row As DataGridViewRow In grid.Rows()
            If row.Cells("colRelativePath").Value.ToString().Equals(pair.Key) AndAlso row.Cells("colMessage").Value.ToString().Equals(pair.Value) Then
                Dim foundOrNot = lineNoOrNegative >= 0
                row.Cells("colOccurrence").Value = CStr(If(foundOrNot, "Yes", "No"))
                row.Cells("colLineNumber").Value = CStr(If(foundOrNot, lineNoOrNegative, String.Empty))
                row.Cells("colOccurrence").Style.BackColor = CType(If(foundOrNot, Color.LightGreen, Color.LightPink), Color)
            End If

        Next
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SourceContents.Clear()
        ExcelContents.Clear()
        ExcelFileList.Clear()
    End Sub

End Class