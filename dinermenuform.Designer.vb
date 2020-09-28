<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dinermenuform
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
        Me.RavioliButton = New System.Windows.Forms.Button()
        Me.PastaroniButton = New System.Windows.Forms.Button()
        Me.mabButton = New System.Windows.Forms.Button()
        Me.spaghootButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.item1Label = New System.Windows.Forms.Label()
        Me.item2Label = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RavioliButton
        '
        Me.RavioliButton.Location = New System.Drawing.Point(68, 266)
        Me.RavioliButton.Name = "RavioliButton"
        Me.RavioliButton.Size = New System.Drawing.Size(114, 62)
        Me.RavioliButton.TabIndex = 0
        Me.RavioliButton.Text = "Ravioli"
        Me.RavioliButton.UseVisualStyleBackColor = True
        '
        'PastaroniButton
        '
        Me.PastaroniButton.Location = New System.Drawing.Point(207, 266)
        Me.PastaroniButton.Name = "PastaroniButton"
        Me.PastaroniButton.Size = New System.Drawing.Size(117, 62)
        Me.PastaroniButton.TabIndex = 1
        Me.PastaroniButton.Text = "Pastaroni"
        Me.PastaroniButton.UseVisualStyleBackColor = True
        '
        'mabButton
        '
        Me.mabButton.Location = New System.Drawing.Point(348, 266)
        Me.mabButton.Name = "mabButton"
        Me.mabButton.Size = New System.Drawing.Size(120, 63)
        Me.mabButton.TabIndex = 2
        Me.mabButton.Text = "Meat-a-balls"
        Me.mabButton.UseVisualStyleBackColor = True
        '
        'spaghootButton
        '
        Me.spaghootButton.Location = New System.Drawing.Point(498, 266)
        Me.spaghootButton.Name = "spaghootButton"
        Me.spaghootButton.Size = New System.Drawing.Size(122, 63)
        Me.spaghootButton.TabIndex = 3
        Me.spaghootButton.Text = "spaghoot"
        Me.spaghootButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(654, 266)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(125, 61)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "ExitButton"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.homeButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item1Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RavioliButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.mabButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.item2Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.spaghootButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PastaroniButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ExitButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(862, 517)
        Me.SplitContainer1.SplitterDistance = 88
        Me.SplitContainer1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(359, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diner Menu"
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(348, 349)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(120, 64)
        Me.homeButton.TabIndex = 5
        Me.homeButton.Text = "Home Button"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'item1Label
        '
        Me.item1Label.Location = New System.Drawing.Point(64, 23)
        Me.item1Label.Name = "item1Label"
        Me.item1Label.Size = New System.Drawing.Size(294, 189)
        Me.item1Label.TabIndex = 2
        Me.item1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'item2Label
        '
        Me.item2Label.Location = New System.Drawing.Point(494, 23)
        Me.item2Label.Name = "item2Label"
        Me.item2Label.Size = New System.Drawing.Size(285, 189)
        Me.item2Label.TabIndex = 0
        Me.item2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(862, 425)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'dinermenuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 517)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "dinermenuform"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RavioliButton As Button
    Friend WithEvents PastaroniButton As Button
    Friend WithEvents mabButton As Button
    Friend WithEvents spaghootButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents homeButton As Button
    Friend WithEvents item1Label As Label
    Friend WithEvents item2Label As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
