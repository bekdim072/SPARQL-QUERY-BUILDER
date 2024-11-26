Public Class InstanceAutocomplete
    Public selectedClass As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        classVars.Add(Split(cmbInstances.SelectedItem, " - ")(1), Form1.cmbMainClasses.SelectedItem)
            Form1.cmbMainClasses.Items.Insert(0, Split(cmbInstances.SelectedItem, " - ")(1))
            Form1.cmbMainClasses.SelectedIndex = 0
        Me.Hide()
    End Sub

    Private Sub InstanceAutocomplete_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Εκτέλεση του query για την ανακτηση των κατηγορημάτων για την επιλεγμένη κλάση
        Dim query As String = $"
           PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>
PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>
PREFIX owl: <http://www.w3.org/2002/07/owl#>
PREFIX meshv: <http://id.nlm.nih.gov/mesh/vocab#>
PREFIX mesh: <http://id.nlm.nih.gov/mesh/>
PREFIX mesh2024: <http://id.nlm.nih.gov/mesh/2024/>
PREFIX mesh2023: <http://id.nlm.nih.gov/mesh/2023/>
PREFIX mesh2022: <http://id.nlm.nih.gov/mesh/2022/>

            SELECT DISTINCT ?instance ?instanceLabel
            WHERE {{
                 ?instance rdf:type {selectedClass} .
                 ?instance rdfs:label ?instanceLabel .
            }}
                 LIMIT 100"

        ' Εκτέλεση του query και λήψη αποτελεσμάτων
        Dim results As List(Of Dictionary(Of String, String)) = RunSparqlQuery(query)
        cmbInstances.Items.Clear()
        Dim predicateList As New List(Of String)
        ' Προσθήκη των αποτελεσμάτων στη λίστα cmbPredicates
        For Each row As Dictionary(Of String, String) In results
            If row.ContainsKey("instance") Then
                cmbInstances.Items.Add(row("instanceLabel") + " - <" + row("instance") + ">")

            End If
        Next
    End Sub
End Class