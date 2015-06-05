Public Class PingWebsite

    Dim strWebsite As String

    Private Sub GetIPAddress(strSiteName As String)

        Dim strIpAddress As String

        strIpAddress = System.Net.Dns.GetHostEntry(strSiteName).AddressList(0).ToString()

        txtIP.Visible = True
        txtIP.Text = strIpAddress

        MessageBox.Show("IP Address: " & strIpAddress)

    End Sub

    Private Sub btnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click

        GetIPAddress(txtWebsiteAddress.Text)

    End Sub

End Class
