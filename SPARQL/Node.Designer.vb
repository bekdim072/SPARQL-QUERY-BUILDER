<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Node
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
        Me.cmbObjects = New System.Windows.Forms.ComboBox()
        Me.btnPredicateHelp = New System.Windows.Forms.Button()
        Me.cmbPredicates = New System.Windows.Forms.ComboBox()
        Me.rtxtResults = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSelectedNode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbObjects
        '
        Me.cmbObjects.FormattingEnabled = True
        Me.cmbObjects.Location = New System.Drawing.Point(103, 77)
        Me.cmbObjects.Name = "cmbObjects"
        Me.cmbObjects.Size = New System.Drawing.Size(586, 21)
        Me.cmbObjects.TabIndex = 11
        '
        'btnPredicateHelp
        '
        Me.btnPredicateHelp.Location = New System.Drawing.Point(695, 48)
        Me.btnPredicateHelp.Name = "btnPredicateHelp"
        Me.btnPredicateHelp.Size = New System.Drawing.Size(25, 23)
        Me.btnPredicateHelp.TabIndex = 10
        Me.btnPredicateHelp.Text = "?"
        Me.btnPredicateHelp.UseVisualStyleBackColor = True
        '
        'cmbPredicates
        '
        Me.cmbPredicates.FormattingEnabled = True
        Me.cmbPredicates.Location = New System.Drawing.Point(103, 50)
        Me.cmbPredicates.Name = "cmbPredicates"
        Me.cmbPredicates.Size = New System.Drawing.Size(586, 21)
        Me.cmbPredicates.TabIndex = 9
        '
        'rtxtResults
        '
        Me.rtxtResults.Location = New System.Drawing.Point(22, 159)
        Me.rtxtResults.Name = "rtxtResults"
        Me.rtxtResults.Size = New System.Drawing.Size(776, 379)
        Me.rtxtResults.TabIndex = 7
        Me.rtxtResults.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSelectedNode
        '
        Me.txtSelectedNode.Location = New System.Drawing.Point(103, 26)
        Me.txtSelectedNode.Name = "txtSelectedNode"
        Me.txtSelectedNode.Size = New System.Drawing.Size(586, 20)
        Me.txtSelectedNode.TabIndex = 12
        '
        'Node
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 578)
        Me.Controls.Add(Me.txtSelectedNode)
        Me.Controls.Add(Me.cmbObjects)
        Me.Controls.Add(Me.btnPredicateHelp)
        Me.Controls.Add(Me.cmbPredicates)
        Me.Controls.Add(Me.rtxtResults)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Node"
        Me.Text = "Node"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbObjects As ComboBox
    Friend WithEvents btnPredicateHelp As Button
    Friend WithEvents cmbPredicates As ComboBox
    Friend WithEvents rtxtResults As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSelectedNode As TextBox
End Class
