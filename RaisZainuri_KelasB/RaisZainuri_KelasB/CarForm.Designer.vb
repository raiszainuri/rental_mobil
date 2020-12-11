<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarForm
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
        Me.tbplat = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbharga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbfoto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'tbplat
        '
        Me.tbplat.Location = New System.Drawing.Point(89, 43)
        Me.tbplat.Name = "tbplat"
        Me.tbplat.Size = New System.Drawing.Size(163, 20)
        Me.tbplat.TabIndex = 1
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(89, 17)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(163, 20)
        Me.tbnama.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Plat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Nama"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Teal
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(279, 34)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Simpan"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'tbharga
        '
        Me.tbharga.Location = New System.Drawing.Point(89, 69)
        Me.tbharga.Name = "tbharga"
        Me.tbharga.Size = New System.Drawing.Size(163, 20)
        Me.tbharga.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Harga"
        '
        'tbfoto
        '
        Me.tbfoto.Location = New System.Drawing.Point(89, 95)
        Me.tbfoto.Name = "tbfoto"
        Me.tbfoto.ReadOnly = True
        Me.tbfoto.Size = New System.Drawing.Size(125, 20)
        Me.tbfoto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Foto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 20)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "/"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 172)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbfoto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbharga)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbplat)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Mobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Public WithEvents tbplat As TextBox
    Public WithEvents tbnama As TextBox
    Public WithEvents tbharga As TextBox
    Public WithEvents tbfoto As TextBox
    Friend WithEvents ofd As OpenFileDialog
End Class
