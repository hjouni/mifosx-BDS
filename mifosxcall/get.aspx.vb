Imports System.IO
Imports System.Net
Imports mifosxcall.Class1
Imports Newtonsoft
Imports Newtonsoft.Json
Imports RestSharp
Imports RestSharp.Authenticators

Public Class _get
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getdata4()
    End Sub




    Public Sub SetBasicAuthHeader(request As WebRequest, userName As [String], userPassword As [String])
        Dim authInfo As String = userName + ":" + userPassword
        authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
        request.Headers("Authorization") = Convert.ToString("Basic ") & authInfo
    End Sub



    Public Sub getdata4()
        System.Net.ServicePointManager.ServerCertificateValidationCallback = (Function(sender, certificate, chain, sslPolicyErrors) True)
        Dim request = WebRequest.Create("https://localhost:8443/mifosng-provider/api/v1/clients/") '?fields=name")
        SetBasicAuthHeader(request, "mifos", "password")
        request.Headers.Add("X-Mifos-Platform-TenantId", "default")
        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()

        Dim m As RootObject = JsonConvert.DeserializeObject(Of RootObject)(responseFromServer)
        'Dim x As String = m.totalFilteredRecords
        ' For Each pageitem In m.pageItems
        'MsgBox(pageitem.accountNo)
        'Next
        gvRecords.DataSource = m.pageItems
        gvRecords.DataBind()


        'Dim xy As New RootObject
        'xy = JsonConvert.DeserializeObject(Of List(Of PageItem))(responseFromServer)
        'Dim m As RootObject = JsonConvert.DeserializeObject(Of RootObject)(responseFromServer)
        'Dim id As String = m.id
        'Dim displayName As String = m.displayName
        'xy = JsonConvert.DeserializeObject(Of IEnumerable(Of PageItem))(responseFromServer)
        'Dim products As List(Of RootObject2) = JsonConvert.DeserializeObject(Of List(Of RootObject2))(responseFromServer)
        'JsonConvert.DeserializeObject(Of List(Of RootObject2))(responseFromServer)
        'xy = JsonConvert.DeserializeObject(Of RootObject)(responseFromServer)


        'If responseFromServer.StartsWith("[") Then
        '    rootObject2 = JsonConvert.DeserializeObject(Of List(Of Example))(responseFromServer)(0)
        'Else
        '    rootObject2 = JsonConvert.DeserializeObject(Of Example)(responseFromServer)
        'End If
        'MsgBox(rootObject2.ToString)
        'MsgBox(xy.ToString)
        'gvRecords.DataSource = datalist

        'gvRecords.DataBind()
        ' Dim _Data As Dictionary(Of String, RootObject2) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, RootObject2))(responseFromServer.ToString())
        ' Dim json As String = responseFromServer
        '"data" should contain your JSON 

        ' Display the content.


        ' Cleanup the streams and the response.
        reader.Close()
        dataStream.Close()
        response.Close()
    End Sub

    Protected Sub gvrecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvrecords.SelectedIndexChanged
        Dim row As GridViewRow = gvrecords.SelectedRow

        Session("id") = row.Cells(1).Text
        Response.Redirect("/general.aspx")
    End Sub
End Class