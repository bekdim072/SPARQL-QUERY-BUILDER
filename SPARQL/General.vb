Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq ' Χρησιμοποιούμε το Newtonsoft.Json για JSON parsing
Imports VDS.RDF
Imports VDS.RDF.Query
Module General
    Public prefixSelect As String = "PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>
PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>
PREFIX owl: <http://www.w3.org/2002/07/owl#>
PREFIX meshv: <http://id.nlm.nih.gov/mesh/vocab#>
PREFIX mesh: <http://id.nlm.nih.gov/mesh/>
PREFIX mesh2024: <http://id.nlm.nih.gov/mesh/2024/>
PREFIX mesh2023: <http://id.nlm.nih.gov/mesh/2023/>
PREFIX mesh2022: <http://id.nlm.nih.gov/mesh/2022/>

SELECT "
    Public fromWhere As String = "FROM <http://id.nlm.nih.gov/mesh>
WHERE {
"
    Public closeQuery As String = "} "
    Public statements As List(Of String) = New List(Of String)
    Public classVars As New Dictionary(Of String, String)
    Public predicateVars As New Dictionary(Of String, String)
    Public objectVars As New Dictionary(Of String, String)
    Public statementsString As String = ""
    Public selectString As String = ""
    Public filterValue As String = ""
    Public groupByString As String = ""
    Public aggregateSelect As String = ""
    ' Dictionary με γνωστά prefixes για γρήγορη αντιστοίχιση
    Public prefixes As New Dictionary(Of String, String) From {
    {"http://www.w3.org/1999/02/22-rdf-syntax-ns#", "rdf:"},
    {"http://www.w3.org/2000/01/rdf-schema#", "rdfs:"},
    {"http://www.w3.org/2001/XMLSchema#", "xsd:"},
    {"http://www.w3.org/2002/07/owl#", "owl:"},
    {"http://id.nlm.nih.gov/mesh/vocab#", "meshv:"},
    {"http://www.openlinksw.com/schemas/virtrdf#", "virtrdf:"}
}

    Public searchCache As New Dictionary(Of String, List(Of String))()
    Public Const MaxCacheSize As Integer = 4



    Public Function RunSparqlQuery(query As String) As List(Of Dictionary(Of String, String))
        ' Ορίζουμε το URL του SPARQL endpoint
        Dim endpointUrl As String = "https://id.nlm.nih.gov/mesh/sparql"

        ' Λίστα για την αποθήκευση των αποτελεσμάτων
        Dim resultsList As New List(Of Dictionary(Of String, String))

        Try
            ' Δημιουργία ενός SPARQL endpoint
            Dim endpoint As New SparqlRemoteEndpoint(New Uri(endpointUrl))

            ' Εκτέλεση του query και λήψη των αποτελεσμάτων
            Dim sparqlResults As SparqlResultSet = endpoint.QueryWithResultSet(query)

            ' Επεξεργασία των αποτελεσμάτων
            For Each result As SparqlResult In sparqlResults
                ' Δημιουργούμε ένα dictionary για κάθε γραμμή
                Dim rowResult As New Dictionary(Of String, String)

                ' Διατρέχουμε όλα τα variables του αποτελέσματος
                For Each variable As String In result.Variables
                    If result.HasValue(variable) Then
                        rowResult(variable) = result(variable).ToString()
                    End If
                Next

                ' Προσθέτουμε το dictionary στη λίστα
                resultsList.Add(rowResult)
            Next
        Catch ex As Exception
            MessageBox.Show("Σφάλμα στην εκτέλεση του ερωτήματος: " & ex.Message, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Επιστροφή των αποτελεσμάτων ως λίστα από dictionaries
        Return resultsList
    End Function
    ' Συνάρτηση που μετατρέπει URI σε prefix
    Public Function ConvertToPrefixed(predicateUri As String) As String

        If predicateUri.StartsWith("?") Then Return predicateUri

        For Each kvp As KeyValuePair(Of String, String) In prefixes
            If predicateUri.StartsWith(kvp.Key) Then

                ' Check if prefix is already in prefixSelect
                'If Not prefixSelect.Contains($"PREFIX {kvp.Value}: <{kvp.Key}>") Then
                '    ' Add the prefix declaration to prefixSelect
                '    prefixSelect = prefixSelect.Replace("SELECT", "")
                '    prefixSelect &= vbCrLf & $"PREFIX {kvp.Value}: <{kvp.Key}>"
                '    prefixSelect = prefixSelect & vbCrLf + "SELECT"
                'End If

                ' Αντικατάσταση του URI με το prefix
                Return predicateUri.Replace(kvp.Key, kvp.Value)
            End If
        Next


        ' Επιστρέφει το URI όπως είναι αν δεν βρεθεί prefix
        Return predicateUri
    End Function
    Function GetPrefixedName(fullUri As String) As String
        If fullUri.StartsWith("?") And fullUri.Length < 4 Then

        End If
        ' Βρίσκουμε το base URI από το πλήρες URI
        Dim baseUri As String = fullUri.Substring(0, fullUri.LastIndexOf("#") + 1)
        Dim localName As String = fullUri.Substring(fullUri.LastIndexOf("#") + 1)

        ' Αναζητούμε το prefix στο prefixSelect
        Dim matchingPrefix As String = ""
        For Each line As String In prefixSelect.Split(vbCrLf)
            If line.Contains(baseUri) Then
                matchingPrefix = line.Split(" "c)(1).Trim() ' Παίρνουμε το prefix (όπως rdf:)
                Exit For
            End If
        Next

        ' Εάν δεν υπάρχει, προσθέτουμε νέο prefix
        If matchingPrefix = "" Then
            matchingPrefix = "newPrefix:" ' Μπορείς να το αντικαταστήσεις με το επιθυμητό νέο prefix
            prefixSelect &= "PREFIX " & matchingPrefix & " <" & baseUri & ">" & vbCrLf
        End If

        ' Επιστρέφουμε το prefixed name
        Return matchingPrefix & localName
    End Function


    Public Function ConvertListToString(data As List(Of Dictionary(Of String, String))) As String
        Dim result As New List(Of String)

        ' Διατρέχουμε κάθε dictionary στη λίστα
        For Each dict As Dictionary(Of String, String) In data
            ' Μετατρέπουμε το κάθε key-value ζεύγος σε συμβολοσειρά "key: value"
            Dim dictItems As New List(Of String)
            For Each kvp As KeyValuePair(Of String, String) In dict
                dictItems.Add($"{kvp.Key}: {kvp.Value}")
            Next

            ' Συνδυάζουμε τα key-value ζεύγη κάθε dictionary σε μια γραμμή και προσθέτουμε στη συνολική λίστα
            result.Add(String.Join(", ", dictItems))
        Next

        ' Επιστρέφουμε όλες τις γραμμές ενωμένες με νέα γραμμή για κάθε dictionary
        Return String.Join(Environment.NewLine, result)
    End Function
    ' Συνάρτηση για να αντιστοιχεί prefixes με τα URIs τους
    Public Function MapPrefix(predicate As String) As String
        ' Λεξικό που αντιστοιχεί prefixes σε URIs
        Dim prefixMap As New Dictionary(Of String, String) From {
        {"rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#"},
        {"rdfs", "http://www.w3.org/2000/01/rdf-schema#"},
        {"xsd", "http://www.w3.org/2001/XMLSchema#"},
        {"owl", "http://www.w3.org/2002/07/owl#"},
        {"meshv", "http://id.nlm.nih.gov/mesh/vocab#"},
        {"mesh", "http://id.nlm.nih.gov/mesh/"}}
        ' Πρόσθεσε και άλλα prefixes αν χρειαστεί


        ' Για κάθε prefix στο λεξικό, ελέγχουμε αν το predicate ξεκινάει με το πλήρες URI
        For Each prefix As KeyValuePair(Of String, String) In prefixMap
            If predicate.StartsWith(prefix.Value) Then
                ' Αντικαθιστούμε το πλήρες URI με το prefix και το τοπικό όνομα
                Return predicate.Replace(prefix.Value, prefix.Key & ":")
            End If
        Next

        ' Αν δεν βρεθεί αντιστοιχία, επιστρέφουμε το αρχικό predicate
        Return predicate
    End Function

End Module
