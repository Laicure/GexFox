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
		Me.panConts = New System.Windows.Forms.Panel()
		Me.txUrl = New System.Windows.Forms.TextBox()
		Me.lbUA = New System.Windows.Forms.Label()
		Me.butMin = New System.Windows.Forms.Button()
		Me.lbBack = New System.Windows.Forms.Label()
		Me.lbReload = New System.Windows.Forms.Label()
		Me.lbForward = New System.Windows.Forms.Label()
		Me.tbOpac = New System.Windows.Forms.TrackBar()
		Me.lbLoad = New System.Windows.Forms.Label()
		Me.tipper = New System.Windows.Forms.ToolTip(Me.components)
		Me.notIGexed = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.panConts.SuspendLayout()
		CType(Me.tbOpac, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'panGex
		'
		Me.panGex.Dock = System.Windows.Forms.DockStyle.Fill
		Me.panGex.Location = New System.Drawing.Point(1, 23)
		Me.panGex.Name = "panGex"
		Me.panGex.Size = New System.Drawing.Size(332, 312)
		Me.panGex.TabIndex = 0
		Me.panGex.Visible = False
		'
		'panConts
		'
		Me.panConts.Controls.Add(Me.txUrl)
		Me.panConts.Controls.Add(Me.lbUA)
		Me.panConts.Controls.Add(Me.butMin)
		Me.panConts.Controls.Add(Me.lbBack)
		Me.panConts.Controls.Add(Me.lbReload)
		Me.panConts.Controls.Add(Me.lbForward)
		Me.panConts.Controls.Add(Me.tbOpac)
		Me.panConts.Dock = System.Windows.Forms.DockStyle.Top
		Me.panConts.Location = New System.Drawing.Point(1, 1)
		Me.panConts.Name = "panConts"
		Me.panConts.Size = New System.Drawing.Size(332, 22)
		Me.panConts.TabIndex = 1
		'
		'txUrl
		'
		Me.txUrl.BackColor = System.Drawing.Color.White
		Me.txUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txUrl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txUrl.ForeColor = System.Drawing.Color.Black
		Me.txUrl.Location = New System.Drawing.Point(0, 0)
		Me.txUrl.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
		Me.txUrl.Name = "txUrl"
		Me.txUrl.Size = New System.Drawing.Size(194, 22)
		Me.txUrl.TabIndex = 0
		Me.txUrl.TabStop = False
		'
		'lbUA
		'
		Me.lbUA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbUA.Dock = System.Windows.Forms.DockStyle.Right
		Me.lbUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbUA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbUA.Location = New System.Drawing.Point(194, 0)
		Me.lbUA.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lbUA.Name = "lbUA"
		Me.lbUA.Size = New System.Drawing.Size(22, 22)
		Me.lbUA.TabIndex = 5
		Me.lbUA.Text = "M"
		Me.lbUA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbUA, "M = Mobile" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D = Desktop")
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
		Me.lbBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbBack.Location = New System.Drawing.Point(216, 0)
		Me.lbBack.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lbBack.Name = "lbBack"
		Me.lbBack.Size = New System.Drawing.Size(22, 22)
		Me.lbBack.TabIndex = 4
		Me.lbBack.Text = "B"
		Me.lbBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbBack, "Back")
		'
		'lbReload
		'
		Me.lbReload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbReload.Dock = System.Windows.Forms.DockStyle.Right
		Me.lbReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbReload.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbReload.Location = New System.Drawing.Point(238, 0)
		Me.lbReload.Name = "lbReload"
		Me.lbReload.Size = New System.Drawing.Size(22, 22)
		Me.lbReload.TabIndex = 3
		Me.lbReload.Text = "R"
		Me.lbReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbReload, "Reload")
		'
		'lbForward
		'
		Me.lbForward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbForward.Dock = System.Windows.Forms.DockStyle.Right
		Me.lbForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbForward.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbForward.Location = New System.Drawing.Point(260, 0)
		Me.lbForward.Name = "lbForward"
		Me.lbForward.Size = New System.Drawing.Size(22, 22)
		Me.lbForward.TabIndex = 2
		Me.lbForward.Text = "F"
		Me.lbForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tipper.SetToolTip(Me.lbForward, "Forward")
		'
		'tbOpac
		'
		Me.tbOpac.BackColor = System.Drawing.Color.White
		Me.tbOpac.Dock = System.Windows.Forms.DockStyle.Right
		Me.tbOpac.Location = New System.Drawing.Point(282, 0)
		Me.tbOpac.Maximum = 100
		Me.tbOpac.Minimum = 7
		Me.tbOpac.Name = "tbOpac"
		Me.tbOpac.Size = New System.Drawing.Size(50, 22)
		Me.tbOpac.TabIndex = 1
		Me.tbOpac.TabStop = False
		Me.tbOpac.TickFrequency = 2
		Me.tbOpac.TickStyle = System.Windows.Forms.TickStyle.None
		Me.tipper.SetToolTip(Me.tbOpac, "Opacity: 100%")
		Me.tbOpac.Value = 100
		'
		'lbLoad
		'
		Me.lbLoad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lbLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lbLoad.Font = New System.Drawing.Font("Gabriola", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbLoad.Location = New System.Drawing.Point(11, 36)
		Me.lbLoad.Margin = New System.Windows.Forms.Padding(10)
		Me.lbLoad.Name = "lbLoad"
		Me.lbLoad.Size = New System.Drawing.Size(312, 289)
		Me.lbLoad.TabIndex = 0
		Me.lbLoad.Text = "Loading..."
		Me.lbLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tipper
		'
		Me.tipper.AutoPopDelay = 5000
		Me.tipper.BackColor = System.Drawing.Color.White
		Me.tipper.ForeColor = System.Drawing.Color.Black
		Me.tipper.InitialDelay = 143
		Me.tipper.ReshowDelay = 100
		Me.tipper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.tipper.ToolTipTitle = "Gex"
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
		Me.ClientSize = New System.Drawing.Size(334, 336)
		Me.Controls.Add(Me.lbLoad)
		Me.Controls.Add(Me.panGex)
		Me.Controls.Add(Me.panConts)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
		Me.ForeColor = System.Drawing.Color.Black
		Me.MaximizeBox = False
		Me.MinimumSize = New System.Drawing.Size(350, 375)
		Me.Name = "MainX"
		Me.Padding = New System.Windows.Forms.Padding(1)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Gexed!"
		Me.panConts.ResumeLayout(False)
		Me.panConts.PerformLayout()
		CType(Me.tbOpac, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents panGex As System.Windows.Forms.Panel
	Friend WithEvents panConts As System.Windows.Forms.Panel
	Friend WithEvents txUrl As System.Windows.Forms.TextBox
	Friend WithEvents tbOpac As System.Windows.Forms.TrackBar
	Friend WithEvents lbLoad As System.Windows.Forms.Label
	Friend WithEvents lbBack As System.Windows.Forms.Label
	Friend WithEvents lbReload As System.Windows.Forms.Label
	Friend WithEvents lbForward As System.Windows.Forms.Label
	Friend WithEvents butMin As System.Windows.Forms.Button
	Friend WithEvents lbUA As System.Windows.Forms.Label
	Friend WithEvents tipper As System.Windows.Forms.ToolTip
	Friend WithEvents notIGexed As System.Windows.Forms.NotifyIcon
End Class
