Public Class frmDangNhap
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close() ' đóng tab
    End Sub

    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        'đăng nhập kết nối với form chính
        If txtTK.Text = Nothing And txtMK.Text = Nothing Then
            MsgBox("Cần Nhập Tài Khoản và Mật Khẩu", MsgBoxStyle.Critical)

            Exit Sub
        End If
        If txtTK.Text = "admin" And txtMK.Text = "12345" Then
            MsgBox("Đăng Nhập Thành Công!!!!", MsgBoxStyle.Information)
            frmMain.Show()

            Me.Hide()

        Else
            MsgBox("Tài khoản và Mật khẩu không đúng", MsgBoxStyle.Critical)
        End If
    End Sub

End Class