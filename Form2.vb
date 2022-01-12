Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()

        Dim i As Integer
        For i = Year(Now) To 2000 Step -1
            ComboTahun.Items.Add(i)
        Next

        Dim dokter As String
        Dim nama() As String = {"Dr. Aziz", "Dr. Firman", "Dr. Jonny"}
        For Each dokter In nama
            ComboDokter.Items.Add(dokter)
        Next

        Dim a As Integer
        For a = 1 To 20 Step +1
            ComboAntrian.Items.Add(a)
        Next

    End Sub

    Private Sub btncls_Click(sender As Object, e As EventArgs) Handles btncls.Click
        Form1.Close()
    End Sub

    Private Sub btnmax_Click(sender As Object, e As EventArgs) Handles btnmax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Btnpasien_Click(sender As Object, e As EventArgs) Handles btnpasien.Click
        'label kiri btn
        Label1.Visible = True
        Label2.Visible = False
        Label10.Visible = False
        'Panel Control Content
        pnlpasien.Visible = True
        pnllistpasien.Visible = False
        pnlprofile.Visible = False
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Terpenuhi As Boolean = True
        Dim item As New ListViewItem(ComboAntrian.Text$)
        While Terpenuhi
            If String.IsNullOrEmpty(ComboAntrian.Text) Then
                MsgBox("Kolom Nomor Antrian mohon di isi", vbExclamation, "Nomor Antrian")
                Terpenuhi = False
                Return
            ElseIf String.IsNullOrEmpty(TextBox1.Text) Then
                MsgBox("Nama mohon di isi", vbExclamation, "Nama")
                Terpenuhi = False
                Return
            ElseIf String.IsNullOrEmpty(ComboTahun.Text) Then
                MsgBox("Tahun Lahir mohon di isi", vbExclamation, "Tahun Lahir")
                Terpenuhi = False
                Return
            ElseIf String.IsNullOrEmpty(ComboDokter.Text) Then
                MsgBox("Nama Dokter mohon di pilih", vbExclamation, "Dokter")
                Terpenuhi = False
                Return
            ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
                MsgBox("Nomor Telepon mohon di isi", vbExclamation, "Nomor Telepon")
                Terpenuhi = False
                Return
            Else item.SubItems.Add(TextBox1.Text$)
                item.SubItems.Add(ComboTahun.Text$)
                item.SubItems.Add(ComboDokter.Text$)
                item.SubItems.Add(TextBox2.Text$)
                ListView1.Items.Add(item)
                ComboAntrian.SelectedIndex = -1
                TextBox1.Text = ""
                ComboTahun.SelectedIndex = -1
                ComboDokter.SelectedIndex = -1
                TextBox2.Text = ""
                MsgBox("Data Tersimpan", vbInformation, "simpan data")
                Terpenuhi = False
                Return
            End If
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Menghapus? ", MsgBoxStyle.YesNo, "Hapus Data")
        If pesan = vbYes And ListView1.SelectedItems.Count > 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        'label kiri btn
        Label1.Visible = False
        Label2.Visible = False
        Label10.Visible = True
        'Panel Control Content
        pnlpasien.Visible = False
        pnllistpasien.Visible = False
        pnlprofile.Visible = True
    End Sub

    Private Sub btnlistpasien_Click(sender As Object, e As EventArgs) Handles btnlistpasien.Click
        'label kiri btn
        Label1.Visible = False
        Label2.Visible = True
        Label10.Visible = False
        'Panel Control Content
        pnlpasien.Visible = False
        pnllistpasien.Visible = True
        pnlprofile.Visible = False
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Labelselamat_Click(sender As Object, e As EventArgs) Handles Labelselamat.Click

    End Sub

    Private Sub ComboTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTahun.SelectedIndexChanged

    End Sub
End Class