Imports System.IO
Imports System.Net
Imports mifosxcall.Class2
Imports Newtonsoft
Imports Newtonsoft.Json
Imports RestSharp
Imports RestSharp.Authenticators
Public Class general
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getdata3()
    End Sub

    Public Sub getdata3()
        System.Net.ServicePointManager.ServerCertificateValidationCallback = (Function(sender, certificate, chain, sslPolicyErrors) True)
        Dim request = WebRequest.Create("https://localhost:8443/mifosng-provider/api/v1/clients/" + Session("id"))
        SetBasicAuthHeader(request, "mifos", "password")
        request.Headers.Add("X-Mifos-Platform-TenantId", "default")
        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        '    ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()
        Dim m As RootObject = JsonConvert.DeserializeObject(Of RootObject)(responseFromServer)

        '    ' Display the content.
        '    MsgBox(responseFromServer)
        labelid.Text = m.id
        Labelname.Text = m.displayName
        Labelgender.Text = m.officeName
        Labelgov.Text = m.accountNo


        '    ' Cleanup the streams and the response.
        reader.Close()
        dataStream.Close()
        response.Close()
    End Sub

    Public Sub SetBasicAuthHeader(request As WebRequest, userName As [String], userPassword As [String])
        Dim authInfo As String = userName + ":" + userPassword
        authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
        request.Headers("Authorization") = Convert.ToString("Basic ") & authInfo
    End Sub



End Class