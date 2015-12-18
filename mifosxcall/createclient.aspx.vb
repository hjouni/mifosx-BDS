Imports System.IO
Imports System.Net
Imports mifosxcall.Client
Imports Newtonsoft
Imports Newtonsoft.Json
Imports RestSharp
Imports RestSharp.Authenticators
Public Class createclient
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub
    Public Sub SetBasicAuthHeader(request As WebRequest, userName As [String], userPassword As [String])
        Dim authInfo As String = userName + ":" + userPassword
        authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
        request.Headers("Authorization") = Convert.ToString("Basic ") & authInfo
    End Sub

    Sub creatclient()
        System.Net.ServicePointManager.ServerCertificateValidationCallback = (Function(sender, certificate, chain, sslPolicyErrors) True)
        Dim request = WebRequest.Create("https://localhost:8443/mifosng-provider/api/v1/clients/")
        SetBasicAuthHeader(request, "mifos", "password")
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("X-Mifos-Platform-TenantId", "default")
        Using streamWriter = New StreamWriter(request.GetRequestStream())
            Dim json As String = "{""officeId:""1"",""firstname"":""Petra"",""lastname"":""Yton"",""externalId"":""86YYH7"",""dateFormat"":""2009-02-01"",""locale"":""en"",""active"":""true"",""activationDate"":""2009-02-03"",""submittedOnDate"":""2009-02-03"",""savingsProductId"":""4""}"
            'Dim json As String = "{""officeId"":""1"",""firstname"":""Petra"",""lastname"":""Yton"",""externalId"":""86YYH7"",""dateFormat"":""2009-02-01"",""locale"":""en"",""active"":""true"",""activationDate"":""2009-02-03"",""submittedOnDate"":""2009-02-03"",""savingsProductId"":""4""}"

            streamWriter.Write(json)
            streamWriter.Flush()
            streamWriter.Close()

        End Using
        Dim httpResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        Dim dataStream As Stream = httpResponse.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()

        Dim m As create = JsonConvert.DeserializeObject(Of create)(responseFromServer)
        MsgBox(m.clientId + m.officeId + m.resourceId + m.savingsId)


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        creatclient()

    End Sub
End Class