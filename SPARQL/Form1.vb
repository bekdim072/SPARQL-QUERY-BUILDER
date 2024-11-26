Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq ' Χρησιμοποιούμε το Newtonsoft.Json για JSON parsing
Imports VDS.RDF
Imports VDS.RDF.Query

Imports System
Public Class Form1
    Dim mainPredicates As New List(Of String) From {
    "rdf:type",
    "http://www.openlinksw.com/schemas/virtrdf#version",
    "http://www.openlinksw.com/schemas/virtrdf#loadAs",
    "http://www.openlinksw.com/schemas/virtrdf#item",
    "http://www.openlinksw.com/schemas/virtrdf#isSpecialPredicate",
    "http://www.openlinksw.com/schemas/virtrdf#isGcResistantType",
    "http://www.openlinksw.com/schemas/virtrdf#qmfName",
    "http://www.openlinksw.com/schemas/virtrdf#qmfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfLongTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfSqlvalTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfBoolTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsrefOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsuriOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsblankOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIslitOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmf01uriOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmf01blankOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfLongOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfSqlvalOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfDatatypeOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfLanguageOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfBoolOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIidOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfUriOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfStrsqlvalOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfShortOfTypedsqlvalTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfShortOfSqlvalTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfShortOfLongTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfShortOfUriTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsBijection",
    "http://www.openlinksw.com/schemas/virtrdf#qmfMapsOnlyNullToNull",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsStable",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsSubformatOfLong",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsSubformatOfLongWhenRef",
    "http://www.openlinksw.com/schemas/virtrdf#qmfCmpFuncName",
    "http://www.openlinksw.com/schemas/virtrdf#qmfTypeminTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfTypemaxTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfColumnCount",
    "http://www.openlinksw.com/schemas/virtrdf#qmfOkForAnySqlvalue",
    "http://www.openlinksw.com/schemas/virtrdf#qmfValRange-rvrRestrictions",
    "http://www.openlinksw.com/schemas/virtrdf#qmfUriIdOffset",
    "http://www.openlinksw.com/schemas/virtrdf#qmfSuperFormats",
    "rdf:_1",
    "rdf:_2",
    "rdf:_3",
    "http://www.openlinksw.com/schemas/virtrdf#inheritFrom",
    "http://www.openlinksw.com/schemas/virtrdf#noInherit",
    "rdf:_4",
    "rdf:_5",
    "http://www.openlinksw.com/schemas/virtrdf#qmfSparqlEbvTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfSparqlEbvOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfExistingShortOfTypedsqlvalTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfExistingShortOfSqlvalTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfExistingShortOfLongTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfExistingShortOfUriTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsSubformatOfLongWhenEqToSql",
    "http://www.openlinksw.com/schemas/virtrdf#qmfWrapDistinct",
    "http://www.openlinksw.com/schemas/virtrdf#qmfSubFormatForRefs",
    "http://www.openlinksw.com/schemas/virtrdf#qmfIsnumericOfShortTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfShortOfNiceSqlvalTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfDtpOfNiceSqlval",
    "http://www.openlinksw.com/schemas/virtrdf#qmfHasCheapSqlval",
    "http://www.openlinksw.com/schemas/virtrdf#qmfDatatypeTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfLanguageTmpl",
    "http://www.openlinksw.com/schemas/virtrdf#qmfValRange-rvrDatatype",
    "http://www.openlinksw.com/schemas/virtrdf#qmfCustomString1",
    "http://www.openlinksw.com/schemas/virtrdf#qmfValRange-rvrLanguage",
    "http://www.openlinksw.com/schemas/virtrdf#qmGraphMap",
    "http://www.openlinksw.com/schemas/virtrdf#qmSubjectMap",
    "http://www.openlinksw.com/schemas/virtrdf#qmPredicateMap",
    "http://www.openlinksw.com/schemas/virtrdf#qmObjectMap",
    "http://www.openlinksw.com/schemas/virtrdf#qmTableName",
    "http://www.openlinksw.com/schemas/virtrdf#qmMatchingFlags",
    "http://www.openlinksw.com/schemas/virtrdf#qmvTableName",
    "http://www.openlinksw.com/schemas/virtrdf#qmvATables",
    "http://www.openlinksw.com/schemas/virtrdf#qmvColumns",
    "http://www.openlinksw.com/schemas/virtrdf#qmvFormat",
    "http://www.openlinksw.com/schemas/virtrdf#qmvColumnsFormKey",
    "http://www.openlinksw.com/schemas/virtrdf#qmvcAlias",
    "http://www.openlinksw.com/schemas/virtrdf#qmvcColumnName",
    "http://www.openlinksw.com/schemas/virtrdf#qmvFText",
    "http://www.openlinksw.com/schemas/virtrdf#qmvGeo",
    "http://www.openlinksw.com/schemas/virtrdf#qmvaAlias",
    "http://www.openlinksw.com/schemas/virtrdf#qmvaTableName",
    "http://www.openlinksw.com/schemas/virtrdf#qmvftColumnName",
    "http://www.openlinksw.com/schemas/virtrdf#qmvftXmlIndex",
    "http://www.openlinksw.com/schemas/virtrdf#qmvftAlias",
    "http://www.openlinksw.com/schemas/virtrdf#qmvftConds",
    "http://www.openlinksw.com/schemas/virtrdf#qmvftTableName",
    "http://www.openlinksw.com/schemas/virtrdf#qsUserMaps",
    "http://www.openlinksw.com/schemas/virtrdf#qsDefaultMap",
    "http://www.openlinksw.com/schemas/virtrdf#qsMatchingFlags",
    "rdfs:subPropertyOf",
    "http://purl.org/dc/terms/created",
    "http://purl.org/dc/terms/modified",
    "http://www.openlinksw.com/schemas/DAV#ownerUser",
    "rdfs:subClassOf",
    "http://www.w3.org/ns/sparql-service-description#endpoint",
    "http://www.w3.org/ns/sparql-service-description#feature",
    "http://www.w3.org/ns/sparql-service-description#resultFormat",
    "http://www.w3.org/ns/sparql-service-description#supportedLanguage",
    "http://www.w3.org/ns/sparql-service-description#url",
    "meshv:Concept",
    "meshv:broaderConcept",
    "meshv:broader",
    "meshv:casn1_label",
    "meshv:narrowerConcept",
    "meshv:registryNumber",
    "meshv:relatedConcept",
    "meshv:relatedRegistryNumber",
    "meshv:scopeNote",
    "meshv:term",
    "meshv:frequency",
    "meshv:active",
    "meshv:concept",
    "meshv:dateCreated",
    "meshv:dateRevised",
    "meshv:identifier",
    "meshv:indexerConsiderAlso",
    "meshv:lastActiveYear",
    "meshv:mappedTo",
    "meshv:note",
    "meshv:parentTreeNumber",
    "meshv:pharmacologicalAction",
    "meshv:preferredConcept",
    "meshv:preferredMappedTo",
    "meshv:preferredTerm",
    "meshv:previousIndexing",
    "meshv:source",
    "rdfs:label",
    "meshv:allowableQualifier",
    "meshv:annotation",
    "meshv:broaderDescriptor",
    "meshv:dateEstablished",
    "meshv:hasDescriptor",
    "meshv:hasQualifier",
    "meshv:historyNote",
    "meshv:nlmClassificationNumber",
    "meshv:onlineNote",
    "meshv:publicMeSHNote",
    "meshv:seeAlso",
    "meshv:treeNumber",
    "meshv:useInstead",
    "meshv:abbreviation",
    "meshv:considerAlso",
    "owl:disjointWith",
    "owl:propertyDisjointWith",
    "owl:versionInfo",
    "rdfs:comment",
    "rdfs:domain",
    "rdfs:range",
    "http://purl.org/dc/terms/description",
    "http://xmlns.com/foaf/0.1/primaryTopic",
    "http://rdfs.org/ns/void#dataDump",
    "http://rdfs.org/ns/void#exampleResource",
    "http://rdfs.org/ns/void#feature",
    "http://rdfs.org/ns/void#sparqlEndpoint",
    "http://rdfs.org/ns/void#uriLookupEndpoint",
    "http://rdfs.org/ns/void#uriSpace",
    "http://rdfs.org/ns/void#vocabulary",
    "http://xmlns.com/foaf/0.1/homepage",
    "http://xmlns.com/foaf/0.1/page",
    "http://purl.org/dc/terms/creator",
    "http://purl.org/dc/terms/date",
    "http://purl.org/dc/terms/license",
    "http://purl.org/dc/terms/publisher",
    "http://purl.org/dc/terms/subject",
    "http://purl.org/dc/terms/title",
    "meshv:altLabel",
    "meshv:broaderQualifier",
    "meshv:entryVersion",
    "meshv:lexicalTag",
    "meshv:prefLabel",
    "meshv:sortVersion",
    "meshv:thesaurusID"
}


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMainClasses()
    End Sub
    Private Sub LoadMainClasses()
        Dim mainClasses As List(Of String) = New List(Of String) From {
    "meshv:AllowedDescriptorQualifierPair",
    "meshv:CheckTag",
    "meshv:Concept",
    "meshv:Descriptor",
    "meshv:DescriptorQualifierPair",
    "meshv:DisallowedDescriptorQualifierPair",
    "meshv:GeographicalDescriptor",
    "meshv:PublicationType",
    "meshv:Qualifier",
    "meshv:SCR_Anatomy",
    "meshv:SCR_Chemical",
    "meshv:SCR_Disease",
    "meshv:SCR_Organism",
    "meshv:SCR_Population",
    "meshv:SCR_Protocol",
    "meshv:SupplementaryConceptRecord",
    "meshv:Term",
    "meshv:TopicalDescriptor",
    "meshv:TreeNumber",
    "owl:Thing"
}

        ' Προσθήκη των κλάσεων στο combo box
        For Each className As String In mainClasses
            cmbMainClasses.Items.Add(className)
        Next
        For Each predicateName As String In mainPredicates
            cmbPredicates.Items.Add(predicateName)
        Next


        ' Αρχικοποίηση των AutoComplete χαρακτηριστικών στο ComboBox
        cmbObjects.AutoCompleteMode = AutoCompleteMode.None
        Me.Controls.Add(lstSuggestions)
        lstSuggestions.Visible = False
        lstSuggestions.BringToFront()
        Me.Controls.Add(lstSuggestions2)
        lstSuggestions2.Visible = False
        lstSuggestions2.BringToFront()
    End Sub
    Private Sub LoadObjects()
        If cmbMainClasses.SelectedItem = Nothing Then Exit Sub
        ' Παίρνουμε την επιλεγμένη κλάση
        Dim selectedClass As String = cmbMainClasses.SelectedItem.ToString()
        If classVars.ContainsKey(selectedClass) Then
            selectedClass = classVars(selectedClass)
        End If
        If cmbPredicates.SelectedItem = Nothing Then Exit Sub
        ' Παίρνουμε το επιλεγμένο predicate
        Dim selectedPredicate As String = MapPrefix(cmbPredicates.SelectedItem?.ToString())
        If String.IsNullOrEmpty(selectedPredicate) Then
            MessageBox.Show("Παρακαλώ επιλέξτε ένα predicate.")
            Return
        End If

        ' Εκτέλεση του query για την ανακτηση των αντικειμένων για την επιλεγμένη κλάση και το επιλεγμένο predicate
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

        SELECT DISTINCT ?object
        WHERE {{
            ?s a {selectedClass} .
            ?s {selectedPredicate} ?object .
        }}
        LIMIT 1000"

        ' Εκτέλεση του query και λήψη αποτελεσμάτων
        Dim results As List(Of Dictionary(Of String, String)) = RunSparqlQuery(query)
        cmbObjects.SelectedItem = Nothing
        cmbObjects.Items.Clear()

        ' Προσθήκη των αποτελεσμάτων στη λίστα cmbObjects
        For Each row As Dictionary(Of String, String) In results
            If row.ContainsKey("object") Then
                cmbObjects.Items.Add(row("object"))

            End If
        Next

        ' Αρχικοποίηση των AutoComplete χαρακτηριστικών στο ComboBox
        cmbObjects.AutoCompleteMode = AutoCompleteMode.None
        Me.Controls.Add(lstSuggestions)
        lstSuggestions.Visible = False
        lstSuggestions.BringToFront()
        Me.Controls.Add(lstSuggestions2)
        lstSuggestions2.Visible = False
        lstSuggestions2.BringToFront()
    End Sub

    Private Sub cmbMainClasses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMainClasses.SelectedIndexChanged

        cmbPredicates.SelectedItem = Nothing
        cmbObjects.SelectedItem = Nothing
        ' Παίρνουμε την επιλεγμένη κλάση
        Dim selectedClass As String = cmbMainClasses.Text
        If classVars.ContainsKey(selectedClass) Then
            selectedClass = classVars(selectedClass)
        End If
        If selectedClass = Nothing Then Exit Sub
        If searchCache.ContainsKey(selectedClass) Then
            ' Γέμισμα της λίστας από την cache
            cmbPredicates.Items.Clear()
            For Each predicate In searchCache(selectedClass)
                cmbPredicates.Items.Add(predicate)
            Next
            Return
        End If




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

            SELECT DISTINCT ?predicate
            WHERE {{
            
                ?s a {selectedClass}  .
                ?s ?predicate ?o .
            }}
                 LIMIT 100"

        ' Εκτέλεση του query και λήψη αποτελεσμάτων
        Dim results As List(Of Dictionary(Of String, String)) = RunSparqlQuery(query)
        cmbPredicates.Items.Clear()
        Dim predicateList As New List(Of String)
        ' Προσθήκη των αποτελεσμάτων στη λίστα cmbPredicates
        For Each row As Dictionary(Of String, String) In results
            If row.ContainsKey("predicate") Then
                Dim predicate As String = row("predicate")
                cmbPredicates.Items.Add(predicate)
                predicateList.Add(predicate)
            End If
        Next
        allPredicates = False
        searchCache(selectedClass) = predicateList

        ' Περιορισμός του μεγέθους της cache στις 4 τελευταίες αναζητήσεις
        If searchCache.Count > MaxCacheSize Then
            ' Αφαίρεση του πρώτου κλειδιού αν η cache υπερβαίνει το μέγιστο μέγεθος
            Dim oldestKey As String = searchCache.Keys.First()
            searchCache.Remove(oldestKey)
        End If
    End Sub

    Private Sub btnInsertWhere_Click(sender As Object, e As EventArgs) Handles btnInsertWhere.Click
        If cmbMainClasses.Text = "" Or cmbPredicates.Text = "" Or cmbObjects.Text = "" Then
            MsgBox("Συμπληρώστε όλα τα πεδία")
            Exit Sub
        End If
        Dim statement As String
        If cmbPredicates.Text.ToString.StartsWith("?") Then
            If Not predicateVars.ContainsKey(cmbPredicates.Text.ToString) Then predicateVars.Add(cmbPredicates.Text.ToString, "")
            If Not lstSelectList.Items.Contains(cmbPredicates.Text.ToString) Then lstSelectList.Items.Add(cmbPredicates.Text.ToString)
        End If
        If cmbMainClasses.Text.ToString.StartsWith("?") Then
            If Not classVars.ContainsKey(cmbMainClasses.Text.ToString) Then classVars.Add(cmbMainClasses.Text.ToString, "")
            If Not lstSelectList.Items.Contains(cmbMainClasses.Text.ToString) Then lstSelectList.Items.Add(cmbMainClasses.Text.ToString)
        End If
        If cmbObjects.Text.ToString.StartsWith("?") Then
            If Not objectVars.ContainsKey(cmbObjects.Text.ToString) Then objectVars.Add(cmbObjects.Text.ToString, "")
            If Not lstSelectList.Items.Contains(cmbObjects.Text.ToString) Then lstSelectList.Items.Add(cmbObjects.Text.ToString)
        End If
        statement = cmbMainClasses.Text + " " + ConvertToPrefixed(cmbPredicates.Text) + " " + cmbObjects.Text + "."
        statements.Add(statement)
        If Not txtFilter.Text = Nothing Then

            statements.Add(txtFilter.Text)
        End If

        statementsString = ""
        For Each s In statements
            statementsString = statementsString + s + vbCrLf
        Next




        ' rtxtQuery.Text = prefixSelect + fromWhere + statementsString + closeQuery
        rtxtQuery.Text = prefixSelect + aggregateSelect + fromWhere + statementsString + closeQuery + groupByString

        'If statements.Count = 0 Then
        '    statement = "?c1 a " + cmbMainClasses.SelectedItem + " ."
        '    classVars.Add("?c1", cmbMainClasses.SelectedItem)
        '    cmbMainClasses.Items.Insert(0, "?c1")
        '    cmbMainClasses.SelectedIndex = 0
        '    lstSelectList.Items.Add("?c1")
        '    statements.Add(statement)
        'End If
        'If cmbMainClasses.SelectedItem.ToString.Length < 4 Then
        '    If Not cmbPredicates.SelectedItem Is Nothing Then
        '        If cmbObjects.SelectedItem Is Nothing Then
        '            Dim id = "?o" + (objectVars.Count + 1).ToString

        '            statement = cmbMainClasses.SelectedItem + " " + ConvertToPrefixed(cmbPredicates.SelectedItem) + " " + id + " ."
        '            lstSelectList.Items.Add(id)
        '            objectVars.Add(id, "")
        '            statements.Add(statement)
        '        End If
        '    End If
        'End If
        'If cmbMainClasses.SelectedItem.ToString.Length < 4 Then
        '    If Not cmbPredicates.SelectedItem Is Nothing Then
        '        If Not cmbObjects.SelectedItem Is Nothing Then
        '            Dim id = "?o" + (objectVars.Count + 1).ToString

        '            statement = cmbMainClasses.SelectedItem + " " + ConvertToPrefixed(cmbPredicates.SelectedItem) + " " + id + " ."
        '            lstSelectList.Items.Add(id)
        '            objectVars.Add(id, "")
        '            statements.Add(statement)
        '            statement = Replace(filterValue, "????", id)
        '            statements.Add(statement)
        '        End If
        '    End If
        'End If


        'statementsString = ""
        'For Each s In statements
        '    statementsString = statementsString + s + vbCrLf
        'Next




        'rtxtQuery.Text = prefixSelect + fromWhere + statementsString + closeQuery
    End Sub

    Private Sub btnTestQuery_Click(sender As Object, e As EventArgs) Handles btnTestQuery.Click
        If selectString = "" Then
            MsgBox("Δεν έχετε επιλέξει μεταβλητές στο Select")
            Exit Sub
        End If
        rtxtQueryResults.Text = ConvertListToString(RunSparqlQuery(rtxtQuery.Text))
        If rtxtQueryResults.Text = "" Then rtxtQueryResults.Text = "No results found"
        cmbMainClasses.SelectedItem = Nothing
        cmbPredicates.SelectedItem = Nothing
        cmbObjects.SelectedItem = Nothing
        cmbMainClasses.Text = ""
        cmbPredicates.Text = ""
        cmbObjects.Text = ""
        txtFilter.Text = Nothing
    End Sub

    Private Sub btnInsertSelect_Click(sender As Object, e As EventArgs) Handles btnInsertSelect.Click
        Dim selectedItems As New List(Of String)

        ' Προσθήκη κάθε επιλεγμένου στοιχείου στη λίστα
        For Each selectedItem As String In lstSelectList.SelectedItems
            selectedItems.Add(selectedItem)
        Next

        ' Συγκέντρωση των τιμών σε μια συμβολοσειρά με κενό ανάμεσα
        selectString = String.Join(" ", selectedItems)

        'rtxtQuery.Text = prefixSelect + " " + selectString + " " + fromWhere + statementsString + closeQuery
        rtxtQuery.Text = prefixSelect + " " + selectString + " " + aggregateSelect + fromWhere + statementsString + closeQuery + groupByString
    End Sub

    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        Dim valueForm As New Value
        'valueForm.objectType = cmbObjects.Text
        valueForm.Show()
    End Sub

    Private Sub cmbPredicates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPredicates.SelectedIndexChanged
        LoadObjects()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rtxtQuery.Text = "PREFIX meshv: <http://id.nlm.nih.gov/mesh/vocab#>
