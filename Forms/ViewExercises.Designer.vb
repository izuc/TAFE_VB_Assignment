<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewExercises
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewExercises))
        Me.tvwClasses = New System.Windows.Forms.TreeView
        Me.lvwExercises = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'tvwClasses
        '
        Me.tvwClasses.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvwClasses.Location = New System.Drawing.Point(0, 0)
        Me.tvwClasses.Name = "tvwClasses"
        Me.tvwClasses.Size = New System.Drawing.Size(258, 368)
        Me.tvwClasses.TabIndex = 0
        '
        'lvwExercises
        '
        Me.lvwExercises.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwExercises.Location = New System.Drawing.Point(258, 0)
        Me.lvwExercises.Name = "lvwExercises"
        Me.lvwExercises.Size = New System.Drawing.Size(336, 368)
        Me.lvwExercises.TabIndex = 2
        Me.lvwExercises.UseCompatibleStateImageBehavior = False
        '
        'ViewExercises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 368)
        Me.Controls.Add(Me.lvwExercises)
        Me.Controls.Add(Me.tvwClasses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewExercises"
        Me.Text = "Exercises"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvwClasses As System.Windows.Forms.TreeView
    Friend WithEvents lvwExercises As System.Windows.Forms.ListView

End Class
