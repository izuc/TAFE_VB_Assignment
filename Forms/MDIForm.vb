Public Class MDIForm
    Private Sub MDIForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g_MDIForm = Me
    End Sub

    Private Sub mnuWindowCascade_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWindowCascade.Click
        g_MDIForm.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuWindowTileHorizontal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWindowTileHorizontal.Click
        g_MDIForm.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWindowTileVertical_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWindowTileVertical.Click
        g_MDIForm.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuFileLoadData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileLoadData.Click
        LoadFile()
    End Sub

    Private Sub mnuViewShowExercises_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuViewShowExercises.Click
        Dim frmExercises As New ViewExercises()
        frmExercises.MdiParent = Me
        frmExercises.Show()
    End Sub

    Private Sub mnuViewShowSheets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewShowSheets.Click
        Dim frmViewSheets As New ViewSheets()
        frmViewSheets.MdiParent = Me
        frmViewSheets.Show()
    End Sub

    Private Sub mnuFileSaveData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSaveData.Click
        SaveData()
    End Sub

    Private Sub mnuFileNewSheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNewSheet.Click
        Dim frmNewSheet As New NewSheet()
        frmNewSheet.MdiParent = Me
        frmNewSheet.Show()
    End Sub
End Class