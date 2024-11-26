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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.rtxtQuery = New System.Windows.Forms.RichTextBox()
        Me.cmbMainClasses = New System.Windows.Forms.ComboBox()
        Me.cmbPredicates = New System.Windows.Forms.ComboBox()
        Me.btnInsertClass = New System.Windows.Forms.Button()
        Me.cmbObjects = New System.Windows.Forms.ComboBox()
        Me.btnValue = New System.Windows.Forms.Button()
        Me.btnInsertWhere = New System.Windows.Forms.Button()
        Me.btnTestQuery = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstSelectList = New System.Windows.Forms.ListBox()
        Me.btnInsertSelect = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtxtQueryResults = New System.Windows.Forms.RichTextBox()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAutoComplete = New System.Windows.Forms.Button()
        Me.btnGroupBy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(513, 133)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'rtxtQuery
        '
        Me.rtxtQuery.Location = New System.Drawing.Point(12, 171)
        Me.rtxtQuery.Name = "rtxtQuery"
        Me.rtxtQuery.Size = New System.Drawing.Size(596, 379)
        Me.rtxtQuery.TabIndex = 1
        Me.rtxtQuery.Text = resources.GetString("rtxtQuery.Text")
        '
        'cmbMainClasses
        '
        Me.cmbMainClasses.FormattingEnabled = True
        Me.cmbMainClasses.Location = New System.Drawing.Point(75, 12)
        Me.cmbMainClasses.Name = "cmbMainClasses"
        Me.cmbMainClasses.Size = New System.Drawing.Size(515, 21)
        Me.cmbMainClasses.TabIndex = 2
        '
        'cmbPredicates
        '
        Me.cmbPredicates.FormattingEnabled = True
        Me.cmbPredicates.Location = New System.Drawing.Point(75, 39)
        Me.cmbPredicates.Name = "cmbPredicates"
        Me.cmbPredicates.Size = New System.Drawing.Size(515, 21)
        Me.cmbPredicates.TabIndex = 3
        '
        'btnInsertClass
        '
        Me.btnInsertClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnInsertClass.Location = New System.Drawing.Point(614, 11)
        Me.btnInsertClass.Name = "btnInsertClass"
        Me.btnInsertClass.Size = New System.Drawing.Size(47, 23)
        Me.btnInsertClass.TabIndex = 4
        Me.btnInsertClass.Text = "+"
        Me.btnInsertClass.UseVisualStyleBackColor = True
        '
        'cmbObjects
        '
        Me.cmbObjects.FormattingEnabled = True
        Me.cmbObjects.Location = New System.Drawing.Point(75, 67)
        Me.cmbObjects.Name = "cmbObjects"
        Me.cmbObjects.Size = New System.Drawing.Size(515, 21)
        Me.cmbObjects.TabIndex = 5
        '
        'btnValue
        '
        Me.btnValue.Location = New System.Drawing.Point(614, 91)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(47, 23)
        Me.btnValue.TabIndex = 6
        Me.btnValue.Text = "Filter"
        Me.btnValue.UseVisualStyleBackColor = True
        '
        'btnInsertWhere
        '
        Me.btnInsertWhere.Location = New System.Drawing.Point(12, 133)
        Me.btnInsertWhere.Name = "btnInsertWhere"
        Me.btnInsertWhere.Size = New System.Drawing.Size(119, 23)
        Me.btnInsertWhere.TabIndex = 7
        Me.btnInsertWhere.Text = "Insert Where"
        Me.btnInsertWhere.UseVisualStyleBackColor = True
        '
        'btnTestQuery
        '
        Me.btnTestQuery.Location = New System.Drawing.Point(388, 133)
        Me.btnTestQuery.Name = "btnTestQuery"
        Me.btnTestQuery.Size = New System.Drawing.Size(119, 23)
        Me.btnTestQuery.TabIndex = 8
        Me.btnTestQuery.Tag = ""
        Me.btnTestQuery.Text = "Test Query"
        Me.btnTestQuery.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Predicate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Object"
        '
        'lstSelectList
        '
        Me.lstSelectList.FormattingEnabled = True
        Me.lstSelectList.Location = New System.Drawing.Point(614, 171)
        Me.lstSelectList.Name = "lstSelectList"
        Me.lstSelectList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSelectList.Size = New System.Drawing.Size(47, 381)
        Me.lstSelectList.TabIndex = 12
        '
        'btnInsertSelect
        '
        Me.btnInsertSelect.Location = New System.Drawing.Point(137, 133)
        Me.btnInsertSelect.Name = "btnInsertSelect"
        Me.btnInsertSelect.Size = New System.Drawing.Size(119, 23)
        Me.btnInsertSelect.TabIndex = 13
        Me.btnInsertSelect.Text = "Insert Select"
        Me.btnInsertSelect.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(611, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Variables"
        '
        'rtxtQueryResults
        '
        Me.rtxtQueryResults.Location = New System.Drawing.Point(667, 12)
        Me.rtxtQueryResults.Name = "rtxtQueryResults"
        Me.rtxtQueryResults.Size = New System.Drawing.Size(721, 628)
        Me.rtxtQueryResults.TabIndex = 15
        Me.rtxtQueryResults.Text = ""
        '
        'btnAll
        '
        Me.btnAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnAll.Location = New System.Drawing.Point(614, 38)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(47, 23)
        Me.btnAll.TabIndex = 17
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(75, 94)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(515, 20)
        Me.txtFilter.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Filter"
        '
        'btnAutoComplete
        '
        Me.btnAutoComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnAutoComplete.Location = New System.Drawing.Point(591, 11)
        Me.btnAutoComplete.Name = "btnAutoComplete"
        Me.btnAutoComplete.Size = New System.Drawing.Size(24, 23)
        Me.btnAutoComplete.TabIndex = 21
        Me.btnAutoComplete.Text = "a"
        Me.btnAutoComplete.UseVisualStyleBackColor = True
        '
        'btnGroupBy
        '
        Me.btnGroupBy.Location = New System.Drawing.Point(262, 133)
        Me.btnGroupBy.Name = "btnGroupBy"
        Me.btnGroupBy.Size = New System.Drawing.Size(119, 23)
        Me.btnGroupBy.TabIndex = 22
        Me.btnGroupBy.Text = "GroupBy"
        Me.btnGroupBy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1388, 652)
        Me.Controls.Add(Me.btnGroupBy)
        Me.Controls.Add(Me.btnAutoComplete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.rtxtQueryResults)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnInsertSelect)
        Me.Controls.Add(Me.lstSelectList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTestQuery)
        Me.Controls.Add(Me.btnInsertWhere)
        Me.Controls.Add(Me.btnValue)
        Me.Controls.Add(Me.cmbObjects)
        Me.Controls.Add(Me.btnInsertClass)
        Me.Controls.Add(Me.cmbPredicates)
        Me.Controls.Add(Me.cmbMainClasses)
        Me.Controls.Add(Me.rtxtQuery)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Form1"
        Me.Text = "SPARQL Query Builder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents rtxtQuery As RichTextBox
    Friend WithEvents cmbMainClasses As ComboBox
    Friend WithEvents cmbPredicates As ComboBox
    Friend WithEvents btnInsertClass As Button
    Friend WithEvents cmbObjects As ComboBox
    Friend WithEvents btnValue As Button
    Friend WithEvents btnInsertWhere As Button
    Friend WithEvents btnTestQuery As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstSelectList As ListBox
    Friend WithEvents btnInsertSelect As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents rtxtQueryResults As RichTextBox
    Friend WithEvents btnAll As Button
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAutoComplete As Button
    Friend WithEvents btnGroupBy As Button
End Class
