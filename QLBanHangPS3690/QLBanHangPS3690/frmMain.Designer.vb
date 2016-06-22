<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnthongtinKH = New System.Windows.Forms.Button()
        Me.btnHoaDon = New System.Windows.Forms.Button()
        Me.btntimkh = New System.Windows.Forms.Button()
        Me.btntimSP = New System.Windows.Forms.Button()
        Me.btnthongtinSP = New System.Windows.Forms.Button()
        Me.lblLink = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(434, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 225)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin SV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lớp: PT11101"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tên SV: Lưu Xuân Thịnh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MSSV: PS03690"
        '
        'btnthongtinKH
        '
        Me.btnthongtinKH.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnthongtinKH.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnthongtinKH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthongtinKH.Location = New System.Drawing.Point(268, 283)
        Me.btnthongtinKH.Name = "btnthongtinKH"
        Me.btnthongtinKH.Size = New System.Drawing.Size(99, 50)
        Me.btnthongtinKH.TabIndex = 16
        Me.btnthongtinKH.Text = "Thông Tin KH"
        Me.btnthongtinKH.UseVisualStyleBackColor = False
        '
        'btnHoaDon
        '
        Me.btnHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHoaDon.BackColor = System.Drawing.Color.LightCoral
        Me.btnHoaDon.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoaDon.Location = New System.Drawing.Point(533, 283)
        Me.btnHoaDon.Name = "btnHoaDon"
        Me.btnHoaDon.Size = New System.Drawing.Size(98, 50)
        Me.btnHoaDon.TabIndex = 17
        Me.btnHoaDon.Text = "Hóa Đơn"
        Me.btnHoaDon.UseVisualStyleBackColor = False
        '
        'btntimkh
        '
        Me.btntimkh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btntimkh.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btntimkh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntimkh.Location = New System.Drawing.Point(399, 283)
        Me.btntimkh.Name = "btntimkh"
        Me.btntimkh.Size = New System.Drawing.Size(98, 50)
        Me.btntimkh.TabIndex = 18
        Me.btntimkh.Text = "Tìm KH"
        Me.btntimkh.UseVisualStyleBackColor = False
        '
        'btntimSP
        '
        Me.btntimSP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btntimSP.BackColor = System.Drawing.Color.SlateBlue
        Me.btntimSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntimSP.Location = New System.Drawing.Point(145, 283)
        Me.btntimSP.Name = "btntimSP"
        Me.btntimSP.Size = New System.Drawing.Size(98, 50)
        Me.btntimSP.TabIndex = 20
        Me.btntimSP.Text = "Tìm SP"
        Me.btntimSP.UseVisualStyleBackColor = False
        '
        'btnthongtinSP
        '
        Me.btnthongtinSP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnthongtinSP.BackColor = System.Drawing.Color.SlateBlue
        Me.btnthongtinSP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthongtinSP.Location = New System.Drawing.Point(19, 283)
        Me.btnthongtinSP.Name = "btnthongtinSP"
        Me.btnthongtinSP.Size = New System.Drawing.Size(98, 50)
        Me.btnthongtinSP.TabIndex = 21
        Me.btnthongtinSP.Text = "Thông Tin SP"
        Me.btnthongtinSP.UseVisualStyleBackColor = False
        '
        'lblLink
        '
        Me.lblLink.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLink.AutoSize = True
        Me.lblLink.Font = New System.Drawing.Font(".VnArial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLink.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblLink.LinkColor = System.Drawing.Color.Red
        Me.lblLink.Location = New System.Drawing.Point(265, 344)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(145, 18)
        Me.lblLink.TabIndex = 15
        Me.lblLink.TabStop = True
        Me.lblLink.Text = "www.poly.edu.vn"
        Me.lblLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(139, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(373, 32)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Phần Mềm Quản Lý Bán Hàng"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.QLBanHangPS3690.My.Resources.Resources.hinh_2_9_
        Me.PictureBox2.Location = New System.Drawing.Point(23, 76)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(396, 173)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLBanHangPS3690.My.Resources.Resources._13239148_650758688410318_1154928306101129384_n
        Me.PictureBox1.Location = New System.Drawing.Point(36, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepPink
        Me.ClientSize = New System.Drawing.Size(655, 369)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnthongtinKH)
        Me.Controls.Add(Me.btnHoaDon)
        Me.Controls.Add(Me.btntimkh)
        Me.Controls.Add(Me.btntimSP)
        Me.Controls.Add(Me.btnthongtinSP)
        Me.Controls.Add(Me.lblLink)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnthongtinKH As Button
    Friend WithEvents btnHoaDon As Button
    Friend WithEvents btntimkh As Button
    Friend WithEvents btntimSP As Button
    Friend WithEvents btnthongtinSP As Button
    Friend WithEvents lblLink As LinkLabel
    Friend WithEvents Label5 As Label
End Class
