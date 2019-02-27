<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkExpress = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblChanger = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtLast)
        Me.GroupBox1.Controls.Add(Me.txtFirst)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDeposit)
        Me.GroupBox2.Controls.Add(Me.txtNum)
        Me.GroupBox2.Controls.Add(Me.chkExpress)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Installation Options"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.lblBalance)
        Me.GroupBox3.Controls.Add(Me.lblDeposit)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblAdditional)
        Me.GroupBox3.Controls.Add(Me.lblBase)
        Me.GroupBox3.Controls.Add(Me.lblChanger)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 171)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Charges"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(270, 148)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(133, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate Charges"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of panels:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Deposit amount:"
        '
        'chkExpress
        '
        Me.chkExpress.AutoSize = True
        Me.chkExpress.Location = New System.Drawing.Point(23, 77)
        Me.chkExpress.Name = "chkExpress"
        Me.chkExpress.Size = New System.Drawing.Size(138, 17)
        Me.chkExpress.TabIndex = 4
        Me.chkExpress.Text = "Express installation (5%)"
        Me.chkExpress.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Base charge for 2 panels:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Additional panels:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total cost:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Deposit amount:"
        '
        'lblChanger
        '
        Me.lblChanger.AutoSize = True
        Me.lblChanger.Location = New System.Drawing.Point(20, 140)
        Me.lblChanger.Name = "lblChanger"
        Me.lblChanger.Size = New System.Drawing.Size(70, 13)
        Me.lblChanger.TabIndex = 5
        Me.lblChanger.Text = "Balance due:"
        '
        'lblBase
        '
        Me.lblBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBase.Location = New System.Drawing.Point(154, 35)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(117, 19)
        Me.lblBase.TabIndex = 6
        '
        'lblAdditional
        '
        Me.lblAdditional.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdditional.Location = New System.Drawing.Point(154, 58)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(117, 19)
        Me.lblAdditional.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(154, 89)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(117, 19)
        Me.lblTotal.TabIndex = 8
        '
        'lblDeposit
        '
        Me.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeposit.Location = New System.Drawing.Point(154, 116)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(117, 19)
        Me.lblDeposit.TabIndex = 9
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Location = New System.Drawing.Point(154, 139)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(117, 19)
        Me.lblBalance.TabIndex = 10
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(119, 23)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(65, 20)
        Me.txtNum.TabIndex = 5
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(119, 49)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(65, 20)
        Me.txtDeposit.TabIndex = 6
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(84, 17)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 7
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(84, 54)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(257, 17)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(282, 31)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(282, 134)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 395)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents chkExpress As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents lblBase As Label
    Friend WithEvents lblChanger As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalc As Button
End Class
