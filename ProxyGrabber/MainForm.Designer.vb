Namespace ProxyGrabber
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.ExitBtn = New System.Windows.Forms.Button()
            Me.MiniBtn = New System.Windows.Forms.Button()
            Me.SeprLbl = New System.Windows.Forms.Label()
            Me.LastUpdatedLbl = New System.Windows.Forms.Label()
            Me.AmountLbl = New System.Windows.Forms.Label()
            Me.TimeoutLbl = New System.Windows.Forms.Label()
            Me.TimeoutTbar = New System.Windows.Forms.TrackBar()
            Me.CountryCmBox = New System.Windows.Forms.ComboBox()
            Me.AnonymityCmBox = New System.Windows.Forms.ComboBox()
            Me.SSLCmBox = New System.Windows.Forms.ComboBox()
            Me.TypeCmBox = New System.Windows.Forms.ComboBox()
            Me.SaveBtn = New System.Windows.Forms.Button()
            Me.TypeLbl = New System.Windows.Forms.Label()
            Me.CountryLbl = New System.Windows.Forms.Label()
            Me.AnonymityLbl = New System.Windows.Forms.Label()
            Me.SSLLbl = New System.Windows.Forms.Label()
            Me.InfoBtn = New System.Windows.Forms.Button()
            Me.SaveProxies = New System.Windows.Forms.SaveFileDialog()
            Me.DownloadIcoPicBox = New System.Windows.Forms.PictureBox()
            Me.LogoPicBox = New System.Windows.Forms.PictureBox()
            CType(Me.TimeoutTbar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DownloadIcoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ExitBtn
            '
            Me.ExitBtn.BackColor = System.Drawing.SystemColors.Control
            Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
            Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ExitBtn.Location = New System.Drawing.Point(271, 2)
            Me.ExitBtn.Name = "ExitBtn"
            Me.ExitBtn.Size = New System.Drawing.Size(24, 25)
            Me.ExitBtn.TabIndex = 0
            Me.ExitBtn.Text = "X"
            Me.ExitBtn.UseVisualStyleBackColor = False
            '
            'MiniBtn
            '
            Me.MiniBtn.BackColor = System.Drawing.SystemColors.Control
            Me.MiniBtn.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.MiniBtn.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MiniBtn.Location = New System.Drawing.Point(245, 2)
            Me.MiniBtn.Name = "MiniBtn"
            Me.MiniBtn.Size = New System.Drawing.Size(24, 25)
            Me.MiniBtn.TabIndex = 1
            Me.MiniBtn.Text = "_"
            Me.MiniBtn.UseVisualStyleBackColor = False
            '
            'SeprLbl
            '
            Me.SeprLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.SeprLbl.Location = New System.Drawing.Point(2, 33)
            Me.SeprLbl.Name = "SeprLbl"
            Me.SeprLbl.Size = New System.Drawing.Size(294, 1)
            Me.SeprLbl.TabIndex = 3
            '
            'LastUpdatedLbl
            '
            Me.LastUpdatedLbl.AutoSize = True
            Me.LastUpdatedLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LastUpdatedLbl.Location = New System.Drawing.Point(12, 192)
            Me.LastUpdatedLbl.Name = "LastUpdatedLbl"
            Me.LastUpdatedLbl.Size = New System.Drawing.Size(98, 19)
            Me.LastUpdatedLbl.TabIndex = 5
            Me.LastUpdatedLbl.Text = "Last updated:"
            '
            'AmountLbl
            '
            Me.AmountLbl.AutoSize = True
            Me.AmountLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AmountLbl.Location = New System.Drawing.Point(12, 219)
            Me.AmountLbl.Name = "AmountLbl"
            Me.AmountLbl.Size = New System.Drawing.Size(65, 19)
            Me.AmountLbl.TabIndex = 7
            Me.AmountLbl.Text = "Amount:"
            '
            'TimeoutLbl
            '
            Me.TimeoutLbl.AutoSize = True
            Me.TimeoutLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TimeoutLbl.Location = New System.Drawing.Point(79, 256)
            Me.TimeoutLbl.Name = "TimeoutLbl"
            Me.TimeoutLbl.Size = New System.Drawing.Size(71, 19)
            Me.TimeoutLbl.TabIndex = 9
            Me.TimeoutLbl.Text = "Timeout: "
            '
            'TimeoutTbar
            '
            Me.TimeoutTbar.LargeChange = 50
            Me.TimeoutTbar.Location = New System.Drawing.Point(12, 278)
            Me.TimeoutTbar.Maximum = 10000
            Me.TimeoutTbar.Minimum = 50
            Me.TimeoutTbar.Name = "TimeoutTbar"
            Me.TimeoutTbar.Size = New System.Drawing.Size(273, 45)
            Me.TimeoutTbar.SmallChange = 50
            Me.TimeoutTbar.TabIndex = 50
            Me.TimeoutTbar.TickFrequency = 50
            Me.TimeoutTbar.TickStyle = System.Windows.Forms.TickStyle.None
            Me.TimeoutTbar.Value = 10000
            '
            'CountryCmBox
            '
            Me.CountryCmBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CountryCmBox.DropDownHeight = 123
            Me.CountryCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CountryCmBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CountryCmBox.FormattingEnabled = True
            Me.CountryCmBox.IntegralHeight = False
            Me.CountryCmBox.ItemHeight = 19
            Me.CountryCmBox.Items.AddRange(New Object() {"all", "AL", "AM", "AR", "AU", "BD", "BG", "BR", "CA", "CD", "CL", "CN", "CO", "CZ", "DE", "EC", "ES", "FR", "GB", "GE", "GR", "HK", "HU", "ID", "IN", "IQ", "IR", "IT", "KE", "KH", "KR", "KZ", "LB", "LT", "MD", "MK", "MN", "MV", "MW", "MX", "MY", "NG", "NL", "NP", "NZ", "PE", "PH", "PK", "PL", "PS", "RO", "RS", "RU", "SC", "SK", "TH", "TR", "TW", "UA", "US", "UY", "VE", "VN", "ZA"})
            Me.CountryCmBox.Location = New System.Drawing.Point(105, 347)
            Me.CountryCmBox.Name = "CountryCmBox"
            Me.CountryCmBox.Size = New System.Drawing.Size(173, 27)
            Me.CountryCmBox.TabIndex = 51
            '
            'AnonymityCmBox
            '
            Me.AnonymityCmBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.AnonymityCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.AnonymityCmBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AnonymityCmBox.FormattingEnabled = True
            Me.AnonymityCmBox.Items.AddRange(New Object() {"all", "elite", "anonymous", "transparent"})
            Me.AnonymityCmBox.Location = New System.Drawing.Point(105, 383)
            Me.AnonymityCmBox.Name = "AnonymityCmBox"
            Me.AnonymityCmBox.Size = New System.Drawing.Size(173, 27)
            Me.AnonymityCmBox.TabIndex = 52
            '
            'SSLCmBox
            '
            Me.SSLCmBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.SSLCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.SSLCmBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SSLCmBox.FormattingEnabled = True
            Me.SSLCmBox.Items.AddRange(New Object() {"all", "yes", "no"})
            Me.SSLCmBox.Location = New System.Drawing.Point(105, 419)
            Me.SSLCmBox.Name = "SSLCmBox"
            Me.SSLCmBox.Size = New System.Drawing.Size(173, 27)
            Me.SSLCmBox.TabIndex = 53
            '
            'TypeCmBox
            '
            Me.TypeCmBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.TypeCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.TypeCmBox.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TypeCmBox.FormattingEnabled = True
            Me.TypeCmBox.Items.AddRange(New Object() {"all", "http", "socks4", "socks5"})
            Me.TypeCmBox.Location = New System.Drawing.Point(105, 311)
            Me.TypeCmBox.Name = "TypeCmBox"
            Me.TypeCmBox.Size = New System.Drawing.Size(173, 27)
            Me.TypeCmBox.TabIndex = 54
            Me.TypeCmBox.Tag = ""
            '
            'SaveBtn
            '
            Me.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand
            Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SaveBtn.Location = New System.Drawing.Point(82, 463)
            Me.SaveBtn.Name = "SaveBtn"
            Me.SaveBtn.Size = New System.Drawing.Size(134, 47)
            Me.SaveBtn.TabIndex = 55
            Me.SaveBtn.Text = "Save"
            Me.SaveBtn.UseVisualStyleBackColor = True
            '
            'TypeLbl
            '
            Me.TypeLbl.AutoSize = True
            Me.TypeLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TypeLbl.Location = New System.Drawing.Point(12, 314)
            Me.TypeLbl.Name = "TypeLbl"
            Me.TypeLbl.Size = New System.Drawing.Size(48, 19)
            Me.TypeLbl.TabIndex = 56
            Me.TypeLbl.Text = "Type: "
            '
            'CountryLbl
            '
            Me.CountryLbl.AutoSize = True
            Me.CountryLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CountryLbl.Location = New System.Drawing.Point(12, 350)
            Me.CountryLbl.Name = "CountryLbl"
            Me.CountryLbl.Size = New System.Drawing.Size(67, 19)
            Me.CountryLbl.TabIndex = 57
            Me.CountryLbl.Text = "Country: "
            '
            'AnonymityLbl
            '
            Me.AnonymityLbl.AutoSize = True
            Me.AnonymityLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AnonymityLbl.Location = New System.Drawing.Point(12, 386)
            Me.AnonymityLbl.Name = "AnonymityLbl"
            Me.AnonymityLbl.Size = New System.Drawing.Size(87, 19)
            Me.AnonymityLbl.TabIndex = 58
            Me.AnonymityLbl.Text = "Anonymity: "
            '
            'SSLLbl
            '
            Me.SSLLbl.AutoSize = True
            Me.SSLLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SSLLbl.Location = New System.Drawing.Point(12, 422)
            Me.SSLLbl.Name = "SSLLbl"
            Me.SSLLbl.Size = New System.Drawing.Size(39, 19)
            Me.SSLLbl.TabIndex = 59
            Me.SSLLbl.Text = "SSL: "
            '
            'InfoBtn
            '
            Me.InfoBtn.BackColor = System.Drawing.SystemColors.Control
            Me.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand
            Me.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.InfoBtn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.InfoBtn.Location = New System.Drawing.Point(219, 2)
            Me.InfoBtn.Name = "InfoBtn"
            Me.InfoBtn.Size = New System.Drawing.Size(24, 25)
            Me.InfoBtn.TabIndex = 60
            Me.InfoBtn.Text = "?"
            Me.InfoBtn.UseVisualStyleBackColor = False
            '
            'SaveProxies
            '
            Me.SaveProxies.DefaultExt = "txt"
            Me.SaveProxies.FileName = "MyProxies"
            Me.SaveProxies.Filter = "Text files (*.txt)|*.txt"
            '
            'DownloadIcoPicBox
            '
            Me.DownloadIcoPicBox.Image = Global.My.Resources.Resources.DownloadIcon
            Me.DownloadIcoPicBox.Location = New System.Drawing.Point(77, 50)
            Me.DownloadIcoPicBox.Name = "DownloadIcoPicBox"
            Me.DownloadIcoPicBox.Size = New System.Drawing.Size(139, 133)
            Me.DownloadIcoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.DownloadIcoPicBox.TabIndex = 4
            Me.DownloadIcoPicBox.TabStop = False
            '
            'LogoPicBox
            '
            Me.LogoPicBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.LogoPicBox.Image = Global.My.Resources.Resources.ProxyLogo
            Me.LogoPicBox.Location = New System.Drawing.Point(3, 3)
            Me.LogoPicBox.Name = "LogoPicBox"
            Me.LogoPicBox.Size = New System.Drawing.Size(169, 25)
            Me.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.LogoPicBox.TabIndex = 2
            Me.LogoPicBox.TabStop = False
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(297, 522)
            Me.ControlBox = False
            Me.Controls.Add(Me.InfoBtn)
            Me.Controls.Add(Me.SSLLbl)
            Me.Controls.Add(Me.AnonymityLbl)
            Me.Controls.Add(Me.CountryLbl)
            Me.Controls.Add(Me.TypeLbl)
            Me.Controls.Add(Me.SaveBtn)
            Me.Controls.Add(Me.TypeCmBox)
            Me.Controls.Add(Me.SSLCmBox)
            Me.Controls.Add(Me.AnonymityCmBox)
            Me.Controls.Add(Me.CountryCmBox)
            Me.Controls.Add(Me.TimeoutTbar)
            Me.Controls.Add(Me.TimeoutLbl)
            Me.Controls.Add(Me.AmountLbl)
            Me.Controls.Add(Me.LastUpdatedLbl)
            Me.Controls.Add(Me.DownloadIcoPicBox)
            Me.Controls.Add(Me.SeprLbl)
            Me.Controls.Add(Me.LogoPicBox)
            Me.Controls.Add(Me.MiniBtn)
            Me.Controls.Add(Me.ExitBtn)
            Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            CType(Me.TimeoutTbar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DownloadIcoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents ExitBtn As System.Windows.Forms.Button
		Private WithEvents MiniBtn As System.Windows.Forms.Button
		Private WithEvents LogoPicBox As System.Windows.Forms.PictureBox
		Private SeprLbl As System.Windows.Forms.Label
		Private DownloadIcoPicBox As System.Windows.Forms.PictureBox
		Private LastUpdatedLbl As System.Windows.Forms.Label
		Private AmountLbl As System.Windows.Forms.Label
		Private TimeoutLbl As System.Windows.Forms.Label
		Private WithEvents TimeoutTbar As System.Windows.Forms.TrackBar
		Private WithEvents CountryCmBox As System.Windows.Forms.ComboBox
		Private WithEvents AnonymityCmBox As System.Windows.Forms.ComboBox
		Private WithEvents SSLCmBox As System.Windows.Forms.ComboBox
		Private WithEvents TypeCmBox As System.Windows.Forms.ComboBox
		Private WithEvents SaveBtn As System.Windows.Forms.Button
		Private TypeLbl As System.Windows.Forms.Label
		Private CountryLbl As System.Windows.Forms.Label
		Private AnonymityLbl As System.Windows.Forms.Label
		Private SSLLbl As System.Windows.Forms.Label
		Private WithEvents InfoBtn As System.Windows.Forms.Button
		Private SaveProxies As System.Windows.Forms.SaveFileDialog
	End Class
End Namespace

