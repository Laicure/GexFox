Public Class MainX
	Dim GeX As New Gecko.GeckoWebBrowser
	Dim MobileUA As String = "Mozilla/5.0 (Mobile; rv:45.0.31) Gecko/45.0.31 Firefox/45.0.31"
	Dim DesktopUA As String = "Mozilla/5.0 (Windows NT 6.3; rv:45.0.31) Gecko/20100101 Firefox/45.0.31"
	Dim reydi As Boolean = False

	Private Async Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = "GexFox v" & My.Application.Info.Version.ToString
		Me.Icon = My.Resources.meteor 'materialdesignicons.com
		notIGexed.Icon = My.Resources.meteor 'materialdesignicons.com
		notIGexed.Text = "GexFox v" & My.Application.Info.Version.ToString

		Await Task.Delay(1225)

		'init Xpcom
		Gecko.Xpcom.Initialize("Firefox")

		'Event Mapping
		AddHandler GeX.CreateWindow, AddressOf Gex_CreateWindow
		AddHandler GeX.NavigationError, AddressOf Gex_NavigationError
		AddHandler GeX.Navigating, AddressOf Gex_Navigating
		AddHandler GeX.Navigated, AddressOf Gex_Navigated
		AddHandler GeX.DomKeyDown, AddressOf Gex_KeyDown

		'set Geck inits
		Gecko.GeckoPreferences.User("general.useragent.override") = MobileUA
		Gecko.GeckoPreferences.User("zoom.maxPercent") = 100
		Gecko.GeckoPreferences.User("zoom.minPercent") = 100
		Gecko.GeckoPreferences.User("layout.spellcheckDefault") = 2
		Gecko.GeckoPreferences.User("ui.SpellCheckerUnderlineStyle") = 4
		Gecko.GeckoPreferences.User("network.http.pipelining") = True
		Gecko.GeckoPreferences.User("network.prefetch-next") = False
		Gecko.GeckoPreferences.User("dom.max_script_run_time") = 17
		Gecko.GeckoPreferences.User("browser.backspace_action") = 1
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

	Private Sub Gex_Navigated(sender As Object, e As Gecko.GeckoNavigatedEventArgs)
		lbLoad.Visible = False
	End Sub

	Private Sub Gex_Navigating(sender As Object, e As Gecko.Events.GeckoNavigatingEventArgs)
		lbLoad.Visible = True
	End Sub

	Private Sub Gex_NavigationError(sender As Object, e As Gecko.Events.GeckoNavigationErrorEventArgs)
		'GeX.LoadHtml("<html><body bgcolor=""#FFFFFF""><h6>Error: " & e.ErrorCode.ToString & "</h6></body></html>", Nothing)
	End Sub

	'prevent new window/tab
	Private Sub Gex_CreateWindow(sender As Object, e As Gecko.GeckoCreateWindowEventArgs)
		e.Cancel = True
		GeX.Navigate(e.Uri)
		GeX.Focus()
	End Sub

	'Quick Hide
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
		If e.KeyCode = Keys.Enter And Not lbLoad.Visible Then
			Dim newAdd As String = txUrl.Text
			If Not String.IsNullOrWhiteSpace(newAdd) Then
				If newAdd.Trim = "about:config" Then
					GeX.Navigate(newAdd)
				Else
					Dim urx As Uri = Nothing
					Try
						urx = New Uri("http://" & newAdd.Trim)
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
		If lbLoad.Visible Then
			Exit Sub
		End If
		GeX.Reload()
		GeX.Focus()
	End Sub

	Private Sub lbBack_Click(sender As Object, e As EventArgs) Handles lbBack.Click
		If lbLoad.Visible Then
			Exit Sub
		End If
		GeX.GoBack()
		GeX.Focus()
	End Sub

	Private Sub lbForward_Click(sender As Object, e As EventArgs) Handles lbForward.Click
		If lbLoad.Visible Then
			Exit Sub
		End If
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
		If lbLoad.Visible Then
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

	Private Sub lbLoad_VisibleChanged(sender As Object, e As EventArgs) Handles lbLoad.VisibleChanged
		panGex.Visible = Not lbLoad.Visible
		If panGex.Visible Then
			GeX.Focus()
		End If
	End Sub

End Class
