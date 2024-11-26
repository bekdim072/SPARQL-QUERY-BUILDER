Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq ' Χρησιμοποιούμε το Newtonsoft.Json για JSON parsing
Imports VDS.RDF
Imports VDS.RDF.Query


Public Class Node
    Public startingNode As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMainClasses()
    End Sub
    Private Sub LoadMainClasses()

        txtSelectedNode.Text = startingNode


        ' Παίρνουμε την επιλεγμένη κλάση
        Dim selectedClass As String = startingNode

        ' Εκτέλεση του query για την ανακτηση των κατηγορημάτων για την επιλεγμένη κλάση
        Dim query As String = $"
            PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
            SELECT DISTINCT ?predicate
            WHERE {{
                <{selectedClass}> ?predicate ?o .
            }}"

        ' Κλήση του SPARQL endpoint και λήψη αποτελεσμάτων
        Dim results As List(Of String) = ExecuteSparqlQuery(query)

        ' Ενημέρωση του cmbPredicates με τα αποτελέσματα
        cmbPredicates.Items.Clear()
        cmbPredicates.Items.AddRange(results.ToArray())

        ' Επιλογή του πρώτου αποτελέσματος
        If cmbPredicates.Items.Count > 0 Then
            cmbPredicates.SelectedIndex = 0
        End If

        '' Επιλέγουμε το πρώτο στοιχείο ως προεπιλογή
        'If cmbMainClasses.Items.Count > 0 Then
        '    cmbMainClasses.SelectedIndex = 0
        'End If
    End Sub


    Private Sub LoadObjects()
        Try
            ' Παίρνει την επιλεγμένη κλάση και το επιλεγμένο predicate
            Dim selectedClass As String = startingNode
            Dim selectedPredicate As String = cmbPredicates.SelectedItem.ToString()

            ' Δημιουργία του SPARQL ερωτήματος
            Dim sparqlQuery As String = $"
            PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
            PREFIX meshv: <http://id.nlm.nih.gov/mesh/vocab#>
            SELECT DISTINCT ?object
            WHERE {{
                ?instance rdf:type <{selectedClass}> .
                ?instance <{selectedPredicate}> ?object .
            }}"

            ' Ρύθμιση του endpoint και εκτέλεση του ερωτήματος
            Dim endpoint As New SparqlRemoteEndpoint(New Uri("https://id.nlm.nih.gov/mesh/sparql"))
            Dim results As SparqlResultSet = endpoint.QueryWithResultSet(sparqlQuery)

            ' Καθαρίζει τα αντικείμενα του ComboBox πριν το γέμισμα
            cmbObjects.Items.Clear()

            ' Προσθέτει τα αποτελέσματα στο ComboBox
            For Each result As SparqlResult In results
                cmbObjects.Items.Add(result("object").ToString())
            Next

            If cmbObjects.Items.Count > 0 Then
                cmbObjects.SelectedIndex = 0 ' Επιλέγει το πρώτο αντικείμενο
            End If

        Catch ex As Exception
            MessageBox.Show("Σφάλμα κατά την εκτέλεση του ερωτήματος: " & ex.Message)
        End Try
    End Sub






    Private Function ExecuteSparqlQuery(query As String) As List(Of String)
        ' Εισάγετε το URL του SPARQL endpoint της βάσης MeSH RDF
        Dim endpointUrl As String = "https://id.nlm.nih.gov/mesh/sparql"

        ' Δημιουργία λίστας για την αποθήκευση των αποτελεσμάτων
        Dim predicates As New List(Of String)

        ' Χρήση του SparqlRemoteEndpoint για την εκτέλεση του query
        Dim endpoint As New SparqlRemoteEndpoint(New Uri(endpointUrl))
        Dim sparqlResults As SparqlResultSet = endpoint.QueryWithResultSet(query)

        ' Επεξεργασία των αποτελεσμάτων και προσθήκη στο predicates list
        For Each result As SparqlResult In sparqlResults
            Dim predicateUri As String = result("predicate").ToString()
            predicates.Add(predicateUri)
        Next

        Return predicates
    End Function



    Public Sub GetConceptDescription()
        ' Πάρε την επιλεγμένη τιμή από το ComboBox
        Dim selectedPredicate As String = cmbPredicates.SelectedItem.ToString()

        ' Σιγουρευόμαστε ότι υπάρχει επιλεγμένη τιμή
        If String.IsNullOrEmpty(selectedPredicate) Then
            MessageBox.Show("Παρακαλώ επιλέξτε ένα Predicate από τη λίστα.")
            Return
        End If

        ' SPARQL ερώτημα για να ανακτήσουμε το about (περιγραφή)
        Dim query As String = $"
        PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>
        
        SELECT ?description
        WHERE {{
            <{selectedPredicate}> rdfs:comment ?description .
        }}"

        ' Δημιουργούμε το endpoint και εκτελούμε το ερώτημα
        Dim endpoint As New SparqlRemoteEndpoint(New Uri("http://id.nlm.nih.gov/mesh/sparql"))
        Dim results As SparqlResultSet

        Try
            ' Εκτέλεση του ερωτήματος
            results = endpoint.QueryWithResultSet(query)

            ' Έλεγχος αν έχουμε αποτελέσματα και εμφάνιση στον χρήστη
            If results.Count > 0 Then
                Dim description As String = results(0)("description").ToString()
                MessageBox.Show($"Περιγραφή: {description}")
            Else
                MessageBox.Show("Δεν βρέθηκε περιγραφή για το επιλεγμένο predicate.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Σφάλμα κατά την εκτέλεση του ερωτήματος: {ex.Message}")
        End Try
    End Sub

    Private Sub btnPredicateHelp_Click(sender As Object, e As EventArgs) Handles btnPredicateHelp.Click
        GetConceptDescription()
    End Sub

    Private Sub cmbPredicates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPredicates.SelectedIndexChanged
        LoadObjects()
    End Sub
End Class