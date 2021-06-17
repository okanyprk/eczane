<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class firmakaydet
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(firmakaydet))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.anamenubtn = New System.Windows.Forms.Button()
        Me.kaydetbtn = New System.Windows.Forms.Button()
        Me.guncellebtn = New System.Windows.Forms.Button()
        Me.silbtn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.arabtn = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.PaleTurquoise
        Me.DataGridView1.Location = New System.Drawing.Point(12, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(464, 234)
        Me.DataGridView1.TabIndex = 0
        '
        'anamenubtn
        '
        Me.anamenubtn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.anamenubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.anamenubtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.anamenubtn.Location = New System.Drawing.Point(486, 134)
        Me.anamenubtn.Name = "anamenubtn"
        Me.anamenubtn.Size = New System.Drawing.Size(107, 54)
        Me.anamenubtn.TabIndex = 1
        Me.anamenubtn.Text = "Ana Menü"
        Me.anamenubtn.UseVisualStyleBackColor = False
        '
        'kaydetbtn
        '
        Me.kaydetbtn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.kaydetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kaydetbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kaydetbtn.Location = New System.Drawing.Point(486, 63)
        Me.kaydetbtn.Name = "kaydetbtn"
        Me.kaydetbtn.Size = New System.Drawing.Size(107, 54)
        Me.kaydetbtn.TabIndex = 2
        Me.kaydetbtn.Text = "Kaydet"
        Me.kaydetbtn.UseVisualStyleBackColor = False
        '
        'guncellebtn
        '
        Me.guncellebtn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.guncellebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.guncellebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.guncellebtn.Location = New System.Drawing.Point(486, 194)
        Me.guncellebtn.Name = "guncellebtn"
        Me.guncellebtn.Size = New System.Drawing.Size(107, 54)
        Me.guncellebtn.TabIndex = 3
        Me.guncellebtn.Text = "Güncelle"
        Me.guncellebtn.UseVisualStyleBackColor = False
        '
        'silbtn
        '
        Me.silbtn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.silbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.silbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.silbtn.Location = New System.Drawing.Point(486, 254)
        Me.silbtn.Name = "silbtn"
        Me.silbtn.Size = New System.Drawing.Size(107, 54)
        Me.silbtn.TabIndex = 4
        Me.silbtn.Text = "Sil"
        Me.silbtn.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button5.Location = New System.Drawing.Point(486, 314)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 54)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Çıkış"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(486, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(107, 20)
        Me.TextBox1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(139, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'arabtn
        '
        Me.arabtn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.arabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.arabtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.arabtn.Location = New System.Drawing.Point(139, 90)
        Me.arabtn.Name = "arabtn"
        Me.arabtn.Size = New System.Drawing.Size(100, 38)
        Me.arabtn.TabIndex = 8
        Me.arabtn.Text = "Ara"
        Me.arabtn.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Firma Adı :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Eklemek istediğiniz firmanın adını yazıp 'Kaydet' butonuna basınız."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Arama"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eczaneotomasyon.My.Resources.Resources.buyutec
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'firmakaydet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(605, 379)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.arabtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.silbtn)
        Me.Controls.Add(Me.guncellebtn)
        Me.Controls.Add(Me.kaydetbtn)
        Me.Controls.Add(Me.anamenubtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "firmakaydet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Firma Ekle"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents anamenubtn As Button
    Friend WithEvents kaydetbtn As Button
    Friend WithEvents guncellebtn As Button
    Friend WithEvents silbtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents arabtn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
