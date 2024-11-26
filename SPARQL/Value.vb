Public Class Value
    Public objectType As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If ComboBox1.Text = "Date" Then
            ' Λήψη των ημερομηνιών από τα DateTimePickers
            Dim fromDate As String = dpickerFrom.Value.ToString("yyyy-MM-dd")
            Dim toDate As String = dpickerTo.Value.ToString("yyyy-MM-dd")

            ' Δημιουργία του SPARQL φίλτρου για το εύρος ημερομηνιών
            Dim dateFilter As String = $"FILTER (???? >= ""{fromDate}""^^xsd:date && ???? <= ""{toDate}""^^xsd:date) ."


            filterValue = dateFilter
        End If
        If ComboBox1.Text = "Text" Then
            ' Λήψη του κειμένου από το TextBox
            Dim searchText As String = TextBox1.Text

            ' Δημιουργία του SPARQL φίλτρου για το κείμενο
            ' Αντικατάστησε ?textField με το όνομα του πεδίου κειμένου
            Dim textFilter As String = String.Empty

            ' Έλεγχος για τον τύπο αναζήτησης που επιλέχθηκε στο cmbTextComp
            Select Case cmbTextComp.Text
                Case "Contains"
                    textFilter = $"FILTER (CONTAINS(STR(????), ""{searchText}"")) ."

                Case "Starts"
                    textFilter = $"FILTER (STRSTARTS(STR(????), ""{searchText}"")) ."

                Case "Ends"
                    textFilter = $"FILTER (STRENDS(STR(????), ""{searchText}"")) ."

                Case "="
                    textFilter = $"FILTER (STR(????) = ""{searchText}"") ."

                Case "!="
                    textFilter = $"FILTER (STR(????) != ""{searchText}"") ."

                    ' Προσθήκη επιπλέον περιπτώσεων αν χρειάζεται
            End Select

            ' Καταχώρηση του φίλτρου στο SPARQL query
            filterValue = textFilter
            ' Συμπλήρωσε το φίλτρο στο SPARQL query σου
            ' π.χ. query += textFilter
        End If

        If Form1.cmbObjects.Text = "" Then
            MsgBox("Δεν έχει δοθεί μεταβλητή για το φίλτρο")
            Exit Sub
        End If
        Form1.txtFilter.Text = filterValue.Replace("????", Form1.cmbObjects.Text)

        Me.Close()
    End Sub

    Private Sub Value_Load(sender As Object, e As EventArgs) Handles Me.Load
        grpText.Visible = False
        dpickerFrom.Visible = False
        dpickerTo.Visible = False
        cboxTrueFalse.Visible = False
        'If objectType = "true^^http://www.w3.org/2001/XMLSchema#boolean" Then
        '    cboxTrueFalse.Visible = True
        'End If
        'If objectType = "1999-01-01^^http://www.w3.org/2001/XMLSchema#date" Then
        '    dpickerFrom.Visible = True
        '    dpickerTo.Visible = True
        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Date" Then
            grpText.Visible = False
            dpickerFrom.Visible = True
            dpickerTo.Visible = True
            cboxTrueFalse.Visible = False
        End If
        If ComboBox1.Text = "Logical" Then
            grpText.Visible = False
            dpickerFrom.Visible = False
            dpickerTo.Visible = False
            cboxTrueFalse.Visible = True
        End If
        If ComboBox1.Text = "Text" Then
            grpText.Visible = True
            dpickerFrom.Visible = False
            dpickerTo.Visible = False
            cboxTrueFalse.Visible = False
        End If
    End Sub
End Class