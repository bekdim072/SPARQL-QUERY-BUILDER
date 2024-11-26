<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstanceAutocomplete
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
        Me.cmbInstances = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbInstances
        '
        Me.cmbInstances.FormattingEnabled = True
        Me.cmbInstances.Location = New System.Drawing.Point(12, 25)
        Me.cmbInstances.Name = "cmbInstances"
        Me.cmbInstances.Size = New System.Drawing.Size(522, 21)
        Me.cmbInstances.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(221, 67)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'InstanceAutocomplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 124)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbInstances)
        Me.Name = "InstanceAutocomplete"
        Me.Text = "InstanceAutocomplete"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbInstances As ComboBox
    Friend WithEvents btnSave As Button
End Class
