<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.btdangnhap = New System.Windows.Forms.Button()
        Me.btthoat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btdangnhap
        '
        Me.btdangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdangnhap.Location = New System.Drawing.Point(150, 237)
        Me.btdangnhap.Name = "btdangnhap"
        Me.btdangnhap.Size = New System.Drawing.Size(149, 83)
        Me.btdangnhap.TabIndex = 4
        Me.btdangnhap.Text = "Bắt Đầu"
        Me.btdangnhap.UseVisualStyleBackColor = True
        '
        'btthoat
        '
        Me.btthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.Location = New System.Drawing.Point(433, 237)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.Size = New System.Drawing.Size(149, 83)
        Me.btthoat.TabIndex = 5
        Me.btthoat.Text = "Thoát"
        Me.btthoat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 84)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "      Chào mừng đến với" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Phần mềm quản lý sinh viên"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 492)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btthoat)
        Me.Controls.Add(Me.btdangnhap)
        Me.Name = "frmLogin"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btdangnhap As Button
    Friend WithEvents btthoat As Button
    Friend WithEvents Label3 As Label
End Class
