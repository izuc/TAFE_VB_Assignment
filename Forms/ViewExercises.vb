Public Class ViewExercises
#Region "Browse Exercises"
    Dim currentIndex As Integer = 0
    Dim selectedCode As String
    Public Sub InitClasses()
        Dim majorclass As MajorClass
        For Each majorclass In majorclassCollection
            Me.tvwClasses.Nodes.Add(majorclass.MajorCode)
        Next
    End Sub
    Public Sub ShowExercises()
        Dim exercise As Exercise
        Dim lvwitmCurrent As ListViewItem
        Me.lvwExercises.Clear()
        For Each exercise In exerciseCollection
            If (Me.tvwClasses.SelectedNode.Text.Equals(exercise.MajorClass)) Then
                lvwitmCurrent = lvwExercises.Items.Add(exercise.ExCode)
                lvwitmCurrent.SubItems.Add(exercise.Description)
                lvwitmCurrent.SubItems.Add(exercise.Subclass)
            End If
        Next
    End Sub
#End Region
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitClasses()
    End Sub

    Private Sub tvwClasses_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwClasses.AfterSelect
        ShowExercises()
        Me.lvwExercises.Columns.Add("Code", 100, HorizontalAlignment.Left)
        Me.lvwExercises.Columns.Add("Description", 100, HorizontalAlignment.Left)
        Me.lvwExercises.Columns.Add("Sub Class", 100, HorizontalAlignment.Left)
        Me.lvwExercises.View = View.Details
    End Sub

    Private Sub lvwExercises_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwExercises.SelectedIndexChanged
        selectedCode = Me.lvwExercises.FocusedItem.Text
    End Sub
End Class
