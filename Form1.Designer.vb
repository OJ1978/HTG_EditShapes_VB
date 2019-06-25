<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.addEllipseButton = New System.Windows.Forms.ToolStripButton()
        Me.ShpCanvas1 = New EditShape.shpCanvas()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.ShpCanvas1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.propertyGrid1)
        Me.splitContainer1.Size = New System.Drawing.Size(978, 546)
        Me.splitContainer1.SplitterDistance = 732
        Me.splitContainer1.TabIndex = 5
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(242, 546)
        Me.propertyGrid1.TabIndex = 0
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addEllipseButton})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(978, 25)
        Me.toolStrip1.TabIndex = 4
        Me.toolStrip1.Text = "toolStrip1"
        '
        'addEllipseButton
        '
        Me.addEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.addEllipseButton.Image = CType(resources.GetObject("addEllipseButton.Image"), System.Drawing.Image)
        Me.addEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.addEllipseButton.Name = "addEllipseButton"
        Me.addEllipseButton.Size = New System.Drawing.Size(69, 22)
        Me.addEllipseButton.Text = "Add Ellipse"
        '
        'ShpCanvas1
        '
        Me.ShpCanvas1.BorderSnapDist = 25
        Me.ShpCanvas1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShpCanvas1.Location = New System.Drawing.Point(0, 0)
        Me.ShpCanvas1.Mode = EditShape.shpCanvas.SnapModes.SnapLines
        Me.ShpCanvas1.Name = "ShpCanvas1"
        Me.ShpCanvas1.ShapeAlignDist = 15
        Me.ShpCanvas1.ShapeSnapDist = 15
        Me.ShpCanvas1.Size = New System.Drawing.Size(732, 546)
        Me.ShpCanvas1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 571)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents splitContainer1 As SplitContainer
    Friend WithEvents ShpCanvas1 As EditShape.shpCanvas
    Private WithEvents propertyGrid1 As PropertyGrid
    Private WithEvents toolStrip1 As ToolStrip
    Private WithEvents addEllipseButton As ToolStripButton
End Class
