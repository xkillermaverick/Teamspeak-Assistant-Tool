﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamspeakHalo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTeamspeakHalo))
        Me.webYoutube = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'webYoutube
        '
        Me.webYoutube.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webYoutube.Location = New System.Drawing.Point(0, 0)
        Me.webYoutube.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webYoutube.Name = "webYoutube"
        Me.webYoutube.Size = New System.Drawing.Size(573, 441)
        Me.webYoutube.TabIndex = 0
        Me.webYoutube.Url = New System.Uri("https://www.youtube.com/watch?v=87JPlNk5ves&list=PL0S-Da7zGmE9PRn_YIitvUZEHYQglJw" &
        "uJ", System.UriKind.Absolute)
        '
        'frmTeamspeakHalo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 441)
        Me.Controls.Add(Me.webYoutube)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTeamspeakHalo"
        Me.Text = "xKiller Teamspeak Assistant Tool - Easter Egg #3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webYoutube As WebBrowser
End Class
