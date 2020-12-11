<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiForm
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
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.tb_nik = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.tb_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.cb_mobil = New System.Windows.Forms.ComboBox()
        Me.tb_totalharga = New System.Windows.Forms.TextBox()
        Me.tb_lamasewa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_harga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_notelp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_alamat
        '
        Me.tb_alamat.Location = New System.Drawing.Point(115, 121)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(163, 20)
        Me.tb_alamat.TabIndex = 3
        '
        'tb_nik
        '
        Me.tb_nik.Location = New System.Drawing.Point(115, 53)
        Me.tb_nik.Name = "tb_nik"
        Me.tb_nik.Size = New System.Drawing.Size(163, 20)
        Me.tb_nik.TabIndex = 1
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(115, 19)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(163, 20)
        Me.tb_nama.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.Teal
        Me.btn_simpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.Location = New System.Drawing.Point(0, 337)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(298, 38)
        Me.btn_simpan.TabIndex = 6
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'tb_tanggal
        '
        Me.tb_tanggal.Location = New System.Drawing.Point(115, 155)
        Me.tb_tanggal.Name = "tb_tanggal"
        Me.tb_tanggal.Size = New System.Drawing.Size(163, 20)
        Me.tb_tanggal.TabIndex = 4
        '
        'cb_mobil
        '
        Me.cb_mobil.FormattingEnabled = True
        Me.cb_mobil.Location = New System.Drawing.Point(115, 189)
        Me.cb_mobil.Name = "cb_mobil"
        Me.cb_mobil.Size = New System.Drawing.Size(163, 21)
        Me.cb_mobil.TabIndex = 19
        Me.cb_mobil.TabStop = False
        '
        'tb_totalharga
        '
        Me.tb_totalharga.Location = New System.Drawing.Point(115, 292)
        Me.tb_totalharga.Name = "tb_totalharga"
        Me.tb_totalharga.ReadOnly = True
        Me.tb_totalharga.Size = New System.Drawing.Size(163, 20)
        Me.tb_totalharga.TabIndex = 24
        Me.tb_totalharga.TabStop = False
        '
        'tb_lamasewa
        '
        Me.tb_lamasewa.Location = New System.Drawing.Point(115, 258)
        Me.tb_lamasewa.Name = "tb_lamasewa"
        Me.tb_lamasewa.Size = New System.Drawing.Size(163, 20)
        Me.tb_lamasewa.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Total Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Lama Sewa"
        '
        'tb_harga
        '
        Me.tb_harga.Location = New System.Drawing.Point(115, 224)
        Me.tb_harga.Name = "tb_harga"
        Me.tb_harga.ReadOnly = True
        Me.tb_harga.Size = New System.Drawing.Size(163, 20)
        Me.tb_harga.TabIndex = 21
        Me.tb_harga.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Harga Perhari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Mobil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Tanggal"
        '
        'tb_notelp
        '
        Me.tb_notelp.Location = New System.Drawing.Point(115, 87)
        Me.tb_notelp.Name = "tb_notelp"
        Me.tb_notelp.Size = New System.Drawing.Size(163, 20)
        Me.tb_notelp.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "No Telp"
        '
        'TransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 375)
        Me.Controls.Add(Me.tb_notelp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.tb_tanggal)
        Me.Controls.Add(Me.cb_mobil)
        Me.Controls.Add(Me.tb_totalharga)
        Me.Controls.Add(Me.tb_lamasewa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_harga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.tb_nik)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TransaksiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents tb_alamat As TextBox
    Public WithEvents tb_nik As TextBox
    Public WithEvents tb_nama As TextBox
    Public WithEvents tb_tanggal As DateTimePicker
    Public WithEvents cb_mobil As ComboBox
    Public WithEvents tb_totalharga As TextBox
    Public WithEvents tb_lamasewa As TextBox
    Public WithEvents tb_harga As TextBox
    Friend WithEvents tb_notelp As TextBox
    Friend WithEvents Label7 As Label
End Class
