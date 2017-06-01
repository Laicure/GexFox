Public Class MainX
	Dim GeX As New Gecko.GeckoWebBrowser

	Private Async Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Text = "GexFox v" & My.Application.Info.Version.ToString
		Await Task.Delay(1225)

		'init Xpcom
		Gecko.Xpcom.Initialize("Firefox")

		'set Geck
		Gecko.GeckoPreferences.User("general.useragent.override") = "Mozilla/5.0 (Android 4.4; Mobile; rv:41.0) Gecko/41.0 Firefox/41.0"

		'GeX Settings
		With GeX
			.Dock = DockStyle.Fill
		End With
		'Add to Panel
		panGex.Controls.Add(GeX)

		GeX.Navigate("about:blank")

		lbLoad.Visible = False
	End Sub

	Private Sub MainX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		Me.Hide()
		GeX.Dispose()
		Gecko.CookieManager.RemoveAll()
		Gecko.Xpcom.Shutdown()
	End Sub

#Region "Controls"

	Private Sub tbOpac_Scroll(sender As Object, e As EventArgs) Handles tbOpac.Scroll
		Me.Opacity = tbOpac.Value / 100

		If panGex.Visible Then
			GeX.Focus()
		End If
	End Sub

	Private Sub txUrl_KeyDown(sender As Object, e As KeyEventArgs) Handles txUrl.KeyDown
		If e.KeyCode = Keys.Enter And Not lbLoad.Visible Then
			Dim newAdd As String = txUrl.Text
			If Not String.IsNullOrWhiteSpace(newAdd) Then
				Dim urx As Uri = Nothing
				Try
					urx = New Uri("http://" & newAdd.Trim)
				Catch ex As Exception
					urx = Nothing
				End Try

				lbLoad.Visible = True
				If Not IsNothing(urx) Then
					GeX.Navigate(urx.DnsSafeHost)
				Else
					GeX.Navigate("https://www.google.com/search?q=" & Replace(newAdd, " ", "+") & "&oq=" & Replace(newAdd, " ", "+"))
				End If
				lbLoad.Visible = False
			End If
		End If
	End Sub

	Private Sub lbReload_Click(sender As Object, e As EventArgs) Handles lbReload.Click
		If lbLoad.Visible Then
			Exit Sub
		End If
		lbLoad.Visible = True
		GeX.Reload()
		lbLoad.Visible = False
	End Sub

	Private Sub lbBack_Click(sender As Object, e As EventArgs) Handles lbBack.Click
		If lbLoad.Visible Then
			Exit Sub
		End If
		lbLoad.Visible = True
		GeX.GoBack()
		lbLoad.Visible = False
	End Sub

	Private Sub lbForward_Click(sender As Object, e As EventArgs) Handles lbForward.Click
		If lbLoad.Visible Then
			Exit Sub
		End If
		lbLoad.Visible = True
		GeX.GoForward()
		lbLoad.Visible = False
	End Sub

	Private Sub butMin_Click(sender As Object, e As EventArgs) Handles butMin.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub lbUA_Click(sender As Object, e As EventArgs) Handles lbUA.Click
		If lbLoad.Visible Then
			Exit Sub
		End If

		If lbUA.Text = "M" Then
			Gecko.GeckoPreferences.User("general.useragent.override") = "Mozilla/5.0 (Windows NT 6.3; rv:10.0) Gecko/20100101 Firefox/10.0"
			lbUA.Text = "D"
		Else
			Gecko.GeckoPreferences.User("general.useragent.override") = "Mozilla/5.0 (Android 4.4; Mobile; rv:41.0) Gecko/41.0 Firefox/41.0"
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
