﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeoIP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GeoIP))
        Me.GeoIPWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'GeoIPWebBrowser
        '
        Me.GeoIPWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeoIPWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.GeoIPWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.GeoIPWebBrowser.Name = "GeoIPWebBrowser"
        Me.GeoIPWebBrowser.ScriptErrorsSuppressed = True
        Me.GeoIPWebBrowser.ScrollBarsEnabled = False
        Me.GeoIPWebBrowser.Size = New System.Drawing.Size(584, 361)
        Me.GeoIPWebBrowser.TabIndex = 0
        '
        'GeoIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.GeoIPWebBrowser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GeoIP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GeoIPWebBrowser As System.Windows.Forms.WebBrowser
End Class
