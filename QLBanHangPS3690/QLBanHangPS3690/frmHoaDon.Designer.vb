<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoaDon
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
        Me.txtsohd = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttrigia = New System.Windows.Forms.TextBox()
        Me.txtmanv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsohd
        '
        Me.txtsohd.Location = New System.Drawing.Point(111, 19)
        Me.txtsohd.Name = "txtsohd"
        Me.txtsohd.Size = New System.Drawing.Size(123, 20)
        Me.txtsohd.TabIndex = 1
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(111, 104)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(123, 20)
        Me.txtmakh.TabIndex = 1
        '
        'txttrigia
        '
        Me.txttrigia.Location = New System.Drawing.Point(111, 147)
        Me.txttrigia.Name = "txttrigia"
        Me.txttrigia.Size = New System.Drawing.Size(123, 20)
        Me.txttrigia.TabIndex = 1
        '
        'txtmanv
        '
        Me.txtmanv.Location = New System.Drawing.Point(111, 186)
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.Size = New System.Drawing.Size(123, 20)
        Me.txtmanv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Số HĐ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ngày Lập"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã KH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Trị giá"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Mã NV"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 226)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(554, 156)
        Me.DataGridView1.TabIndex = 3
        '
        'dtpNgay
        '
        Me.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgay.Location = New System.Drawing.Point(111, 58)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Size = New System.Drawing.Size(123, 20)
        Me.dtpNgay.TabIndex = 61
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Lime
        Me.btnRefresh.Image = Global.QLBanHangPS3690.My.Resources.Resources.refresh
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(89, 150)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 46)
        Me.btnRefresh.TabIndex = 66
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.Color.Yellow
        Me.btnDong.Image = Global.QLBanHangPS3690.My.Resources.Resources.dialog_ok
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(22, 22)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(94, 46)
        Me.btnDong.TabIndex = 62
        Me.btnDong.Text = "Đóng"
        Me.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.Blue
        Me.btnSua.Image = Global.QLBanHangPS3690.My.Resources.Resources.icon_dichvu
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(22, 93)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(94, 46)
        Me.btnSua.TabIndex = 63
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnXoa.Image = Global.QLBanHangPS3690.My.Resources.Resources.images1
        Me.btnXoa.Location = New System.Drawing.Point(155, 25)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(94, 46)
        Me.btnXoa.TabIndex = 64
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.Color.Magenta
        Me.btnthem.Image = Global.QLBanHangPS3690.My.Resources.Resources.ico_check
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(155, 93)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(94, 46)
        Me.btnthem.TabIndex = 65
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgay)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtmanv)
        Me.GroupBox1.Controls.Add(Me.txttrigia)
        Me.GroupBox1.Controls.Add(Me.txtmakh)
        Me.GroupBox1.Controls.Add(Me.txtsohd)
        Me.GroupBox1.Location = New System.Drawing.Point(292, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 223)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Hóa Đơn"
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(584, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa Đơn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsohd As TextBox
    Friend WithEvents txtmakh As TextBox
    Friend WithEvents txttrigia As TextBox
    Friend WithEvents txtmanv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDong As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnthem As Button
    Friend WithEvents btnxemin As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
