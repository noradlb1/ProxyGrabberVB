Imports System.Net

Namespace ProxyGrabber.Classes
	Friend Class webAPI
		Private Client As New WebClient()
		Private timeout As String
		Private proxytype As String
		Private country As String
		Private anonymity As String
		Private ssl As String

		Public Sub New(Optional ByVal timeout As String = "10000", Optional ByVal proxytype As String = "all", Optional ByVal country As String = "all", Optional ByVal anonymity As String = "all", Optional ByVal ssl As String = "all")
			setParameters(timeout, proxytype, country, anonymity, ssl)
		End Sub

		Public Sub setParameters(ByVal timeout As String, ByVal proxytype As String, ByVal country As String, ByVal anonymity As String, ByVal ssl As String)
			setTimeout(timeout)
			setProxyType(proxytype)
			setCountry(country)
			setAnonymity(anonymity)
			setSSL(ssl)
		End Sub

		Public Sub setTimeout(ByVal timeout As String)
			Me.timeout = timeout
		End Sub

		Public Sub setProxyType(ByVal proxytype As String)
			Me.proxytype = proxytype
		End Sub

		Public Sub setCountry(ByVal country As String)
			Me.country = country
		End Sub

		Public Sub setAnonymity(ByVal anonymity As String)
			Me.anonymity = anonymity
		End Sub

		Public Sub setSSL(ByVal ssl As String)
			Me.ssl = ssl
		End Sub

		Public Function lastUpdated() As String
			If proxytype = "all" Then
				Return "Select Proxy Type"
			Else
				Return Client.DownloadString($"https://api.proxyscrape.com/?request=lastupdated&proxytype={proxytype}")
			End If
		End Function

		Public Function amountProxies() As String
			Return Client.DownloadString($"https://api.proxyscrape.com/?request=amountproxies&proxytype={proxytype}&timeout={timeout}&country={country}&anonymity={anonymity}&ssl={ssl}")
		End Function

		Public Sub Download(ByVal path As String)
			Client.DownloadFile($"https://api.proxyscrape.com?request=getproxies&proxytype={proxytype}&timeout={timeout}&country={country}&anonymity={anonymity}&ssl={ssl}", path)
		End Sub


		Public Sub Dispose()
			Client = Nothing
			timeout = String.Empty
			proxytype = String.Empty
			country = String.Empty
			anonymity = String.Empty
			ssl = String.Empty
		End Sub
	End Class
End Namespace
