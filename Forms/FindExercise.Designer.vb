<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindExercise
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
        Me.lstExercises = New System.Windows.Forms.ListBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.lblSearch = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.ptbExercise = New System.Windows.Forms.PictureBox
        Me.lblExerciseCode = New System.Windows.Forms.Label
        CType(Me.ptbExercise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstExercises
        '
        Me.lstExercises.FormattingEnabled = True
        Me.lstExercises.Location = New System.Drawing.Point(12, 38)
        Me.lstExercises.Name = "lstExercises"
        Me.lstExercises.Size = New System.Drawing.Size(374, 147)
        Me.lstExercises.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(112, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(153, 20)
        Me.txtSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.Location = New System.Drawing.Point(12, 12)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(58, 20)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Search:"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(392, 158)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'ptbExercise
        '
        Me.ptbExercise.BackColor = System.Drawing.Color.White
        Me.ptbExercise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbExercise.Location = New System.Drawing.Point(392, 62)
        Me.ptbExercise.Name = "ptbExercise"
        Me.ptbExercise.Size = New System.Drawing.Size(90, 90)
        Me.ptbExercise.TabIndex = 17
        Me.ptbExercise.TabStop = False
        '
        'lblExerciseCode
        '
        Me.lblExerciseCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExerciseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExerciseCode.Location = New System.Drawing.Point(392, 34)
        Me.lblExerciseCode.Name = "lblExerciseCode"
        Me.lblExerciseCode.Size = New System.Drawing.Size(90, 25)
        Me.lblExerciseCode.TabIndex = 24
        Me.lblExerciseCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FindExercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(494, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblExerciseCode)
        Me.Controls.Add(Me.ptbExercise)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lstExercises)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FindExercise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Exercise"
        CType(Me.ptbExercise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstExercises As System.Windows.Forms.ListBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents ptbExercise As System.Windows.Forms.PictureBox
    Friend WithEvents lblExerciseCode As System.Windows.Forms.Label
End Class
