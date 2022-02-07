Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Diagnostics
Imports ProxyGrabber.Classes

Namespace ProxyGrabber
	Partial Public Class MainForm
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private timeout As String
		Private proxytype As String
		Private country As String
		Private anonymity As String
		Private ssl As String
		Private API As New webAPI()
		Private InfoDialog As New Information()
		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			TimeoutLbl.Text = "Timeout: " & Convert.ToString(TimeoutTbar.Value) & "ms"

			TypeCmBox.SelectedIndex = 0
			CountryCmBox.SelectedIndex = 0
			AnonymityCmBox.SelectedIndex = 0
			SSLCmBox.SelectedIndex = 0

			AmountLbl.Text = "Amount: " & API.amountProxies()
		End Sub

		Private Sub TimeoutTbar_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles TimeoutTbar.Scroll
			timeout = Convert.ToString(TimeoutTbar.Value)
			TimeoutLbl.Text = "Timeout: " & timeout & "ms"
		End Sub

		Private Sub TimeoutTbar_MouseCaptureChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TimeoutTbar.MouseCaptureChanged
			API.setTimeout(timeout)
			AmountLbl.Text = "Amount: " & API.amountProxies()
		End Sub

		Private Sub TypeCmBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TypeCmBox.SelectedIndexChanged
			proxytype = Convert.ToString(TypeCmBox.SelectedItem)
			If proxytype = "socks4" OrElse proxytype = "socks5" Then
				AnonymityCmBox.SelectedIndex = 0
				SSLCmBox.SelectedIndex = 0
				AnonymityCmBox.Enabled = False
				SSLCmBox.Enabled = False
			Else
				AnonymityCmBox.Enabled = True
				SSLCmBox.Enabled = True
			End If
			API.setProxyType(proxytype)
			LastUpdatedLbl.Text = "Last updated: " & API.lastUpdated()
			AmountLbl.Text = "Amount: " & API.amountProxies()
		End Sub

		Private Sub CountryCmBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CountryCmBox.SelectedIndexChanged
			country = Convert.ToString(CountryCmBox.SelectedItem)
			API.setCountry(country)
			AmountLbl.Text = "Amount: " & API.amountProxies()
		End Sub

		Private Sub AnonymityCmBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles AnonymityCmBox.SelectedIndexChanged
			anonymity = Convert.ToString(AnonymityCmBox.SelectedItem)
			API.setAnonymity(anonymity)
			AmountLbl.Text = "Amount: " & API.amountProxies()
		End Sub

		Private Sub SSLCmBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SSLCmBox.SelectedIndexChanged
			ssl = Convert.ToString(SSLCmBox.SelectedItem)
			API.setSSL(ssl)
			AmountLbl.Text = "Amount: " & API.amountProxies()
		End Sub

		Private Sub SaveBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveBtn.Click
			If SaveProxies.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				API.Download(SaveProxies.FileName)
			End If
		End Sub

		Private Sub LogoPicBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogoPicBox.Click
			Process.Start("https://proxyscrape.com/home")
		End Sub

		Private Sub ExitBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitBtn.Click
			API.Dispose()
			API = Nothing
			InfoDialog = Nothing
			GC.Collect()
			Application.Exit()
		End Sub

		Private Sub MiniBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MiniBtn.Click
			Me.WindowState = FormWindowState.Minimized
		End Sub

		Private Sub InfoBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InfoBtn.Click
			InfoDialog.ShowDialog()
		End Sub

		Public Const WM_NCLBUTTONDOWN As Integer = &HA1
		Public Const HT_CAPTION As Integer = &H2
		<DllImportAttribute("user32.dll")> _
		Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		End Function
		<DllImportAttribute("user32.dll")> _
		Public Shared Function ReleaseCapture() As Boolean
		End Function
		Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
			If e.Button = MouseButtons.Left Then
				ReleaseCapture()
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
			End If
		End Sub

        Private Sub SaveProxies_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveProxies.FileOk

        End Sub
    End Class
End Namespace
