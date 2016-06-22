<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTimkimsanpham
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
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbltensp = New System.Windows.Forms.Label()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.btntimtensp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.Color.Magenta
        Me.btnDong.BackgroundImage = Global.QLBanHangPS3690.My.Resources.Resources.dialog_ok1
        Me.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(2, 151)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(108, 52)
        Me.btnDong.TabIndex = 18
        Me.btnDong.Text = "Đóng"
        Me.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'btnXemall
        '
        Me.btnXemall.BackColor = System.Drawing.Color.Magenta
        Me.btnXemall.Image = Global.QLBanHangPS3690.My.Resources.Resources.ico_check1
        Me.btnXemall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXemall.Location = New System.Drawing.Point(2, 74)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(108, 52)
        Me.btnXemall.TabIndex = 16
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXemall.UseVisualStyleBackColor = False
        '
        'btnXem
        '
        Me.btnXem.BackColor = System.Drawing.Color.Lime
        Me.btnXem.Image = Global.QLBanHangPS3690.My.Resources.Resources.icon_feature_sem_credits
        Me.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXem.Location = New System.Drawing.Point(83, 273)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(104, 52)
        Me.btnXem.TabIndex = 17
        Me.btnXem.Text = "Tìm Mã SP"
        Me.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXem.UseVisualStyleBackColor = False
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(61, 247)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(160, 20)
        Me.txtMaSP.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Mã SP"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(116, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 175)
        Me.DataGridView1.TabIndex = 19
        '
        'lbltensp
        '
        Me.lbltensp.AutoSize = True
        Me.lbltensp.Location = New System.Drawing.Point(242, 250)
        Me.lbltensp.Name = "lbltensp"
        Me.lbltensp.Size = New System.Drawing.Size(43, 13)
        Me.lbltensp.TabIndex = 14
        Me.lbltensp.Text = "Tên SP"
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(291, 246)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(155, 20)
        Me.txttensp.TabIndex = 21
        '
        'btntimtensp
        '
        Me.btntimtensp.BackColor = System.Drawing.Color.Lime
        Me.btntimtensp.Image = Global.QLBanHangPS3690.My.Resources.Resources.icon_feature_sem_credits
        Me.btntimtensp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntimtensp.Location = New System.Drawing.Point(316, 273)
        Me.btntimtensp.Name = "btntimtensp"
        Me.btntimtensp.Size = New System.Drawing.Size(108, 51)
        Me.btntimtensp.TabIndex = 22
        Me.btntimtensp.Text = "Tìm Tên SP"
        Me.btntimtensp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntimtensp.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(119, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 32)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tìm Kiếm Sản Phẩm"
        '
        'frmTimkimsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(484, 329)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btntimtensp)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lbltensp)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmTimkimsanpham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tim Kiếm Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDong As Button
    Friend WithEvents btnXemall As Button
    Friend WithEvents btnXem As Button
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbltensp As Label
    Friend WithEvents txttensp As TextBox
    Friend WithEvents btntimtensp As Button
    Friend WithEvents Label1 As Label
End Class
