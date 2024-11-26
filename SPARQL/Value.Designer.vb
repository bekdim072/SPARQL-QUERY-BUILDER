<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Value
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
        Me.cboxTrueFalse = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dpickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.dpickerTo = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpText = New System.Windows.Forms.GroupBox()
        Me.cmbTextComp = New System.Windows.Forms.ComboBox()
        Me.grpText.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboxTrueFalse
        '
        Me.cboxTrueFalse.AutoSize = True
        Me.cboxTrueFalse.Location = New System.Drawing.Point(156, 60)
        Me.cboxTrueFalse.Name = "cboxTrueFalse"
        Me.cboxTrueFalse.Size = New System.Drawing.Size(78, 17)
        Me.cboxTrueFalse.TabIndex = 0
        Me.cboxTrueFalse.Text = "True/False"
        Me.cboxTrueFalse.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(177, 103)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dpickerFrom
        '
        Me.dpickerFrom.Location = New System.Drawing.Point(116, 45)
        Me.dpickerFrom.Name = "dpickerFrom"
        Me.dpickerFrom.Size = New System.Drawing.Size(200, 20)
        Me.dpickerFrom.TabIndex = 2
        '
        'dpickerTo
        '
        Me.dpickerTo.Location = New System.Drawing.Point(116, 71)
        Me.dpickerTo.Name = "dpickerTo"
        Me.dpickerTo.Size = New System.Drawing.Size(200, 20)
        Me.dpickerTo.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Logical", "Date", "Text"})
        Me.ComboBox1.Location = New System.Drawing.Point(156, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 20)
        Me.TextBox1.TabIndex = 7
        '
        'grpText
        '
        Me.grpText.Controls.Add(Me.cmbTextComp)
        Me.grpText.Controls.Add(Me.TextBox1)
        Me.grpText.Location = New System.Drawing.Point(74, 39)
        Me.grpText.Name = "grpText"
        Me.grpText.Size = New System.Drawing.Size(317, 58)
        Me.grpText.TabIndex = 8
        Me.grpText.TabStop = False
        Me.grpText.Text = "Text"
        '
        'cmbTextComp
        '
        Me.cmbTextComp.FormattingEnabled = True
        Me.cmbTextComp.Items.AddRange(New Object() {"Contains", "Starts", "Ends", "=", "!="})
        Me.cmbTextComp.Location = New System.Drawing.Point(8, 18)
        Me.cmbTextComp.Name = "cmbTextComp"
        Me.cmbTextComp.Size = New System.Drawing.Size(71, 21)
        Me.cmbTextComp.TabIndex = 8
        '
        'Value
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 137)
        Me.Controls.Add(Me.grpText)
        Me.Controls.Add(Me.cboxTrueFalse)
        Me.Controls.Add(Me.dpickerTo)
        Me.Controls.Add(Me.dpickerFrom)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Value"
        Me.Text = "Value"
        Me.grpText.ResumeLayout(False)
        Me.grpText.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboxTrueFalse As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dpickerFrom As DateTimePicker
    Friend WithEvents dpickerTo As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents grpText As GroupBox
    Friend WithEvents cmbTextComp As ComboBox
End Class
