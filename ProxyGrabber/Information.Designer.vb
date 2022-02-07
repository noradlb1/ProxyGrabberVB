Namespace ProxyGrabber
	Partial Public Class Information
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Information))
			Me.NameLbl = New System.Windows.Forms.Label()
			Me.ExitBtn = New System.Windows.Forms.Button()
			Me.SeprLbl = New System.Windows.Forms.Label()
			Me.VerLbl = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.InstagramPicBox = New System.Windows.Forms.PictureBox()
			Me.TelegramPicBox = New System.Windows.Forms.PictureBox()
			DirectCast(Me.InstagramPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.TelegramPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' NameLbl
			' 
			Me.NameLbl.AutoSize = True
			Me.NameLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.NameLbl.Location = New System.Drawing.Point(2, 4)
			Me.NameLbl.Name = "NameLbl"
			Me.NameLbl.Size = New System.Drawing.Size(128, 23)
			Me.NameLbl.TabIndex = 0
			Me.NameLbl.Text = "Change Logs: "
			' 
			' ExitBtn
			' 
			Me.ExitBtn.BackColor = System.Drawing.SystemColors.Control
			Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
			Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.ExitBtn.Location = New System.Drawing.Point(361, 2)
			Me.ExitBtn.Name = "ExitBtn"
			Me.ExitBtn.Size = New System.Drawing.Size(24, 25)
			Me.ExitBtn.TabIndex = 1
			Me.ExitBtn.Text = "X"
			Me.ExitBtn.UseVisualStyleBackColor = False
'			Me.ExitBtn.Click += New System.EventHandler(Me.ExitBtn_Click)
			' 
			' SeprLbl
			' 
			Me.SeprLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.SeprLbl.Location = New System.Drawing.Point(3, 33)
			Me.SeprLbl.Name = "SeprLbl"
			Me.SeprLbl.Size = New System.Drawing.Size(383, 1)
			Me.SeprLbl.TabIndex = 4
			' 
			' VerLbl
			' 
			Me.VerLbl.AutoSize = True
			Me.VerLbl.Font = New System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.VerLbl.Location = New System.Drawing.Point(23, 46)
			Me.VerLbl.Name = "VerLbl"
			Me.VerLbl.Size = New System.Drawing.Size(46, 21)
			Me.VerLbl.TabIndex = 5
			Me.VerLbl.Text = "1.1.0:"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(44, 67)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(138, 32)
			Me.label1.TabIndex = 6
			Me.label1.Text = "[+] Code Optimization" & ControlChars.CrLf & "[+] Minor Bug Fixes" & ControlChars.CrLf
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(23, 118)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(155, 21)
			Me.label2.TabIndex = 7
			Me.label2.Text = "Ways To Contact Me:"
			' 
			' InstagramPicBox
			' 
			Me.InstagramPicBox.Cursor = System.Windows.Forms.Cursors.Hand
			Me.InstagramPicBox.Image = My.Resources.Instagram_Logo
			Me.InstagramPicBox.Location = New System.Drawing.Point(195, 141)
			Me.InstagramPicBox.Name = "InstagramPicBox"
			Me.InstagramPicBox.Size = New System.Drawing.Size(92, 89)
			Me.InstagramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.InstagramPicBox.TabIndex = 12
			Me.InstagramPicBox.TabStop = False
'			Me.InstagramPicBox.Click += New System.EventHandler(Me.InstagramPicBox_Click)
			' 
			' TelegramPicBox
			' 
			Me.TelegramPicBox.Cursor = System.Windows.Forms.Cursors.Hand
			Me.TelegramPicBox.Image = My.Resources.Telegram_Logo
			Me.TelegramPicBox.Location = New System.Drawing.Point(103, 146)
			Me.TelegramPicBox.Name = "TelegramPicBox"
			Me.TelegramPicBox.Size = New System.Drawing.Size(84, 81)
			Me.TelegramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.TelegramPicBox.TabIndex = 11
			Me.TelegramPicBox.TabStop = False
'			Me.TelegramPicBox.Click += New System.EventHandler(Me.TelegramPicBox_Click)
			' 
			' Information
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(387, 236)
			Me.ControlBox = False
			Me.Controls.Add(Me.InstagramPicBox)
			Me.Controls.Add(Me.TelegramPicBox)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.VerLbl)
			Me.Controls.Add(Me.SeprLbl)
			Me.Controls.Add(Me.ExitBtn)
			Me.Controls.Add(Me.NameLbl)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Information"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'			Me.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.Information_MouseDown)
			DirectCast(Me.InstagramPicBox, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.TelegramPicBox, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private NameLbl As System.Windows.Forms.Label
		Private WithEvents ExitBtn As System.Windows.Forms.Button
		Private SeprLbl As System.Windows.Forms.Label
		Private VerLbl As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents InstagramPicBox As System.Windows.Forms.PictureBox
		Private WithEvents TelegramPicBox As System.Windows.Forms.PictureBox
	End Class
End Namespace