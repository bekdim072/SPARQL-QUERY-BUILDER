<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupBy
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
        Me.lstGroupBy = New System.Windows.Forms.ListBox()
        Me.txtGroupBy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAggregate = New System.Windows.Forms.ComboBox()
        Me.txtAggregates = New System.Windows.Forms.TextBox()
        Me.Aggregates = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGroupBy
        '
        Me.lstGroupBy.FormattingEnabled = True
        Me.lstGroupBy.Location = New System.Drawing.Point(54, 63)
        Me.lstGroupBy.Name = "lstGroupBy"
        Me.lstGroupBy.Size = New System.Drawing.Size(120, 95)
        Me.lstGroupBy.TabIndex = 0
        '
        'txtGroupBy
        '
        Me.txtGroupBy.Location = New System.Drawing.Point(54, 37)
        Me.txtGroupBy.Name = "txtGroupBy"
        Me.txtGroupBy.Size = New System.Drawing.Size(120, 20)
        Me.txtGroupBy.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GroupBy"
        '
        'cmbAggregate
        '
        Me.cmbAggregate.FormattingEnabled = True
        Me.cmbAggregate.Items.AddRange(New Object() {"COUNT", "AVG", "SUM", "MIN", "MAX"})
        Me.cmbAggregate.Location = New System.Drawing.Point(189, 63)
        Me.cmbAggregate.Name = "cmbAggregate"
        Me.cmbAggregate.Size = New System.Drawing.Size(374, 21)
        Me.cmbAggregate.TabIndex = 3
        '
        'txtAggregates
        '
        Me.txtAggregates.Location = New System.Drawing.Point(189, 37)
        Me.txtAggregates.Name = "txtAggregates"
        Me.txtAggregates.Size = New System.Drawing.Size(374, 20)
        Me.txtAggregates.TabIndex = 4
        '
        'Aggregates
        '
        Me.Aggregates.AutoSize = True
        Me.Aggregates.Location = New System.Drawing.Point(186, 21)
        Me.Aggregates.Name = "Aggregates"
        Me.Aggregates.Size = New System.Drawing.Size(61, 13)
        Me.Aggregates.TabIndex = 5
        Me.Aggregates.Text = "Aggregates"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(246, 172)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 235)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Aggregates)
        Me.Controls.Add(Me.txtAggregates)
        Me.Controls.Add(Me.cmbAggregate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGroupBy)
        Me.Controls.Add(Me.lstGroupBy)
        Me.Name = "GroupBy"
        Me.Text = "GroupBy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGroupBy As ListBox
    Friend WithEvents txtGroupBy As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAggregate As ComboBox
    Friend WithEvents txtAggregates As TextBox
    Friend WithEvents Aggregates As Label
    Friend WithEvents btnSave As Button
End Class
