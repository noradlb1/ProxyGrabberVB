Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace ProxyGrabber
	Partial Public Class Information
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub TelegramPicBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TelegramPicBox.Click
			Process.Start("https://telegram.me/AmirHossein_Rnj_01")
		End Sub

		Private Sub InstagramPicBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InstagramPicBox.Click
			Process.Start("https://www.instagram.com/ahossein_rnj")
		End Sub

		Private Sub ExitBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitBtn.Click
			Me.Close()
			GC.Collect()
		End Sub

		Public Const WM_NCLBUTTONDOWN As Integer = &HA1
		Public Const HT_CAPTION As Integer = &H2
		<DllImportAttribute("user32.dll")> _
		Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		End Function
		<DllImportAttribute("user32.dll")> _
		Public Shared Function ReleaseCapture() As Boolean
		End Function
		Private Sub Information_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
			If e.Button = MouseButtons.Left Then
				ReleaseCapture()
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
			End If
		End Sub
	End Class
End Namespace
