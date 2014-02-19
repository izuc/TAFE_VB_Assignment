<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSheets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSheets))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSheetCode = New System.Windows.Forms.Label
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.pnlExercises = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sheet Code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSheetCode
        '
        Me.lblSheetCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSheetCode.Location = New System.Drawing.Point(94, 9)
        Me.lblSheetCode.Name = "lblSheetCode"
        Me.lblSheetCode.Size = New System.Drawing.Size(76, 23)
        Me.lblSheetCode.TabIndex = 1
        Me.lblSheetCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(505, 331)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(12, 331)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'pnlExercises
        '
        Me.pnlExercises.AutoScroll = True
        Me.pnlExercises.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlExercises.Location = New System.Drawing.Point(15, 48)
        Me.pnlExercises.Name = "pnlExercises"
        Me.pnlExercises.Size = New System.Drawing.Size(565, 263)
        Me.pnlExercises.TabIndex = 4
        '
        'frmViewSheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 366)
        Me.Controls.Add(Me.pnlExercises)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblSheetCode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewSheets"
        Me.Text = "Sheets"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSheetCode As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents pnlExercises As System.Windows.Forms.Panel
End Class
