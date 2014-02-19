Public Class FindExercise
    Public exerciseCode As String = String.Empty
    Private Sub populateExercises()
        For Each exercise As Exercise In exerciseCollection
            Me.lstExercises.Items.Add(exercise)
        Next
    End Sub

    Private Sub FindExercise_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        populateExercises()
    End Sub

    Private Sub lstExercises_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstExercises.SelectedIndexChanged
        Try
            Dim exercise As Exercise = DirectCast(Me.lstExercises.SelectedItem, Exercise)
            Dim imagepath As String = My.Application.Info.DirectoryPath.ToString & strPIC_FOLDER & exercise.PicFileName
            Me.ptbExercise.Image = System.Drawing.Image.FromFile(imagepath)
            Me.ptbExercise.SizeMode = PictureBoxSizeMode.StretchImage
            Me.lblExerciseCode.Text = exercise.ExCode
            Me.exerciseCode = exercise.ExCode
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Search(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim ch As String
        Dim nInd As Integer
        ch = txtSearch.Text
        nInd = lstExercises.FindString(ch, 0)
        If nInd >= 0 Then
            lstExercises.SelectedIndex = nInd
        Else
            lstExercises.SelectedIndex = -1
        End If
    End Sub

    Private Sub Close_Form(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Hide()
    End Sub
End Class