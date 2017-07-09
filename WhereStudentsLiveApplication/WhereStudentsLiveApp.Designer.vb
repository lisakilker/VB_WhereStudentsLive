<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhereStudentsLiveApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picStudents = New System.Windows.Forms.PictureBox()
        Me.lblWhereOurStudentsLive = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEnterMileage = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        CType(Me.picStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picStudents
        '
        Me.picStudents.Image = Global.WhereStudentsLiveApplication.My.Resources.Resources.World
        Me.picStudents.Location = New System.Drawing.Point(70, 27)
        Me.picStudents.Name = "picStudents"
        Me.picStudents.Size = New System.Drawing.Size(372, 179)
        Me.picStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStudents.TabIndex = 0
        Me.picStudents.TabStop = False
        '
        'lblWhereOurStudentsLive
        '
        Me.lblWhereOurStudentsLive.AutoSize = True
        Me.lblWhereOurStudentsLive.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhereOurStudentsLive.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblWhereOurStudentsLive.Location = New System.Drawing.Point(66, 210)
        Me.lblWhereOurStudentsLive.Name = "lblWhereOurStudentsLive"
        Me.lblWhereOurStudentsLive.Size = New System.Drawing.Size(241, 22)
        Me.lblWhereOurStudentsLive.TabIndex = 1
        Me.lblWhereOurStudentsLive.Text = "Where Our Students Live"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Khaki
        Me.lblCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCount.Location = New System.Drawing.Point(28, 371)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(456, 19)
        Me.lblCount.TabIndex = 2
        Me.lblCount.Text = "Our students live an average of 88.88 miles from the school"
        Me.lblCount.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'btnEnterMileage
        '
        Me.btnEnterMileage.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEnterMileage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterMileage.Location = New System.Drawing.Point(96, 246)
        Me.btnEnterMileage.Name = "btnEnterMileage"
        Me.btnEnterMileage.Size = New System.Drawing.Size(180, 35)
        Me.btnEnterMileage.TabIndex = 4
        Me.btnEnterMileage.Text = "Enter Mileage"
        Me.btnEnterMileage.UseVisualStyleBackColor = False
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(322, 214)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(120, 132)
        Me.lstDisplay.TabIndex = 5
        '
        'frmWhereStudentsLiveApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(513, 417)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnEnterMileage)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblWhereOurStudentsLive)
        Me.Controls.Add(Me.picStudents)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWhereStudentsLiveApp"
        Me.Text = "How Far Away Are Students' Homes?"
        CType(Me.picStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picStudents As System.Windows.Forms.PictureBox
    Friend WithEvents lblWhereOurStudentsLive As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEnterMileage As System.Windows.Forms.Button
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox

End Class
