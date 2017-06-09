<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainX
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.panGex = New System.Windows.Forms.Panel()
		Me.LbStatusText = New System.Windows.Forms.Label()
		Me.panConts = New System.Windows.Forms.Panel()
		Me.txUrl = New System.Windows.Forms.TextBox()
		Me.lbHome = New System.Windows.Forms.Label()
		Me.pbLoad = New System.Windows.Forms.PictureBox()
		Me.lbUA = New System.Windows.Forms.Label()
		Me.butMin = New System.Windows.Forms.Button()
		Me.lbBack = New System.Windows.Forms.Label()
		Me.lbForward = New System.Windows.Forms.Label()
		Me.lbReload = New System.Windows.Forms.Label()
		Me.tbOpac = New System.Windows.Forms.TrackBar()
		Me.tipper = New System.Windows.Forms.ToolTip(Me.components)
		Me.notIGexed = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.panGex.SuspendLayout()
		Me.panConts.SuspendLayout()
		CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tbOpac, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'panGex
		'
		Me.panGex.Controls.Add(Me.LbStatusText)
		Me.panGex.Dock = System.Windows.Forms.DockStyle.Fill
		Me.panGex.Location = New System.Drawing.Point(0, 22)
		Me.panGex.Name = "panGex"
		Me.panGex.Size = New System.Drawing.Size(334, 189)
		Me.panGex.TabIndex = 0
		'
		'LbStatusText
		'
		Me.LbStatusText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LbStatusText.AutoEllipsis = True
		Me.LbStatusText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LbStatusText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LbStatusText.ForeColor = System.Drawing.Color.Red
		Me.LbStatusText.Location = New System.Drawing.Point(0, 174)
		Me.LbStatusText.Name = "LbStatusText"
		Me.LbStatusText.Size = New System.Drawing.Size(334, 15)
		Me.LbStatusText.TabIndex = 0
		Me.LbStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.LbStatusText.Visible = False
		'
		'panConts
		'
		Me.panConts.Controls.Add(Me.txUrl)
		Me.panConts.Controls.Add(Me.lbHome)
		Me.panConts.Controls.Add(Me.pbLoad)
		Me.panConts.Controls.Add(Me.lbUA)
		Me.panConts.Controls.Add(Me.butMin)
		Me.panConts.Controls.Add(Me.lbBack)
		Me.panConts.Controls.Add(Me.lbForward)
		Me.panConts.Controls.Add(Me.lbReload)
		Me.panConts.Controls.Add(Me.tbOpac)
		Me.panConts.Dock = System.Windows.Forms.DockStyle.Top
		Me.panConts.Location = New System.Drawing.Point(0, 0)
		Me.panConts.Name = "panConts"
		Me.panConts.Size = New System.Drawing.Size(334, 22)
		Me.panConts.TabIndex = 1
		'
		'txUrl
		'
		Me.txUrl.BackColor = System.Drawing.Color.White
		Me.txUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txUrl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txUrl.ForeColor = System.Drawing.Color.Black
		Me.txUrl.Location = New System.Drawing.Point(22, 0)
		Me.txUrl.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
		Me.txUrl.Name = "txUrl"
		Me.txUrl.Size = New System.Drawing.Size(142, 22)
		Me.txUrl.TabIndex = 0
		Me.txUrl.TabStop = False
		Me.tipper.SetToolTip(Me.txUrl, "(Select All Text and Focus: ctrl+`)")
		'
		'lbHome
		'
		Me.lbHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbHome.Dock = System.Windows.Forms.DockStyle.Right
		Me.lbHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbHome.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbHome.Location = New System.Drawing.Point(164, 0)
		Me.lbHome.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lbHome.Name = "lbHome"
		Me.lbHome.Size = New System.Drawing.Size(22, 22)
		Me.lbHome.TabIndex = 6
		Me.lbHome.Text = "🏠"
		Me.lbHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbHome, "Home (shrib.com); resets opacity to 100%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Key: ctrl+<tab>)")
		'
		'pbLoad
		'
		Me.pbLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbLoad.Dock = System.Windows.Forms.DockStyle.Left
		Me.pbLoad.Location = New System.Drawing.Point(0, 0)
		Me.pbLoad.Margin = New System.Windows.Forms.Padding(10)
		Me.pbLoad.Name = "pbLoad"
		Me.pbLoad.Size = New System.Drawing.Size(22, 22)
		Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbLoad.TabIndex = 0
		Me.pbLoad.TabStop = False
		Me.tipper.SetToolTip(Me.pbLoad, "Navigating...")
		Me.pbLoad.WaitOnLoad = True
		'
		'lbUA
		'
		Me.lbUA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbUA.Dock = System.Windows.Forms.DockStyle.Right
		Me.lbUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbUA.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbUA.Location = New System.Drawing.Point(186, 0)
		Me.lbUA.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lbUA.Name = "lbUA"
		Me.lbUA.Size = New System.Drawing.Size(22, 22)
		Me.lbUA.TabIndex = 5
		Me.lbUA.Text = "📱"
		Me.lbUA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbUA, "📱 = Mobile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "🖳 = Desktop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Toggle: ctrl+1)")
		'
		'butMin
		'
		Me.butMin.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.butMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.butMin.Location = New System.Drawing.Point(-130, 1)
		Me.butMin.Name = "butMin"
		Me.butMin.Size = New System.Drawing.Size(123, 25)
		Me.butMin.TabIndex = 2
		Me.butMin.TabStop = False
		Me.butMin.Text = "Emergency Minimize"
		Me.butMin.UseVisualStyleBackColor = True
		'
		'lbBack
		'
		Me.lbBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbBack.Dock = System.Windows.Forms.DockStyle.Right
		Me.lbBack.Enabled = False
		Me.lbBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbBack.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbBack.Location = New System.Drawing.Point(208, 0)
		Me.lbBack.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lbBack.Name = "lbBack"
		Me.lbBack.Size = New System.Drawing.Size(22, 22)
		Me.lbBack.TabIndex = 4
		Me.lbBack.Text = "◁"
		Me.lbBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbBack, "Back" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Key: ctrl+2)")
		'
		'lbForward
		'
		Me.lbForward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbForward.Dock = System.Windows.Forms.DockStyle.Right
		Me.lbForward.Enabled = False
		Me.lbForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbForward.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbForward.Location = New System.Drawing.Point(230, 0)
		Me.lbForward.Name = "lbForward"
		Me.lbForward.Size = New System.Drawing.Size(22, 22)
		Me.lbForward.TabIndex = 2
		Me.lbForward.Text = "▷"
		Me.lbForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbForward, "Forward" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Key: ctrl+4)")
		'
		'lbReload
		'
		Me.lbReload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbReload.Dock = System.Windows.Forms.DockStyle.Right
		Me.lbReload.Enabled = False
		Me.lbReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbReload.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbReload.Location = New System.Drawing.Point(252, 0)
		Me.lbReload.Name = "lbReload"
		Me.lbReload.Size = New System.Drawing.Size(22, 22)
		Me.lbReload.TabIndex = 3
		Me.lbReload.Text = "🔄"
		Me.lbReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbReload, "Reload" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Key: ctrl+3)")
		'
		'tbOpac
		'
		Me.tbOpac.BackColor = System.Drawing.Color.White
		Me.tbOpac.Dock = System.Windows.Forms.DockStyle.Right
		Me.tbOpac.Location = New System.Drawing.Point(274, 0)
		Me.tbOpac.Maximum = 100
		Me.tbOpac.Minimum = 7
		Me.tbOpac.Name = "tbOpac"
		Me.tbOpac.Size = New System.Drawing.Size(60, 22)
		Me.tbOpac.TabIndex = 1
		Me.tbOpac.TabStop = False
		Me.tbOpac.TickFrequency = 2
		Me.tbOpac.TickStyle = System.Windows.Forms.TickStyle.None
		Me.tipper.SetToolTip(Me.tbOpac, "Opacity: 100%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(-1%: ctrl+5)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(+1%: ctrl+6)")
		Me.tbOpac.Value = 100
		'
		'tipper
		'
		Me.tipper.AutoPopDelay = 5000
		Me.tipper.BackColor = System.Drawing.Color.White
		Me.tipper.ForeColor = System.Drawing.Color.Black
		Me.tipper.InitialDelay = 143
		Me.tipper.ReshowDelay = 100
		Me.tipper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.tipper.ToolTipTitle = "GexFox"
		Me.tipper.UseAnimation = False
		Me.tipper.UseFading = False
		'
		'notIGexed
		'
		Me.notIGexed.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.notIGexed.BalloonTipText = "Stealth mode!"
		Me.notIGexed.BalloonTipTitle = "Gex"
		'
		'MainX
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.CancelButton = Me.butMin
		Me.ClientSize = New System.Drawing.Size(334, 211)
		Me.Controls.Add(Me.panGex)
		Me.Controls.Add(Me.panConts)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
		Me.ForeColor = System.Drawing.Color.Black
		Me.MinimumSize = New System.Drawing.Size(350, 250)
		Me.Name = "MainX"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Gexed!"
		Me.panGex.ResumeLayout(False)
		Me.panConts.ResumeLayout(False)
		Me.panConts.PerformLayout()
		CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tbOpac, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents panGex As System.Windows.Forms.Panel
	Friend WithEvents panConts As System.Windows.Forms.Panel
	Friend WithEvents txUrl As System.Windows.Forms.TextBox
	Friend WithEvents tbOpac As System.Windows.Forms.TrackBar
	Friend WithEvents lbBack As System.Windows.Forms.Label
	Friend WithEvents lbReload As System.Windows.Forms.Label
	Friend WithEvents lbForward As System.Windows.Forms.Label
	Friend WithEvents butMin As System.Windows.Forms.Button
	Friend WithEvents lbUA As System.Windows.Forms.Label
	Friend WithEvents tipper As System.Windows.Forms.ToolTip
	Friend WithEvents notIGexed As System.Windows.Forms.NotifyIcon
	Friend WithEvents pbLoad As System.Windows.Forms.PictureBox
	Friend WithEvents lbHome As System.Windows.Forms.Label
	Friend WithEvents LbStatusText As System.Windows.Forms.Label
End Class
