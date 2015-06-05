<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PingWebsite
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
        Me.btnPing = New System.Windows.Forms.Button()
        Me.txtWebsiteAddress = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPing
        '
        Me.btnPing.Location = New System.Drawing.Point(107, 89)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(75, 23)
        Me.btnPing.TabIndex = 0
        Me.btnPing.Text = "Ping"
        Me.btnPing.UseVisualStyleBackColor = True
        '
        'txtWebsiteAddress
        '
        Me.txtWebsiteAddress.Location = New System.Drawing.Point(27, 54)
        Me.txtWebsiteAddress.Name = "txtWebsiteAddress"
        Me.txtWebsiteAddress.Size = New System.Drawing.Size(245, 20)
        Me.txtWebsiteAddress.TabIndex = 1
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(27, 152)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(245, 20)
        Me.txtIP.TabIndex = 2
        Me.txtIP.Visible = False
        '
        'PingWebsite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtWebsiteAddress)
        Me.Controls.Add(Me.btnPing)
        Me.Name = "PingWebsite"
        Me.Text = "Ping Website"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPing As System.Windows.Forms.Button
    Friend WithEvents txtWebsiteAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox

End Class
