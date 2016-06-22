<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKH
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
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btvXemall = New System.Windows.Forms.Button()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.cboMaKH = New System.Windows.Forms.ComboBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.Color.Gray
        Me.btnDong.Image = Global.QLBanHangPS3690.My.Resources.Resources.dialog_ok
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(206, 342)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(92, 47)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Trở về"
        Me.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tìm Kiếm Khách Hàng"
        '
        'btvXemall
        '
        Me.btvXemall.BackColor = System.Drawing.Color.Lime
        Me.btvXemall.BackgroundImage = Global.QLBanHangPS3690.My.Resources.Resources.ico_check1
        Me.btvXemall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btvXemall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btvXemall.Location = New System.Drawing.Point(12, 44)
        Me.btvXemall.Name = "btvXemall"
        Me.btvXemall.Size = New System.Drawing.Size(115, 53)
        Me.btvXemall.TabIndex = 12
        Me.btvXemall.Text = "Xem Tất Cả"
        Me.btvXemall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btvXemall.UseVisualStyleBackColor = False
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(363, 105)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtDiachi.TabIndex = 11
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(363, 61)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(100, 20)
        Me.txtTenKH.TabIndex = 10
        '
        'cboMaKH
        '
        Me.cboMaKH.FormattingEnabled = True
        Me.cboMaKH.Location = New System.Drawing.Point(193, 61)
        Me.cboMaKH.Name = "cboMaKH"
        Me.cboMaKH.Size = New System.Drawing.Size(85, 21)
        Me.cboMaKH.TabIndex = 9
        '
        'dgvKH
        '
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(22, 131)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(441, 205)
        Me.dgvKH.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Mã KH:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tên KH:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Địa Chỉ KH:"
        '
        'frmTimKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(491, 394)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btvXemall)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.cboMaKH)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDong)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmTimKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm Kiếm Khách Hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDong As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btvXemall As Button
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents cboMaKH As ComboBox
    Friend WithEvents dgvKH As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
