Imports System.Net, System.IO, System.Text
Public Class klOgameBot
    Dim globalURL As Uri
    Dim query As String
    Dim cookies As New CookieContainer
    Dim UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:11.0) Gecko/20100101 Firefox/11.0"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LoginButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginButton.Click
        httpPOST("http://uni113.ogame.de/game/reg/login2.php")
    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As System.EventArgs) Handles RefreshButton.Click
        httpGET(globalURL, "")
    End Sub
    Private Function httpGET(ByVal url, ByVal query)
        Dim request As HttpWebRequest

        Try
            request = HttpWebRequest.Create(url)
        Catch e As Exception
            MsgBox("Verbindung konnte nicht hergestellt werden. Bitte gib eine gültige URL ein!", , "Fehler!")
            Return ""
        End Try

        request.Method = "GET"
        request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
        request.UserAgent = UserAgent
        request.CookieContainer = cookies

        Dim response As HttpWebResponse = request.GetResponse
        Dim stream As Stream = response.GetResponseStream
        Dim reader As New StreamReader(stream)
        Dim result = reader.ReadToEnd
        reader.Close()
        response.Close()
        verarbeite(result, query)
        Return result
    End Function
    Private Sub httpPOST(ByVal url)
        Dim request As HttpWebRequest
        Dim POSTdata As String = "uni_id=&kid=&v=2&is_utf8=0&uni_url=uni113.ogame.de&login=" + UsernameBox.Text + "&pass=" + PasswortBox.Text

        Try
            request = HttpWebRequest.Create(url)
        Catch e As Exception
            MsgBox("Verbindung konnte nicht hergestellt werden. Bitte gib eine gültige URL ein!", , "Fehler!")
            Exit Sub
        End Try

        request.Method = "POST"
        request.Host = "uni113.ogame.de"
        request.UserAgent = UserAgent
        request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
        request.Referer = "http://ogame.de"
        request.ContentType = "application/x-www-form-urlencoded"
        request.CookieContainer = cookies

        Dim byteArray() As Byte = Encoding.UTF8.GetBytes(POSTdata)
        request.ContentLength = byteArray.Length
        Dim DataStream As Stream = request.GetRequestStream()
        DataStream.Write(byteArray, 0, byteArray.Length)
        DataStream.Close()

        Dim response As HttpWebResponse = request.GetResponse
        Dim stream As Stream = response.GetResponseStream
        globalURL = response.ResponseUri
        Dim reader As New StreamReader(stream)
        Dim result = reader.ReadToEnd
        reader.Close()
        response.Close()
        verarbeite(result, "anmeldung")
    End Sub
    Private Sub verarbeite(ByVal result, ByVal query)
        My.Computer.FileSystem.WriteAllText("C:\Users\Alle\Desktop\testtt.txt", result, False)
        If query = "anmeldung" Then
            If InStr(result, "Buddys") Then
                MsgBox("Anmeldung erfolgreich!", MsgBoxStyle.Information, "Erfolg!")
            End If
        ElseIf query <> "" Then
            If InStr(result, query) Then
                MsgBox("'" + query + "' gefunden!", MsgBoxStyle.Information, "Erfolg!")
            Else
                MsgBox("'" + query + "' wurde nicht gefunden.", MsgBoxStyle.Information, "Fehler!")
            End If
        End If
        'Metall
        If InStr(result, "<span id=" + Chr(34) + "resources_metal" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">") Then
            Dim i = InStr(result, "<span id=" + Chr(34) + "resources_metal" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">")
            MetallCounter.Text = result.Substring(i + 64, 5)
        End If
        'Kristall
        If InStr(result, "<span id=" + Chr(34) + "resources_crystal" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">") Then
            Dim i = InStr(result, "<span id=" + Chr(34) + "resources_crystal" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">")
            KristallCounter.Text = result.Substring(i + 62, 5)
        End If
        'Deuterium
        If InStr(result, "<span id=" + Chr(34) + "resources_deuterium" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">") Then
            Dim i = InStr(result, "<span id=" + Chr(34) + "resources_deuterium" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">")
            DeuteriumCounter.Text = result.Substring(i + 63, 5)
        End If
        'Energie
        If InStr(result, "<span id=" + Chr(34) + "resources_energy" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">") Then
            Dim i = InStr(result, "<span id=" + Chr(34) + "resources_energy" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">")
            EnergieCounter.Text = result.Substring(i + 43, 3)
        End If
    End Sub
    Private Sub PasswortBox_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PasswortBox.MouseClick
        PasswortBox.Text = ""
    End Sub
End Class