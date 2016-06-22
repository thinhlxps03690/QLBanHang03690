Public Class frmMain
    Private Sub btnthongtinSP_Click(sender As Object, e As EventArgs) Handles btnthongtinSP.Click
        frmQuanLySanPham.Show() 'show frSP
    End Sub

    Private Sub btntimSP_Click(sender As Object, e As EventArgs) Handles btntimSP.Click
        frmTimkimsanpham.Show() 'show frtimkimSP
    End Sub

    Private Sub btnthongtinKH_Click(sender As Object, e As EventArgs) Handles btnthongtinKH.Click
        frmKhachhang.Show() 'show frKH
    End Sub

    Private Sub btntimkh_Click(sender As Object, e As EventArgs) Handles btntimkh.Click
        frmTimKH.Show() 'show frtimKH
    End Sub

    Private Sub btnHoaDon_Click(sender As Object, e As EventArgs) Handles btnHoaDon.Click
        frmHoaDon.Show() 'show frHD
    End Sub

    Private Sub frmmain_closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmDangNhap.Show() 'show frMain
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Coming_Home___Diddy_Dirty_Money_Skylar_Grey, AudioPlayMode.BackgroundLoop) 'nhạc
    End Sub
End Class