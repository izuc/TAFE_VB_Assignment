Option Explicit On
Option Strict On
Public Class NewSheet
    Dim sheetExercises As Collection = New Collection
    Dim previewExercises() As Exercise
    Dim currentPage As Integer

    Dim ptbGroup() As PictureBox
    Dim lblCaptions() As Label
    Dim lblDescriptions() As Label
    Dim ptbPreview() As PictureBox
    Dim lblPreview() As Label

    Private Sub LoadExercises()
        Dim index As Integer = 0
        Dim exercise As Exercise
        Dim imagepath As String = String.Empty
        Clear()
        If (sheetExercises.Count > 0) Then
            Do While (index < ptbGroup.Length) And (index < sheetExercises.Count)
                Try
                    If Not (sheetExercises(index + 1) Is Nothing) Then
                        exercise = DirectCast(sheetExercises(index + 1), Exercise)
                        imagepath = My.Application.Info.DirectoryPath.ToString & strPIC_FOLDER & exercise.PicFileName
                        ptbGroup(index).Image = System.Drawing.Image.FromFile(imagepath)
                        ptbGroup(index).SizeMode = PictureBoxSizeMode.StretchImage
                        ptbGroup(index).Tag = index + 1
                        ptbGroup(index).Cursor = Cursors.Hand
                        lblDescriptions(index).Text = exercise.Description
                    End If
                Catch ex As Exception
                End Try
                index += 1
            Loop
        End If
    End Sub

    Private Sub Swap_Order()

    End Sub
    Private Sub Remove(ByVal ptb As PictureBox)
        If (Len(ptb.Tag) > 0) Then
            Try
                Dim exercise As Exercise = DirectCast(sheetExercises(CInt(ptb.Tag)), Exercise)
                sheetExercises.Remove(CInt(ptb.Tag))
            Catch ex As Exception
            End Try
            loadExercises()
        End If
    End Sub
    Private Sub Clear()
        For Each ptb As PictureBox In ptbGroup
            ptb.Image = Nothing
            ptb.Tag = Nothing
            ptb.Cursor = Cursors.Arrow
        Next
        For Each desc As Label In lblDescriptions
            desc.Text = Nothing
        Next
    End Sub
    Private Sub PopulateComboBoxes()
        For Each mClass As MajorClass In majorclassCollection
            Me.cmbMajorClass.Items.Add(mClass)
        Next
        For Each sClass As SubClass In subclassCollection
            Me.cmbSubClass.Items.Add(sClass)
        Next
    End Sub
    Private Sub AddExercise(ByVal selectedExercise As Exercise)
        If (sheetExercises.Count < 10) Then
            sheetExercises.Add(selectedExercise)
            loadExercises()
        Else
            MessageBox.Show("Max Reached For the Sheet")
        End If
    End Sub

    Private Sub NewSheet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadControls()
        loadExercises()
        GetPreview(1)
        populateComboBoxes()
        loadCaptions()
    End Sub

    Private Sub LoadCaptions()
        Dim index As Integer = 0
        For Each caption As Label In lblCaptions
            caption.Parent = ptbGroup(index)
            caption.Location = New Point(0, 0)
            index += 1
        Next
    End Sub

    Private Sub LoadControls()
        ptbGroup = New PictureBox() {Me.ptbExercise1, Me.ptbExercise2, Me.ptbExercise3, Me.ptbExercise4, Me.ptbExercise5, Me.ptbExercise6, Me.ptbExercise7, Me.ptbExercise8, Me.ptbExercise9, Me.ptbExercise10}
        lblCaptions = New Label() {Me.lblCaption1, Me.lblCaption2, Me.lblCaption3, Me.lblCaption4, Me.lblCaption5, Me.lblCaption6, Me.lblCaption7, Me.lblCaption8, Me.lblCaption9, Me.lblCaption10}
        lblDescriptions = New Label() {Me.lblDescription1, Me.lblDescription2, Me.lblDescription3, Me.lblDescription4, Me.lblDescription5, Me.lblDescription6, Me.lblDescription7, Me.lblDescription8, Me.lblDescription9, Me.lblDescription10}
        ptbPreview = New PictureBox() {Me.ptbPreview1, Me.ptbPreview2, Me.ptbPreview3}
        lblPreview = New Label() {Me.lblPreview1, Me.lblPreview2, Me.lblPreview3}
    End Sub

    Private Sub Add_Found_Exercise(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            addExercise(DirectCast(exerciseCollection.Item(txtCode.Text), Exercise))
        Catch ex As Exception
            MessageBox.Show("Exercise not found")
        End Try
    End Sub

    Private Sub Add_Preview_Exercise(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbPreview1.Click, ptbPreview2.Click, ptbPreview3.Click
        Try
            Dim ptb As PictureBox = DirectCast(sender, PictureBox)
            AddExercise(DirectCast(exerciseCollection.Item(CStr(ptb.Tag)), Exercise))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Exercise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptbExercise1.Click, ptbExercise2.Click, ptbExercise3.Click, ptbExercise4.Click, ptbExercise5.Click, ptbExercise6.Click, ptbExercise7.Click, ptbExercise8.Click, ptbExercise9.Click, ptbExercise10.Click
        Remove(DirectCast(sender, PictureBox))
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim frmFindExercise As New FindExercise()
        Dim exerciseCode As String = String.Empty
        frmFindExercise.ShowDialog()
        exerciseCode = frmFindExercise.exerciseCode
        frmFindExercise.Close()
        Me.txtCode.Text = exerciseCode
    End Sub

    Private Sub SelectSearch(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.Click
        Me.txtCode.SelectAll()
    End Sub

    Private Sub ToggleOrder(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeOrder.Click
        Dim arrOrder() As TextBox = New TextBox() {Me.txtPtb1, Me.txtPtb2, Me.txtPtb3, Me.txtPtb4, Me.txtPtb5, Me.txtPtb6, Me.txtPtb7, Me.txtPtb8, Me.txtPtb9, Me.txtPtb10}
        For Each txtBox As TextBox In arrOrder
            If (txtBox.Visible = False) Then
                txtBox.Visible = True
            Else
                txtBox.Visible = False
            End If
        Next
    End Sub

    Private Sub GetPreview(ByVal page As Integer)
        PopulatePreviewExercises()
        DisplayPreview(page)
    End Sub
    Private Sub PopulatePreviewExercises()
        Dim index As Integer = 0
        ReDim Me.previewExercises(0)
        For Each exercise As Exercise In exerciseCollection
            ReDim Preserve Me.previewExercises(index + 1)
            Me.previewExercises(index) = exercise
            index += 1
        Next
    End Sub

    Private Sub DisplayPreview(ByVal page As Integer)
        If (Me.previewExercises.Length > 1) Then
            ErasePreview()
            Dim perpage As Integer = 3
            Dim startIndex As Integer = 1
            Dim index As Integer = ((page - 1) * perpage) + startIndex
            Dim resultNum As Integer = Me.previewExercises.Length - 1
            Dim limit As Integer = Pages(page, perpage, index, resultNum)
            Dim count As Integer = 0
            Dim imagepath As String
            Me.currentPage = page
            If (limit > -1) Then
                Do Until index = limit
                    If Not (Me.previewExercises(index) Is Nothing) Then
                        Dim exercise As Exercise = Me.previewExercises(index)
                        imagepath = My.Application.Info.DirectoryPath.ToString & strPIC_FOLDER & exercise.PicFileName
                        ptbPreview(count).Visible = True
                        lblPreview(count).Visible = True
                        ptbPreview(count).Image = System.Drawing.Image.FromFile(imagepath)
                        ptbPreview(count).SizeMode = PictureBoxSizeMode.StretchImage
                        ptbPreview(count).Cursor = Cursors.Hand
                        ptbPreview(count).Tag = exercise.ExCode
                        lblPreview(count).Text = exercise.ExCode
                        count += 1
                        If (count = perpage) Then
                            count = 1
                        End If
                    End If
                    index += 1
                Loop
            Else
                Me.currentPage = 1
                DisplayPreview(Me.currentPage)
            End If
        Else
            GetPreview(1)
        End If
    End Sub

    Sub NextPreview(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        currentPage += 1
        DisplayPreview(currentPage)
    End Sub
    Sub PreviousPreview(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        currentPage -= 1
        DisplayPreview(currentPage)
    End Sub
    Private Sub ErasePreview()
        For Each ptb As PictureBox In ptbPreview
            ptb.Image = Nothing
            ptb.Tag = Nothing
            ptb.Visible = False
            ptb.Cursor = Cursors.Arrow
        Next
        For Each lbl As Label In lblPreview
            lbl.Text = Nothing
            lbl.Visible = False
        Next
    End Sub
    Private Function Pages(ByVal page As Integer, ByVal perpage As Integer, ByVal index As Integer, ByVal resultNum As Integer) As Integer
        Const strSLASH As String = " / "
        Dim pagescount As Integer = CInt(Math.Ceiling(resultNum / perpage))
        If (page <= pagescount) Then
            Dim limit As Integer
            If (resultNum - (index - 1)) >= perpage Then
                limit = index + perpage
            Else
                limit = index + ((resultNum - (index - 1)) Mod perpage)
            End If
            If (page = pagescount) Then
                Me.btnNext.Enabled = False
            ElseIf (page < pagescount) Then
                Me.btnNext.Enabled = True
            End If
            If (page = 1) Then
                Me.btnPrevious.Enabled = False
            ElseIf (page > 1) Then
                Me.btnPrevious.Enabled = True
            End If
            Me.lblCurrentPage.Text = CStr(page) & strSLASH & CStr(pagescount)
            Return limit
        Else
            Return -1
        End If
    End Function
End Class