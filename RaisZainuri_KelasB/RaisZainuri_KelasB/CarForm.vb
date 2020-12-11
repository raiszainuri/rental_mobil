Public Class CarForm
    Public idmobil As Integer = 0
    Public is_edit As Boolean = False
    Dim str_img_name As String = ""
    Private Sub CarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If is_edit Then
            Text = "Edit Data Mobil"
        Else
            Text = "Tambah Data Mobil"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not isfilled() Then
            MessageBox.Show("Lengkapi semua data")
        Else
            If is_edit Then
                Dim sql As String = "UPDATE Mobil_RaisZainuri SET nama_RaisZainuri ='" & tbnama.Text & "', plat_RaisZainuri = '" & tbplat.Text & "', harga_RaisZainuri = " & tbharga.Text & ",img_RaisZainuri='" & str_img_name & "' WHERE idmobil_RaisZainuri = " & idmobil

                If ex_query(sql) Then
                    Close()
                Else
                    MessageBox.Show("Gagal menyimpan data!")
                End If
            Else
                Dim sql As String = "INSERT INTO Mobil_RaisZainuri (nama_RaisZainuri,plat_RaisZainuri,harga_RaisZainuri,status_RaisZainuri,img_RaisZainuri) VALUES ('" & tbnama.Text & "','" & tbplat.Text & "'," & tbharga.Text & ",1,'" & str_img_name & "')"

                If ex_query(sql) Then
                    Close()
                Else
                    MessageBox.Show("Gagal menyimpan data!")
                End If
            End If
        End If
    End Sub

    Private Function isfilled()
        If validasi(tbharga) Or validasi(tbplat) Or validasi(tbnama) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ofd.Filter = "Image Files|*.jpg;*.png"
        Dim result As DialogResult = ofd.ShowDialog()
        If result = DialogResult.OK Then
            copyfile(ofd.FileName, Environment.CurrentDirectory & "\" & ofd.SafeFileName)
            tbfoto.Text = ofd.FileName
            str_img_name = ofd.SafeFileName
        End If

    End Sub

    Private Function copyfile(aa As String, bb As String)
        Try
            FileCopy(aa, bb)
        Catch ex As Exception

        End Try

        Return 0
    End Function

    Public Sub reset_all()
        tbfoto.Clear()
        tbharga.Clear()
        tbnama.Clear()
        tbplat.Clear()

        idmobil = 0
        is_edit = False
    End Sub
End Class