Public Class ViewSheets
#Region "Browse Sheets"
    Dim currentSheet As Integer
    Public Sub ShowSheet(ByVal index As Integer)
        currentSheet = index
        If (index > 0) And (index <= sheetCollection.Count) Then
            If Not (sheetCollection.Item(index) Is Nothing) Then
                Dim sheet As Sheet = DirectCast(sheetCollection.Item(index), Sheet)
                Me.lblSheetCode.Text = CStr(sheet.SheetCode)
                DisplayExercises(sheet)
            End If
        End If
    End Sub
    Public Sub DisplayExercises(ByVal sheet As Sheet)
        Dim count As Integer = 0
        Dim ptbExercise(count) As PictureBox
        Dim lblExerciseDesc(count) As Label
        Dim imagepath As String = String.Empty
        Me.pnlExercises.Controls.Clear()
        For Each code As String In sheet.ExCode
            Try
                If Not (exerciseCollection.Item(code) Is Nothing) Then
                    Dim exercise As Exercise = DirectCast(exerciseCollection.Item(code), Exercise)
                    ReDim Preserve ptbExercise(count)
                    ReDim Preserve lblExerciseDesc(count)
                    imagepath = My.Application.Info.DirectoryPath.ToString & strPIC_FOLDER & exercise.PicFileName
                    ptbExercise(count) = New PictureBox
                    lblExerciseDesc(count) = New Label
                    ptbExercise(count).Image = System.Drawing.Image.FromFile(imagepath)
                    ptbExercise(count).Size = New Size(100, 100)
                    lblExerciseDesc(count).Size = New Size(100, 100)
                    ptbExercise(count).Location = New Point(0, count * 105)
                    lblExerciseDesc(count).Location = New Point(110, count * 105)
                    lblExerciseDesc(count).Text = exercise.Description
                    ptbExercise(count).SizeMode = PictureBoxSizeMode.StretchImage
                    Me.pnlExercises.Controls.Add(ptbExercise(count))
                    Me.pnlExercises.Controls.Add(lblExerciseDesc(count))
                    count += 1
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub
    Sub NextSheet()
        If (currentSheet < sheetCollection.Count) Then
            currentSheet += 1
            ShowSheet(currentSheet)
        End If
    End Sub
    Sub PreviousSheet()
        If (currentSheet > 1) Then
            currentSheet -= 1
            ShowSheet(currentSheet)
        End If
    End Sub
#End Region
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        NextSheet()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        PreviousSheet()
    End Sub

    Private Sub ViewSheets_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ShowSheet(1)
    End Sub
End Class