PREFIX mesh: <http://id.nlm.nih.gov/mesh/>
PREFIX mesh2024: <http://id.nlm.nih.gov/mesh/2024/>
PREFIX mesh2023: <http://id.nlm.nih.gov/mesh/2023/>
PREFIX mesh2022: <http://id.nlm.nih.gov/mesh/2022/>

SELECT 
FROM <http://id.nlm.nih.gov/mesh>
WHERE {
} "
        cmbMainClasses.Text = ""
        cmbPredicates.Text = ""
        cmbObjects.Text = ""
        txtFilter.Text = ""
        statements.Clear()
        predicateVars.Clear()
        classVars.Clear()
        objectVars.Clear()
        statementsString = ""
        groupByString = ""
        aggregateSelect = ""
        selectString = ""
        filterValue = ""
        lstSelectList.Items.Clear()
        For i As Integer = cmbMainClasses.Items.Count - 1 To 0 Step -1
            If cmbMainClasses.Items(i).ToString().StartsWith("?") Then
                cmbMainClasses.Items.RemoveAt(i)
            End If
        Next
        rtxtQueryResults.Text = ""
    End Sub

    Private Sub btnInsertClass_Click(sender As Object, e As EventArgs) Handles btnInsertClass.Click
        If cmbMainClasses.SelectedItem = Nothing Then
            Exit Sub
        End If
        Dim statement As String
        If statements.Count = 0 Then
            statement = "?c1 a " + cmbMainClasses.SelectedItem + " ."
            classVars.Add("?c1", cmbMainClasses.SelectedItem)
            cmbMainClasses.Items.Insert(0, "?c1")
            cmbMainClasses.SelectedIndex = 0
            lstSelectList.Items.Add("?c1")
            statements.Add(statement)
        End If

        statementsString = ""
        For Each s In statements
            statementsString = statementsString + s + vbCrLf
        Next

        rtxtQuery.Text = prefixSelect + fromWhere + statementsString + closeQuery
    End Sub


    ' Δημιουργία του βοηθητικού ListBox
    Private WithEvents lstSuggestions As New ListBox()
    Private WithEvents lstSuggestions2 As New ListBox()
    Private suggestionControl As String = ""

    ' Αρχικοποίηση του ComboBox και του ListBox κατά τη φόρτωση της φόρμας

    ' Ενημέρωση του ListBox με τα αποτελέσματα αναζήτησης

    ' Ανίχνευση πατήματος του Enter στο ComboBox
    Private Sub cmbObjects_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbObjects.KeyDown
        ' Ελέγχει αν πατήθηκε το Enter
        If e.KeyCode = Keys.Enter Then
            ' Ενέργειες όταν πατηθεί το Enter
            e.SuppressKeyPress = True ' Αποτρέπει την περαιτέρω επεξεργασία του Enter
            Dim searchText As String = cmbObjects.Text.ToLower()
            ' Έλεγχος για πλήρη ταύτιση
            If cmbObjects.Items.Cast(Of String).Any(Function(item) item.ToLower() = searchText) Then
                ' Αν υπάρχει πλήρης ταύτιση με στοιχείο της λίστας, έξοδος από τη συνάρτηση
                lstSuggestions.Visible = False
                Return
            End If




            ' Φιλτράρισμα της λίστας
            Dim matchingItems = cmbObjects.Items.Cast(Of String).Where(Function(item) item.ToLower().Contains(searchText)).ToArray()

            If matchingItems.Length > 0 Then
                ' Εμφάνιση και ρύθμιση των αποτελεσμάτων στο ListBox
                lstSuggestions.Items.Clear()
                lstSuggestions.Items.AddRange(matchingItems)
                lstSuggestions.Visible = True
                lstSuggestions.Location = New Point(cmbObjects.Left, cmbObjects.Bottom)
                lstSuggestions.Width = cmbObjects.Width
                lstSuggestions.Height = Math.Min(100, lstSuggestions.PreferredHeight)
                suggestionControl = "cmbObjects"
            Else
                lstSuggestions.Visible = False
                suggestionControl = ""
            End If
        End If
    End Sub




    ' Χειρισμός επιλογής στοιχείου από το ListBox
    Private Sub lstSuggestions_Click(sender As Object, e As EventArgs) Handles lstSuggestions.Click
        If lstSuggestions.SelectedItem IsNot Nothing Then
            cmbObjects.Text = lstSuggestions.SelectedItem.ToString()

            lstSuggestions.Visible = False
        End If
    End Sub
    Private Sub lstSuggestions2_Click(sender As Object, e As EventArgs) Handles lstSuggestions2.Click
        If lstSuggestions2.SelectedItem IsNot Nothing Then
            cmbPredicates.Text = lstSuggestions2.SelectedItem.ToString()

            lstSuggestions2.Visible = False
        End If
    End Sub

    ' Απόκρυψη του ListBox όταν το ComboBox χάνει την εστίαση
    Private Sub cmbObjects_LostFocus(sender As Object, e As EventArgs) Handles cmbObjects.LostFocus
        ' Απόκρυψη του ListBox αν δεν είναι ενεργό
        If Not lstSuggestions.Focused Then
            lstSuggestions.Visible = False
        End If
    End Sub


    ' Απόκρυψη του ListBox όταν αυτό χάνει την εστίαση
    Private Sub lstSuggestions_LostFocus(sender As Object, e As EventArgs) Handles lstSuggestions.LostFocus
        lstSuggestions.Visible = False
    End Sub
    Private Sub lstSuggestions2_LostFocus(sender As Object, e As EventArgs) Handles lstSuggestions2.Leave
        lstSuggestions2.Visible = False
    End Sub
    Private allPredicates As Boolean = False
    Private Sub cmbPredicates_Click(sender As Object, e As EventArgs) Handles cmbPredicates.Click

        '        If allPredicates Then Exit Sub
        '        If Not cmbMainClasses.SelectedItem = Nothing Then Exit Sub
        '        cmbPredicates.SelectedItem = Nothing
        '        cmbObjects.SelectedItem = Nothing



        '        allPredicates = True
        '        ' Εκτέλεση του query για την ανακτηση των κατηγορημάτων για την επιλεγμένη κλάση
        '        Dim query As String = $"
        '           PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
        'PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>
        'PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>
        'PREFIX owl: <http://www.w3.org/2002/07/owl#>
        'PREFIX meshv: <http://id.nlm.nih.gov/mesh/vocab#>
        'PREFIX mesh: <http://id.nlm.nih.gov/mesh/>
        'PREFIX mesh2024: <http://id.nlm.nih.gov/mesh/2024/>
        'PREFIX mesh2023: <http://id.nlm.nih.gov/mesh/2023/>
        'PREFIX mesh2022: <http://id.nlm.nih.gov/mesh/2022/>

        '            SELECT DISTINCT ?predicate
        '            WHERE {{


        '                ?s ?predicate ?o .
        '            }}
        '                 LIMIT 1000"

        '        ' Εκτέλεση του query και λήψη αποτελεσμάτων
        '        Dim results As List(Of Dictionary(Of String, String)) = RunSparqlQuery(query)
        '        cmbPredicates.Items.Clear()
        '        Dim predicateList As New List(Of String)
        '        ' Προσθήκη των αποτελεσμάτων στη λίστα cmbPredicates
        '        For Each row As Dictionary(Of String, String) In results
        '            If row.ContainsKey("predicate") Then
        '                Dim predicate As String = row("predicate")
        '                cmbPredicates.Items.Add(predicate)
        '                predicateList.Add(predicate)
        '            End If
        '        Next

    End Sub


    ' Προσθήκη χειριστή για το KeyDown event στο ComboBox
    Private Sub cmbPredicates_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPredicates.KeyDown
        ' Έλεγχος αν το πλήκτρο που πατήθηκε είναι το Enter
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim searchText As String = cmbPredicates.Text.ToLower()
            ' Έλεγχος για πλήρη ταύτιση
            If cmbPredicates.Items.Cast(Of String).Any(Function(item) item.ToLower() = searchText) Then
                ' Αν υπάρχει πλήρης ταύτιση με στοιχείο της λίστας, έξοδος από τη συνάρτηση
                lstSuggestions2.Visible = False
                Return
            End If

            ' Φιλτράρισμα της λίστας
            Dim matchingItems = cmbPredicates.Items.Cast(Of String).Where(Function(item) item.ToLower().Contains(searchText)).ToArray()

            If matchingItems.Length > 0 Then
                ' Εμφάνιση και ρύθμιση των αποτελεσμάτων στο ListBox
                lstSuggestions2.Items.Clear()
                lstSuggestions2.Items.AddRange(matchingItems)
                lstSuggestions2.Visible = True
                lstSuggestions2.Location = New Point(cmbPredicates.Left, cmbPredicates.Bottom)
                lstSuggestions2.Width = cmbPredicates.Width
                lstSuggestions2.Height = Math.Min(100, lstSuggestions2.PreferredHeight)
                lstSuggestions2.BringToFront()
                suggestionControl = "cmbPredicates"
            Else
                lstSuggestions2.Visible = False
                suggestionControl = ""
            End If
        End If
    End Sub



    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        For Each predicateName As String In mainPredicates
            cmbPredicates.Items.Add(predicateName)
        Next

    End Sub

    Private Sub btnAutoComplete_Click(sender As Object, e As EventArgs) Handles btnAutoComplete.Click
        Dim newAutoComplete As New InstanceAutocomplete
        newAutoComplete.selectedClass = cmbMainClasses.SelectedItem
        newAutoComplete.Show()
    End Sub

    Private Sub btnGroupBy_Click(sender As Object, e As EventArgs) Handles btnGroupBy.Click
        Dim newGroupBy As New GroupBy

        newGroupBy.Show()
    End Sub
End Class
