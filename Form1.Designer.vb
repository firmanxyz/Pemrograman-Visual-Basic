<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlatas = New System.Windows.Forms.Panel()
        Me.pnlctl = New System.Windows.Forms.Panel()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btnmax = New System.Windows.Forms.Button()
        Me.btncls = New System.Windows.Forms.Button()
        Me.CheckPassword = New System.Windows.Forms.CheckBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlatas.SuspendLayout()
        Me.pnlctl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(76, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnlatas
        '
        Me.pnlatas.BackColor = System.Drawing.Color.Silver
        Me.pnlatas.Controls.Add(Me.pnlctl)
        Me.pnlatas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlatas.Location = New System.Drawing.Point(0, 0)
        Me.pnlatas.Name = "pnlatas"
        Me.pnlatas.Size = New System.Drawing.Size(934, 44)
        Me.pnlatas.TabIndex = 2
        '
        'pnlctl
        '
        Me.pnlctl.Controls.Add(Me.btnmin)
        Me.pnlctl.Controls.Add(Me.btnmax)
        Me.pnlctl.Controls.Add(Me.btncls)
        Me.pnlctl.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlctl.Location = New System.Drawing.Point(799, 0)
        Me.pnlctl.Name = "pnlctl"
        Me.pnlctl.Size = New System.Drawing.Size(135, 44)
        Me.pnlctl.TabIndex = 0
        '
        'btnmin
        '
        Me.btnmin.FlatAppearance.BorderSize = 0
        Me.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmin.Image = CType(resources.GetObject("btnmin.Image"), System.Drawing.Image)
        Me.btnmin.Location = New System.Drawing.Point(47, 13)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(18, 18)
        Me.btnmin.TabIndex = 2
        Me.btnmin.UseVisualStyleBackColor = True
        '
        'btnmax
        '
        Me.btnmax.FlatAppearance.BorderSize = 0
        Me.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmax.Image = CType(resources.GetObject("btnmax.Image"), System.Drawing.Image)
        Me.btnmax.Location = New System.Drawing.Point(73, 13)
        Me.btnmax.Name = "btnmax"
        Me.btnmax.Size = New System.Drawing.Size(18, 18)
        Me.btnmax.TabIndex = 1
        Me.btnmax.UseVisualStyleBackColor = True
        '
        'btncls
        '
        Me.btncls.FlatAppearance.BorderSize = 0
        Me.btncls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncls.Image = CType(resources.GetObject("btncls.Image"), System.Drawing.Image)
        Me.btncls.Location = New System.Drawing.Point(99, 13)
        Me.btncls.Name = "btncls"
        Me.btncls.Size = New System.Drawing.Size(18, 18)
        Me.btncls.TabIndex = 0
        Me.btncls.UseVisualStyleBackColor = True
        '
        'CheckPassword
        '
        Me.CheckPassword.AutoSize = True
        Me.CheckPassword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CheckPassword.Location = New System.Drawing.Point(78, 248)
        Me.CheckPassword.Name = "CheckPassword"
        Me.CheckPassword.Size = New System.Drawing.Size(108, 19)
        Me.CheckPassword.TabIndex = 5
        Me.CheckPassword.Text = "Show Password"
        Me.CheckPassword.UseVisualStyleBackColor = True
        '
        'TextPassword
        '
        Me.TextPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextPassword.Location = New System.Drawing.Point(76, 214)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(200, 29)
        Me.TextPassword.TabIndex = 4
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(76, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 29)
        Me.TextBox1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.CheckPassword)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextPassword)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(581, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(353, 417)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 417)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(145, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlatas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlatas.ResumeLayout(False)
        Me.pnlctl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents pnlatas As Panel
    Friend WithEvents pnlctl As Panel
    Friend WithEvents btnmin As Button
    Friend WithEvents btnmax As Button
    Friend WithEvents btncls As Button
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckPassword As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
