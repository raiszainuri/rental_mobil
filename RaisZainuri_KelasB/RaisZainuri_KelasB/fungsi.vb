Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Module fungsi
    Dim conn As OleDbConnection
    Public cmd As OleDbCommand
    Public reader As OleDbDataReader
    Public radapter As OleDbDataAdapter
    Dim sql As String = ""
    Dim error_message As String = ""

    Public Function connect()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.CurrentDirectory & "/RentalMobil_RaisZainuri.mdb;Persist Security Info=False;")
        conn.Open()

        If conn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getdata_reader(sql As String)
        cmd = New OleDbCommand(sql, conn)
        cmd.CommandType = CommandType.Text

        Return cmd.ExecuteReader
    End Function

    Public Function getdata_radapter(sql As String)
        Dim dt = New DataTable
        radapter = New OleDbDataAdapter(sql, conn)
        radapter.Fill(dt)
        Return dt
    End Function

    Public Function validasi(tv As TextBox)
        If tv.Text.Trim.Length = 0 Then
            tv.Focus()
            Return True
        Else Return False
        End If
    End Function
    Public Function validasi(cb As ComboBox)
        If cb.Text.Trim.Length = 0 Then
            cb.Focus()
            Return True
        Else Return False
        End If
    End Function

    Public Function validasihapus()
        Dim res_dialog = MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res_dialog = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validasi_str()
        Dim res_dialog = MessageBox.Show("Apakah Anda yakin data telah benar? Note : Pilihan mobil tidak dapat diubah kedepannya", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res_dialog = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function setting_dgv1(dgv As DataGridView)
        dgv.Columns(0).Visible = False
        dgv.Columns(9).Visible = False
        dgv.Columns(10).DisplayIndex = 2

        dgv.Columns(1).HeaderText = "Tanggal"
        dgv.Columns(10).HeaderText = "Mobil"
        dgv.Columns(2).HeaderText = "NIK"
        dgv.Columns(3).HeaderText = "Nama"
        dgv.Columns(4).HeaderText = "No Telp"
        dgv.Columns(5).HeaderText = "Alamat"
        dgv.Columns(6).HeaderText = "Harga"
        dgv.Columns(7).HeaderText = "Lama Sewa"
        dgv.Columns(8).HeaderText = "Total"
        dgv.ClearSelection()
        Return 0
    End Function

    Public Function setting_dgv2(dgv As DataGridView)
        dgv.Columns(0).Visible = False
        dgv.Columns(5).Visible = False

        dgv.Columns(1).HeaderText = "Nama"
        dgv.Columns(2).HeaderText = "Plat"
        dgv.Columns(3).HeaderText = "Harga"
        dgv.Columns(4).HeaderText = "Status"
        dgv.ClearSelection()
        Return 0
    End Function

    Public Function get_url_img(dgv As DataGridView)
        Dim url_img As String = dgv.Rows(dgv.CurrentRow.Index).Cells(5).Value.ToString()
        Return Environment.CurrentDirectory & "\" & url_img
    End Function

    Public Function get_from_dgv(dgv As DataGridView, ind As Integer)
        Return dgv.Rows(dgv.CurrentRow.Index).Cells(ind).Value.ToString()
    End Function

    Public Function getiddgv(dgv As DataGridView)
        Return dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value
    End Function

    Public Function ex_query(sql As String)
        cmd = New OleDbCommand(sql, conn)
        cmd.CommandType = CommandType.Text
        Return cmd.ExecuteNonQuery
    End Function
End Module
