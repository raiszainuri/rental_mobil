Public Class ChooseCar

    Private Sub btn_tambah_car_Click(sender As Object, e As EventArgs) Handles btn_tambah_car.Click
        Form1.res_selected = True
        Close()
    End Sub

    Private Sub ChooseCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = getdata_radapter("SELECT * FROM Mobil_RaisZainuri")
        dgv1.DataSource = dt
        setting_dgv2(dgv1)
        dgv1.ClearSelection()
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        get_data()
    End Sub

    Private Sub get_data()
        PictureBox1.ImageLocation = get_url_img(dgv1)
        Form1.res_mobil_id = Int32.Parse(get_from_dgv(dgv1, 0))
        Form1.res_mobil_harga = Int32.Parse(get_from_dgv(dgv1, 3))
        Form1.res_mobil_nama = get_from_dgv(dgv1, 1)
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        get_data()
        Form1.res_selected = True
        Close()
    End Sub
End Class