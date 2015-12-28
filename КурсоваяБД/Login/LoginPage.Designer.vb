<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(56, 139)
        Me.TextBox1.MaxLength = 35
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(307, 21)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "irina.blagun@gmail.com"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(57, 208)
        Me.TextBox2.MaxLength = 15
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(308, 30)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "123"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(188, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 36)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Забыли пароль?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.AccessibleName = ""
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(371, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 336)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = Global.КурсоваяБД.My.Resources.Resources.Авторизация
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(56, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(217, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Пароль"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "E-mail"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.КурсоваяБД.My.Resources.Resources.button_Войти
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 256)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AccessibleName = ""
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(348, 404)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 259)
        Me.Panel2.TabIndex = 10
        Me.Panel2.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Image = Global.КурсоваяБД.My.Resources.Resources.ВосстановлениеПароля
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(52, 49)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(350, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(211, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 36)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Вернуться"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "E-mail"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(52, 133)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(452, 30)
        Me.TextBox3.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Image = Global.КурсоваяБД.My.Resources.Resources.button_Отправить
        Me.PictureBox2.Location = New System.Drawing.Point(53, 182)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1352, 691)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LoginPage"
        Me.Text = "IWork - Авторизация"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
