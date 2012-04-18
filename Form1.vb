Imports System.Net, System.IO
Public Class klOgameBot
    Dim url, query As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Function httpGET(ByVal url, ByVal query)
        Dim request As WebRequest
        Try
            request = WebRequest.Create(url)
        Catch e As Exception
            MsgBox("Verbindung konnte nicht hergestellt werden. Bitte gib eine gültige URL ein!", , "Fehler!")
            Return ""
        End Try
        request.Method = "GET"
        Dim response As HttpWebResponse = request.GetResponse
        Dim stream As Stream = response.GetResponseStream
        Dim reader As New StreamReader(stream)
        Dim result = reader.ReadToEnd
        reader.Close()
        response.Close()
        verarbeite(result, query)
        Return result
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        url = textbox.Text
        query = querybox.Text
        Label1.Text = httpGET(url, query)
    End Sub
    Private Sub verarbeite(ByVal result, ByVal query)
        If InStr(result, query) Then
            MsgBox("'" + query + "' gefunden!", MsgBoxStyle.Information, "Erfolg!")
        End If
    End Sub
End Class