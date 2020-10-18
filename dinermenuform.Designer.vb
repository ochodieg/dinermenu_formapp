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
        Me.ballmeatButton = New System.Windows.Forms.Button()
        Me.spaghootButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.itemNameLabel = New System.Windows.Forms.Label()
        Me.itemDescriptionLabel = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RavioliButton
        '
        Me.RavioliButton.Location = New System.Drawing.Point(58, 267)
        Me.RavioliButton.Name = "RavioliButton"
        Me.RavioliButton.Size = New System.Drawing.Size(114, 62)
        Me.RavioliButton.TabIndex = 0
        Me.RavioliButton.Text = "Ravioli"
        Me.RavioliButton.UseVisualStyleBackColor = True
        '
        'PastaroniButton
        '
        Me.PastaroniButton.Location = New System.Drawing.Point(213, 267)
        Me.PastaroniButton.Name = "PastaroniButton"
        Me.PastaroniButton.Size = New System.Drawing.Size(117, 62)
        Me.PastaroniButton.TabIndex = 1
        Me.PastaroniButton.Text = "Pastaroni"
        Me.PastaroniButton.UseVisualStyleBackColor = True
        '
        'ballmeatButton
        '
        Me.ballmeatButton.Location = New System.Drawing.Point(363, 264)
        Me.ballmeatButton.Name = "ballmeatButton"
        Me.ballmeatButton.Size = New System.Drawing.Size(120, 63)
        Me.ballmeatButton.TabIndex = 2
        Me.ballmeatButton.Text = "Meat-a-balls"
        Me.ballmeatButton.UseVisualStyleBackColor = True
        '
        'spaghootButton
        '
        Me.spaghootButton.Location = New System.Drawing.Point(510, 265)
        Me.spaghootButton.Name = "spaghootButton"
        Me.spaghootButton.Size = New System.Drawing.Size(122, 63)
        Me.spaghootButton.TabIndex = 3
        Me.spaghootButton.Text = "spaghoot"
        Me.spaghootButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(666, 265)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.itemNameLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RavioliButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ballmeatButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.itemDescriptionLabel)
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
        Me.homeButton.Location = New System.Drawing.Point(363, 349)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(120, 64)
        Me.homeButton.TabIndex = 5
        Me.homeButton.Text = "Home Button"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'itemNameLabel
        '
        Me.itemNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.itemNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.itemNameLabel.Location = New System.Drawing.Point(45, 23)
        Me.itemNameLabel.Name = "itemNameLabel"
        Me.itemNameLabel.Size = New System.Drawing.Size(285, 189)
        Me.itemNameLabel.TabIndex = 2
        Me.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'itemDescriptionLabel
        '
        Me.itemDescriptionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.itemDescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.itemDescriptionLabel.Location = New System.Drawing.Point(506, 23)
        Me.itemDescriptionLabel.Name = "itemDescriptionLabel"
        Me.itemDescriptionLabel.Size = New System.Drawing.Size(285, 189)
        Me.itemDescriptionLabel.TabIndex = 0
        Me.itemDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
    Friend WithEvents ballmeatButton As Button
    Friend WithEvents spaghootButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents homeButton As Button
    Friend WithEvents itemNameLabel As Label
    Friend WithEvents itemDescriptionLabel As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
