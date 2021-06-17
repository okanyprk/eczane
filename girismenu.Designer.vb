<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class girismenu
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(girismenu))
        Me.recetebtn = New System.Windows.Forms.Button()
        Me.ilacbtn = New System.Windows.Forms.Button()
        Me.hastabtn = New System.Windows.Forms.Button()
        Me.cikisbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'recetebtn
        '
        Me.recetebtn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.recetebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recetebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.recetebtn.Location = New System.Drawing.Point(12, 167)
        Me.recetebtn.Name = "recetebtn"
        Me.recetebtn.Size = New System.Drawing.Size(124, 58)
        Me.recetebtn.TabIndex = 0
        Me.recetebtn.Text = "Reçete Satış"
        Me.recetebtn.UseVisualStyleBackColor = False
        '
        'ilacbtn
        '
        Me.ilacbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ilacbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ilacbtn.Location = New System.Drawing.Point(12, 83)
        Me.ilacbtn.Name = "ilacbtn"
        Me.ilacbtn.Size = New System.Drawing.Size(124, 58)
        Me.ilacbtn.TabIndex = 1
        Me.ilacbtn.Text = "İlaç Ekle"
        Me.ilacbtn.UseVisualStyleBackColor = True
        '
        'hastabtn
        '
        Me.hastabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hastabtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.hastabtn.Location = New System.Drawing.Point(319, 83)
        Me.hastabtn.Name = "hastabtn"
        Me.hastabtn.Size = New System.Drawing.Size(124, 58)
        Me.hastabtn.TabIndex = 2
        Me.hastabtn.Text = "Hasta Kayıt"
        Me.hastabtn.UseVisualStyleBackColor = True
        '
        'cikisbtn
        '
        Me.cikisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cikisbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cikisbtn.Location = New System.Drawing.Point(319, 167)
        Me.cikisbtn.Name = "cikisbtn"
        Me.cikisbtn.Size = New System.Drawing.Size(124, 58)
        Me.cikisbtn.TabIndex = 3
        Me.cikisbtn.Text = "Çıkış"
        Me.cikisbtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eczaneotomasyon.My.Resources.Resources.eczane
        Me.PictureBox1.Location = New System.Drawing.Point(142, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hoşgeldiniz"
        '
        'girismenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(455, 309)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cikisbtn)
        Me.Controls.Add(Me.hastabtn)
        Me.Controls.Add(Me.ilacbtn)
        Me.Controls.Add(Me.recetebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "girismenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menü"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents recetebtn As Button
    Friend WithEvents ilacbtn As Button
    Friend WithEvents hastabtn As Button
    Friend WithEvents cikisbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
