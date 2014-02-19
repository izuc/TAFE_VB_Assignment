<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIForm))
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileNewSheet = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileNewExercise = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileLoadData = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileSaveData = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuViewShowExercises = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuViewShowSheets = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuWindow = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuWindowCascade = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuWindowTileHorizontal = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuWindowTileVertical = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView, Me.mnuWindow})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.MdiWindowListItem = Me.mnuWindow
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(792, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileLoadData, Me.mnuFileSaveData, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNewSheet, Me.mnuFileNewExercise})
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFileNewSheet
        '
        Me.mnuFileNewSheet.Name = "mnuFileNewSheet"
        Me.mnuFileNewSheet.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileNewSheet.Text = "&Sheet"
        '
        'mnuFileNewExercise
        '
        Me.mnuFileNewExercise.Name = "mnuFileNewExercise"
        Me.mnuFileNewExercise.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileNewExercise.Text = "&Exercise"
        '
        'mnuFileLoadData
        '
        Me.mnuFileLoadData.Name = "mnuFileLoadData"
        Me.mnuFileLoadData.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileLoadData.Text = "&Load Data"
        '
        'mnuFileSaveData
        '
        Me.mnuFileSaveData.Name = "mnuFileSaveData"
        Me.mnuFileSaveData.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSaveData.Text = "&Save Data"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewShowExercises, Me.mnuViewShowSheets})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(41, 20)
        Me.mnuView.Text = "&View"
        '
        'mnuViewShowExercises
        '
        Me.mnuViewShowExercises.Name = "mnuViewShowExercises"
        Me.mnuViewShowExercises.Size = New System.Drawing.Size(159, 22)
        Me.mnuViewShowExercises.Text = "Show &Exercises"
        '
        'mnuViewShowSheets
        '
        Me.mnuViewShowSheets.Name = "mnuViewShowSheets"
        Me.mnuViewShowSheets.Size = New System.Drawing.Size(159, 22)
        Me.mnuViewShowSheets.Text = "Show &Sheets"
        '
        'mnuWindow
        '
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowCascade, Me.mnuWindowTileHorizontal, Me.mnuWindowTileVertical})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(57, 20)
        Me.mnuWindow.Text = "&Window"
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Name = "mnuWindowCascade"
        Me.mnuWindowCascade.Size = New System.Drawing.Size(152, 22)
        Me.mnuWindowCascade.Text = "&Cascade"
        '
        'mnuWindowTileHorizontal
        '
        Me.mnuWindowTileHorizontal.Name = "mnuWindowTileHorizontal"
        Me.mnuWindowTileHorizontal.Size = New System.Drawing.Size(152, 22)
        Me.mnuWindowTileHorizontal.Text = "Tile &Horizontal"
        '
        'mnuWindowTileVertical
        '
        Me.mnuWindowTileVertical.Name = "mnuWindowTileVertical"
        Me.mnuWindowTileVertical.Size = New System.Drawing.Size(152, 22)
        Me.mnuWindowTileVertical.Text = "Tile &Vertical"
        '
        'MDIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "MDIForm"
        Me.Text = "Exercises-R-Us"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileNewSheet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileNewExercise As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileLoadData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindowCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindowTileHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindowTileVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewShowExercises As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewShowSheets As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSaveData As System.Windows.Forms.ToolStripMenuItem
End Class
