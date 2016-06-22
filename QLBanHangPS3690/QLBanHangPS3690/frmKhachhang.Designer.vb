<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachhang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMakh = New System.Windows.Forms.TextBox()
        Me.txtTenkhachhang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtSdt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttenanh = New System.Windows.Forms.TextBox()
        Me.ptbanh = New System.Windows.Forms.PictureBox()
        Me.btnchon = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptbanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Địa Chỉ"
        '
        'txtMakh
        '
        Me.txtMakh.Location = New System.Drawing.Point(10, 50)
        Me.txtMakh.Name = "txtMakh"
        Me.txtMakh.Size = New System.Drawing.Size(164, 20)
        Me.txtMakh.TabIndex = 1
        '
        'txtTenkhachhang
        '
        Me.txtTenkhachhang.Location = New System.Drawing.Point(10, 101)
        Me.txtTenkhachhang.Name = "txtTenkhachhang"
        Me.txtTenkhachhang.Size = New System.Drawing.Size(164, 20)
        Me.txtTenkhachhang.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SĐT"
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(10, 150)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(164, 20)
        Me.txtDiachi.TabIndex = 1
        '
        'txtSdt
        '
        Me.txtSdt.Location = New System.Drawing.Point(10, 205)
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(164, 20)
        Me.txtSdt.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(248, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(408, 201)
        Me.DataGridView1.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Lime
        Me.btnRefresh.Image = Global.QLBanHangPS3690.My.Resources.Resources.refresh
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(620, 284)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 46)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.Color.Yellow
        Me.btnDong.Image = Global.QLBanHangPS3690.My.Resources.Resources.dialog_ok
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(246, 284)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(94, 46)
        Me.btnDong.TabIndex = 3
        Me.btnDong.Text = "Đóng"
        Me.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.Blue
        Me.btnSua.Image = Global.QLBanHangPS3690.My.Resources.Resources.icon_dichvu
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(346, 284)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(94, 46)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnXoa.Image = Global.QLBanHangPS3690.My.Resources.Resources.images1
        Me.btnXoa.Location = New System.Drawing.Point(446, 284)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(68, 46)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.Color.Magenta
        Me.btnthem.Image = Global.QLBanHangPS3690.My.Resources.Resources.ico_check
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(520, 284)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(94, 46)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(266, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quản Lý Khách Hàng"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSdt)
        Me.GroupBox1.Controls.Add(Me.txtDiachi)
        Me.GroupBox1.Controls.Add(Me.txtTenkhachhang)
        Me.GroupBox1.Controls.Add(Me.txtMakh)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(664, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 234)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Khách Hàng"
        '
        'txttenanh
        '
        Me.txttenanh.Location = New System.Drawing.Point(81, 267)
        Me.txttenanh.Name = "txttenanh"
        Me.txttenanh.Size = New System.Drawing.Size(100, 20)
        Me.txttenanh.TabIndex = 27
        Me.txttenanh.Text = "KH00.jgp"
        Me.txttenanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ptbanh
        '
        Me.ptbanh.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ptbanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbanh.Location = New System.Drawing.Point(12, 66)
        Me.ptbanh.Name = "ptbanh"
        Me.ptbanh.Size = New System.Drawing.Size(220, 195)
        Me.ptbanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ptbanh.TabIndex = 26
        Me.ptbanh.TabStop = False
        '
        'btnchon
        '
        Me.btnchon.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnchon.Image = Global.QLBanHangPS3690.My.Resources.Resources.icon_download_40x40
        Me.btnchon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnchon.Location = New System.Drawing.Point(81, 293)
        Me.btnchon.Name = "btnchon"
        Me.btnchon.Size = New System.Drawing.Size(100, 50)
        Me.btnchon.TabIndex = 25
        Me.btnchon.Text = "Chọn Ảnh"
        Me.btnchon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnchon.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Mã Ảnh SP:"
        '
        'frmKhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(867, 349)
        Me.Controls.Add(Me.txttenanh)
        Me.Controls.Add(Me.ptbanh)
        Me.Controls.Add(Me.btnchon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmKhachhang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Khách Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptbanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMakh As TextBox
    Friend WithEvents txtTenkhachhang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents txtSdt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnthem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnDong As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttenanh As TextBox
    Friend WithEvents ptbanh As PictureBox
    Friend WithEvents btnchon As Button
    Friend WithEvents Label6 As Label
End Class
