﻿Public Class MainX
	Dim GeX As New Gecko.GeckoWebBrowser
	Dim MobileUA As String = "Mozilla/5.0 (Mobile; rv:45.0) Gecko/45.0 Firefox/45.0"
	Dim DesktopUA As String = "Mozilla/5.0 (Windows NT 6.3; rv:45.0) Gecko/20100101 Firefox/45.0"
	Dim reydi As Boolean = False

	Private Async Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = "Notepad+" '"GexFox v" & My.Application.Info.Version.ToString
		Me.Icon = My.Resources.note_plus_outline 'materialdesignicons.com

		notIGexed.Icon = My.Resources.note_plus_outline	'materialdesignicons.com
		notIGexed.Text = Me.Text '"GexFox v" & My.Application.Info.Version.ToString
		pbLoad.Image = My.Resources._126

		Await Task.Delay(1225)

		'init Xpcom
		Gecko.Xpcom.Initialize("Firefox")

		'Event Mapping
		AddHandler GeX.CreateWindow, AddressOf Gex_CreateWindow
		AddHandler GeX.Navigating, AddressOf Gex_Navigating
		AddHandler GeX.Navigated, AddressOf Gex_Navigated
		AddHandler GeX.DomKeyDown, AddressOf Gex_KeyDown
		AddHandler GeX.CanGoBackChanged, AddressOf Gex_CanGoBackChanged
		AddHandler GeX.CanGoForwardChanged, AddressOf Gex_CanGoForwardChanged

		'set Geck inits
		Gecko.GeckoPreferences.User("general.useragent.override") = MobileUA
		Gecko.GeckoPreferences.User("zoom.maxPercent") = 100
		Gecko.GeckoPreferences.User("zoom.minPercent") = 20
		Gecko.GeckoPreferences.User("layout.spellcheckDefault") = 2
		Gecko.GeckoPreferences.User("ui.SpellCheckerUnderlineStyle") = 4
		Gecko.GeckoPreferences.User("network.http.pipelining") = True
		Gecko.GeckoPreferences.User("network.prefetch-next") = False
		Gecko.GeckoPreferences.User("dom.max_script_run_time") = 17
		Gecko.GeckoPreferences.User("browser.xul.error_pages.enabled") = False
		Gecko.GeckoPreferences.User("places.history.enabled") = False
		Gecko.GeckoPreferences.User("general.warnOnAboutConfig") = False

		'GeX Settings
		With GeX
			.Dock = DockStyle.Fill
		End With
		'Add to Panel
		panGex.Controls.Add(GeX)

		GeX.LoadHtml("<html><body bgcolor=""#FFFFFF""><h6>Ready!</h6></body></html>", Nothing)

		reydi = True
	End Sub

	Private Sub MainX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		If Not reydi Then
			e.Cancel = True
			Me.Activate()
			Exit Sub
		End If

		Me.Hide()

		GeX.Dispose()
		Gecko.CookieManager.RemoveAll()
		Gecko.Xpcom.Shutdown()

		'delete Geckofx folder
		If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\AppData\Local\Geckofx") Then
			Try
				My.Computer.FileSystem.DeleteDirectory("C:\Users\" & Environment.UserName & "\AppData\Local\Geckofx", FileIO.DeleteDirectoryOption.DeleteAllContents)
			Catch ex As Exception
				Console.WriteLine(Err.Source & ": " & Err.Description)
			End Try
		End If
	End Sub

#Region "Gex Events"

	Private Sub Gex_CanGoBackChanged(sender As Object, e As System.EventArgs)
		lbBack.Enabled = GeX.CanGoBack
	End Sub

	Private Sub Gex_CanGoForwardChanged(sender As Object, e As System.EventArgs)
		lbForward.Enabled = GeX.CanGoForward
	End Sub

	Private Sub Gex_Navigated(sender As Object, e As Gecko.GeckoNavigatedEventArgs)
		Dim hashHistory As New HashSet(Of String)
		For Each entry As Gecko.GeckoHistoryEntry In GeX.History
			hashHistory.Add(entry.Url.ToString)
		Next
		Dim coll As New AutoCompleteStringCollection
		coll.AddRange(hashHistory.ToArray)
		txUrl.AutoCompleteCustomSource = coll

		txUrl.Text = GeX.Url.ToString
		pbLoad.Visible = False
		lbReload.Enabled = True
		GeX.Focus()
	End Sub

	Private Sub Gex_Navigating(sender As Object, e As Gecko.Events.GeckoNavigatingEventArgs)
		pbLoad.Visible = True
		lbReload.Enabled = False
	End Sub

	'prevent new window/tab; user prefs for new window not working
	Private Sub Gex_CreateWindow(sender As Object, e As Gecko.GeckoCreateWindowEventArgs)
		e.Cancel = True
		GeX.Stop()
		GeX.Navigate(e.Uri)
		GeX.Focus()
	End Sub

	'Quick Hide?
	Private Sub Gex_KeyDown(sender As Object, e As Gecko.DomKeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			butMin_Click(sender, Nothing)
		End If
	End Sub

#End Region

#Region "Controls"

	Private Sub tbOpac_Scroll(sender As Object, e As EventArgs) Handles tbOpac.Scroll
		Me.Opacity = tbOpac.Value / 100
		tipper.SetToolTip(tbOpac, "Opacity: " & tbOpac.Value & "%")

		If panGex.Visible Then
			GeX.Focus()
		End If
	End Sub

	Private Sub txUrl_KeyDown(sender As Object, e As KeyEventArgs) Handles txUrl.KeyDown
		If e.KeyCode = Keys.Enter Then
			Dim newAdd As String = txUrl.Text
			If Not String.IsNullOrWhiteSpace(newAdd) Then
				GeX.Stop()
				If newAdd.Trim.StartsWith("about:") Then
					GeX.Navigate(newAdd)
				Else
					Dim urx As Uri = Nothing
					Try
						urx = New Uri(IIf(Not newAdd.Contains("://"), "http://", "").ToString & newAdd.Trim)
					Catch ex As Exception
						urx = Nothing
					End Try

					If Not IsNothing(urx) Then
						GeX.Navigate(urx.DnsSafeHost)
					Else
						GeX.Navigate("https://www.google.com/search?q=" & Replace(newAdd, " ", "+") & "&oq=" & Replace(newAdd, " ", "+"))
					End If
				End If
			End If
		End If
	End Sub

	Private Sub lbReload_Click(sender As Object, e As EventArgs) Handles lbReload.Click
		GeX.Stop()
		GeX.Reload()
		GeX.Focus()
	End Sub

	Private Sub lbBack_Click(sender As Object, e As EventArgs) Handles lbBack.Click
		GeX.Stop()
		GeX.GoBack()
		GeX.Focus()
	End Sub

	Private Sub lbForward_Click(sender As Object, e As EventArgs) Handles lbForward.Click
		GeX.Stop()
		GeX.GoForward()
		GeX.Focus()
	End Sub

	Private Sub butMin_Click(sender As Object, e As EventArgs) Handles butMin.Click
		If Me.Visible Then
			Me.Hide()
			notIGexed.Visible = True
		End If
		'Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub notIGexed_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notIGexed.MouseDoubleClick
		Me.Show()
		notIGexed.Visible = False
		Me.Activate()
	End Sub

	Private Sub lbUA_Click(sender As Object, e As EventArgs) Handles lbUA.Click
		If Not reydi Then
			Exit Sub
		End If

		If lbUA.Text = "M" Then
			Gecko.GeckoPreferences.User("general.useragent.override") = DesktopUA
			lbUA.Text = "D"
		Else
			Gecko.GeckoPreferences.User("general.useragent.override") = MobileUA
			lbUA.Text = "M"
		End If

		lbReload_Click(sender, Nothing)
	End Sub

#End Region

End Class
