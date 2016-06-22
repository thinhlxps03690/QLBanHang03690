<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanLySanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txttenanh = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ptbanh = New System.Windows.Forms.PictureBox()
        Me.btnchon = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Đơn giá:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tên SP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Số lượng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã SP:"
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(14, 149)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(131, 20)
        Me.txtDongia.TabIndex = 15
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(14, 110)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(131, 20)
        Me.txtSoluong.TabIndex = 14
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(14, 71)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(131, 20)
        Me.txtTenSP.TabIndex = 13
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(14, 31)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(131, 20)
        Me.txtMaSP.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(363, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 32)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quản Lý Sản Phẩm"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(179, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 182)
        Me.DataGridView1.TabIndex = 20
        '
        'txttenanh
        '
        Me.txttenanh.Location = New System.Drawing.Point(716, 248)
        Me.txttenanh.Name = "txttenanh"
        Me.txttenanh.Size = New System.Drawing.Size(100, 20)
        Me.txttenanh.TabIndex = 23
        Me.txttenanh.Text = "SP00.jgp"
        Me.txttenanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Yellow
        Me.btnBack.Image = Global.QLBanHangPS3690.My.Resources.Resources.dialog_ok4
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(537, 248)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 52)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "Đóng"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'ptbanh
        '
        Me.ptbanh.BackColor = System.Drawing.Color.Lime
        Me.ptbanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbanh.Location = New System.Drawing.Point(647, 47)
        Me.ptbanh.Name = "ptbanh"
        Me.ptbanh.Size = New System.Drawing.Size(220, 195)
        Me.ptbanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ptbanh.TabIndex = 22
        Me.ptbanh.TabStop = False
        '
        'btnchon
        '
        Me.btnchon.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnchon.Image = Global.QLBanHangPS3690.My.Resources.Resources.icon_download_40x40
        Me.btnchon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnchon.Location = New System.Drawing.Point(716, 274)
        Me.btnchon.Name = "btnchon"
        Me.btnchon.Size = New System.Drawing.Size(100, 50)
        Me.btnchon.TabIndex = 21
        Me.btnchon.Text = "Chọn Ảnh"
        Me.btnchon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnchon.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Magenta
        Me.btnThem.Image = Global.QLBanHangPS3690.My.Resources.Resources.ico_check1
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(277, 246)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(86, 54)
        Me.btnThem.TabIndex = 19
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.Image = Global.QLBanHangPS3690.My.Resources.Resources.delete_icon_40x403
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(450, 246)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(81, 54)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.Blue
        Me.btnSua.Image = Global.QLBanHangPS3690.My.Resources.Resources.icon_dichvu1
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(369, 246)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 54)
        Me.btnSua.TabIndex = 18
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.Lime
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnrefresh.Image = Global.QLBanHangPS3690.My.Resources.Resources.refresh2
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(179, 246)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(92, 54)
        Me.btnrefresh.TabIndex = 16
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(646, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Mã Ảnh SP:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDongia)
        Me.GroupBox1.Controls.Add(Me.txtSoluong)
        Me.GroupBox1.Controls.Add(Me.txtTenSP)
        Me.GroupBox1.Controls.Add(Me.txtMaSP)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 192)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Sản Phẩm"
        '
        'frmQuanLySanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(901, 333)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txttenanh)
        Me.Controls.Add(Me.ptbanh)
        Me.Controls.Add(Me.btnchon)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmQuanLySanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnrefresh As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDongia As TextBox
    Friend WithEvents txtSoluong As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnchon As Button
    Friend WithEvents ptbanh As PictureBox
    Friend WithEvents txttenanh As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
