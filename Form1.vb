Imports System.Net, System.IO, System.Text
Public Class klOgameBot
    Dim metalCosts(40, 10), crystalCosts(40, 10), deuteriumCosts(40, 10) As Integer
    Dim globalURL As Uri
    Dim query As String
    Dim cookies As New CookieContainer
    Dim logged_in As Boolean
    Dim startPos_temp As Integer
    Dim UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:11.0) Gecko/20100101 Firefox/11.0"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initializeCostArrays()
    End Sub
    Private Sub PasswortBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PasswortBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginButton.PerformClick()
            PasswortBox.DeselectAll()
        End If
    End Sub
    Private Sub LoginButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginButton.Click
        httpPOST("http://uni113.ogame.de/game/reg/login2.php")
    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As System.EventArgs) Handles RefreshButton.Click
        If logged_in = True Then
            httpGET(globalURL)
        Else
            MsgBox("Sie sind nicht angemeldet!", MsgBoxStyle.Information, "Fehler!")
        End If
    End Sub
    Private Sub PasswortBox_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PasswortBox.MouseClick
        If PasswortBox.Text = "passwort" And logged_in = False Then
            PasswortBox.Text = ""
        End If
    End Sub
    Private Sub UsernameBox_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles UsernameBox.MouseClick
        If UsernameBox.Text = "Epinephrine" And logged_in = False Then
            UsernameBox.Text = ""
        End If
    End Sub
    Private Sub initializeCostArrays()
        'Costs:
        '1: Metallmine
        '2: Kristallmine
        '3: Deuteriumsynhtetisierer
        '4: Solarkraftwerk
        metalCosts(1, 1) = 60
        metalCosts(2, 1) = 90
        metalCosts(3, 1) = 135
        metalCosts(4, 1) = 202
        metalCosts(5, 1) = 303
        metalCosts(6, 1) = 455
        metalCosts(7, 1) = 683
        metalCosts(8, 1) = 1025
        metalCosts(9, 1) = 1537
        metalCosts(10, 1) = 2306
        metalCosts(11, 1) = 3459
        metalCosts(12, 1) = 5189
        metalCosts(13, 1) = 7784
        metalCosts(14, 1) = 11677
        metalCosts(15, 1) = 17515
        metalCosts(16, 1) = 26273
        metalCosts(17, 1) = 39410
        metalCosts(18, 1) = 59115
        metalCosts(19, 1) = 88673
        metalCosts(20, 1) = 133010
        crystalCosts(1, 1) = 15
        crystalCosts(2, 1) = 22
        crystalCosts(3, 1) = 33
        crystalCosts(4, 1) = 50
        crystalCosts(5, 1) = 75
        crystalCosts(6, 1) = 113
        crystalCosts(7, 1) = 170
        crystalCosts(8, 1) = 256
        crystalCosts(9, 1) = 384
        crystalCosts(10, 1) = 576
        crystalCosts(11, 1) = 864
        crystalCosts(12, 1) = 1297
        crystalCosts(13, 1) = 1946
        crystalCosts(14, 1) = 2919
        crystalCosts(15, 1) = 4378
        crystalCosts(16, 1) = 6568
        crystalCosts(17, 1) = 9852
        crystalCosts(18, 1) = 14778
        crystalCosts(19, 1) = 22168
        crystalCosts(20, 1) = 33252
    End Sub
    Private Function httpGET(ByVal url)
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
        'Dim result_filtered = filterString(result, " ", False)
        My.Computer.FileSystem.WriteAllText("C:\Users\Alle\Desktop\testtt.txt", result, False)
        If query = "anmeldung" Then
            If InStr(result, "Buddys") Then
                MsgBox("Anmeldung erfolgreich!", MsgBoxStyle.Information, "Erfolg!")
                LoginButton.Enabled = False
                UsernameBox.ReadOnly = True
                PasswortBox.ReadOnly = True
                logged_in = True
            End If
        ElseIf query <> "" Then
            If InStr(result, query) Then
                MsgBox("'" + query + "' gefunden!", MsgBoxStyle.Information, "Erfolg!")
            Else
                MsgBox("'" + query + "' wurde nicht gefunden.", MsgBoxStyle.Information, "Fehler!")
            End If
        End If
        'Metall
        MetallCounter.Text = trimStringNumeric(getHTMLcontent("<span id=" + Chr(34) + "resources_metal" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">", "</span>", result, 1))
        If MetallCounter.Text = "" Then
            MetallCounter.Text = trimStringNumeric(getHTMLcontent("<span id=" + Chr(34) + "resources_metal" + Chr(34) + " class=" + Chr(34) + "overmark" + Chr(34) + ">", "</span>", result, 1))
        End If
        'Kristall
        KristallCounter.Text = trimStringNumeric(getHTMLcontent("<span id=" + Chr(34) + "resources_crystal" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">", "</span>", result, 1))
        If KristallCounter.Text = "" Then
            KristallCounter.Text = trimStringNumeric(getHTMLcontent("<span id=" + Chr(34) + "resources_crystal" + Chr(34) + " class=" + Chr(34) + "overmark" + Chr(34) + ">", "</span>", result, 1))
        End If
        'Deuterium
        DeuteriumCounter.Text = trimStringNumeric(getHTMLcontent("<span id=" + Chr(34) + "resources_deuterium" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">", "</span>", result, 1))
        If DeuteriumCounter.Text = "" Then
            DeuteriumCounter.Text = trimStringNumeric(getHTMLcontent("<span id=" + Chr(34) + "resources_deuterium" + Chr(34) + " class=" + Chr(34) + "overmark" + Chr(34) + ">", "</span>", result, 1))
        End If
        'Energie
        EnergieCounter.Text = trimStringNumeric(getHTMLcontent("<span id=" + Chr(34) + "resources_energy" + Chr(34) + " class=" + Chr(34) + Chr(34) + ">", "</span>", result, 1))
        If EnergieCounter.Text = "" Then
            EnergieCounter.Text = trimStringNumeric(getHTMLcontent("<span id=" + Chr(34) + "resources_energy" + Chr(34) + " class=" + Chr(34) + "overmark" + Chr(34) + ">", "</span>", result, 1))
        End If
        'Momentan im Bau
        imBauText.Text = getBuildingInProgress(result)
        inForschungText.Text = getScienceInProgress(result)
        inSchiffswerftText.Text = getConstructionInProgress(result)
        getBuildingLevels()
    End Sub
    Private Function filterString(ByVal source, ByVal match, ByVal Include)
        Dim sourceArray(0) As String
        sourceArray(0) = source
        Return Filter(sourceArray, match, Include)
    End Function
    Private Function trimStringNumeric(ByVal source As String)
        Dim i As Integer
        Dim result As String = ""
        While i < source.Length
            If IsNumeric(source.Substring(i, 1)) Or source.Substring(i, 1) = "." Or source.Substring(i, 1) = "-" Then
                result = result + source.Substring(i, 1)
            End If
            i = i + 1
        End While
        Return result
    End Function
    Private Function getHTMLcontent(ByVal startBlock, ByVal endBlock, ByVal source, ByVal startingPosition)
        If InStr(source, startBlock) Then
            If InStr(source, endBlock) Then
                Dim i = InStr(startingPosition, source, startBlock)
                Dim j = InStr(i, source, endBlock)
                i = i + Len(startBlock) - 1
                Try
                    startPos_temp = i
                    Return source.Substring(i, j - i - 1)
                Catch e As Exception
                End Try
            End If
        End If
        Return ""
    End Function
    Private Function getBuildingInProgress(ByVal source)
        Dim temp = getHTMLcontent("<h3>Gebäude</h3>", "</table>", source, 1)
        If InStr(temp, "class=""idle""") Then
            Return "-/-"
        Else
            Return getHTMLcontent("<th colspan=""2"">", "</th>", temp, 1)
        End If
        Return ""
    End Function
    Private Function getScienceInProgress(ByVal source)
        Dim temp = getHTMLcontent("<h3>Forschung</h3>", "</table>", source, 1)
        If InStr(temp, "class=""idle""") Then
            Return "-/-"
        Else
            Return getHTMLcontent("<th colspan=""2"">", "</th>", temp, 1)
        End If
        Return ""
    End Function
    Private Function getConstructionInProgress(ByVal source)
        Dim temp = getHTMLcontent("<h3>Schiffswerft</h3>", "</table>", source, 1)
        If InStr(temp, "class=""idle""") Then
            Return "-/-"
        Else
            Return getHTMLcontent("<th colspan=""2"">", "</th>", temp, 1)
        End If
        Return ""
    End Function
    Private Sub getBuildingLevels()
        Dim source = httpGET("http://uni113.ogame.de/game/index.php?page=resources")
        'Metallmine:
        Dim temp = getHTMLcontent("<div id=""buttonz"">", "<!-- END CONTENT AREA -->", source, 1)
        MetallLevelText.Text = trimStringNumeric(getHTMLcontent("<span class=""textlabel"">", "</a>", getHTMLcontent("<li id=""button1""", "</li>", temp, 1), 1))
        'Kristallmine:
        KristallLevelText.Text = trimStringNumeric(getHTMLcontent("<span class=""textlabel"">", "</a>", getHTMLcontent("<li id=""button2""", "</li>", temp, 1), 1))
        'Deuteriumsynthetisierer:
        DeuteriumLevelText.Text = trimStringNumeric(getHTMLcontent("</span>", "</a>", getHTMLcontent("<li id=""button3""", "</li>", temp, 1), 1))
        'Solarkraftwerk:
        SolarkraftwerkLevelText.Text = trimStringNumeric(getHTMLcontent("<span class=""textlabel"">", "</a>", getHTMLcontent("<li id=""button4""", "</li>", temp, 1), 1))

        source = httpGET("http://uni113.ogame.de/game/index.php?page=station")
        temp = getHTMLcontent("<div id=""buttonz"">", "<!-- END CONTENT AREA -->", source, 1)
        My.Computer.FileSystem.WriteAllText("C:\Users\Alle\Desktop\testtt.txt", source, False)
        'Roboterfabrik:
        RoboterfabrikLevelText.Text = trimStringNumeric(getHTMLcontent("<span class=""textlabel"">", "</a>", getHTMLcontent("<li id=""button0""", "</li>", temp, 1), 1))
        'Raumschiffwerft:
        RaumschiffwerftLevelText.Text = trimStringNumeric(getHTMLcontent("<span class=""textlabel"">", "</a>", getHTMLcontent("<li id=""button1""", "</li>", temp, 1), 1))
    End Sub
End Class