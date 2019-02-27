Imports System.Text.RegularExpressions

Public Class Form1
    Const BASE As Double = 2000
    Const MULTI As Double = 300
    Const EXPRESS_RATE As Double = 1.05

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDeposit.Clear()
        txtFirst.Clear()
        txtLast.Clear()
        txtNum.Clear()
        txtPhone.Clear()
        lblAdditional.Text = ""
        lblBalance.Text = ""
        lblBase.Text = ""
        lblDeposit.Text = ""
        lblTotal.Text = ""
        chkExpress.Checked = False
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declare local variables
        Dim numPanels As Integer
        Dim firstName As String
        Dim lastName As String
        Dim phoneNo As String
        Dim deposit As Double
        Dim express As Boolean = chkExpress.Checked
        Dim flag As Boolean = True
        If Check_First(txtFirst.Text) Then
            firstName = txtFirst.Text
        Else
            MessageBox.Show("Invalid Entry")
            Return
        End If
        If Check_Last(txtLast.Text) Then
            lastName = txtLast.Text
        Else
            MessageBox.Show("Invalid Entry")
            Return
        End If
        If Check_Phone(txtPhone.Text) Then
            phoneNo = txtPhone.Text
        Else
            MessageBox.Show("Invalid Entry")
            Return
        End If
        If Check_Num(txtNum.Text) Then
            numPanels = Convert.ToInt32(txtNum.Text)
        Else
            MessageBox.Show("Invalid Entry")
            Return
        End If
        If Check_Deposit(txtDeposit.Text) Then
            deposit = Convert.ToDouble(txtDeposit.Text)
        Else
            MessageBox.Show("Invalid Entry")
            Return
        End If

        lblBase.Text = BASE.ToString("c")
        lblAdditional.Text = Calc_Add(numPanels).ToString("c")
        lblTotal.Text = Calc_Total(numPanels, express).ToString("c")
        lblDeposit.Text = deposit.ToString("c")

        'print appropriate value depending on deposit
        If deposit >= Calc_Total(numPanels, express) Then
            lblChanger.Text = "Refund:"
            lblBalance.Text = -Calc_Deposit(deposit, numPanels, express).ToString("c")
        Else
            lblBalance.Text = Calc_Deposit(deposit, numPanels, express).ToString("c")
        End If

    End Sub

    'calculate additional
    Function Calc_Add(ByVal n As Integer) As Double
        Dim finVal = (n - 2) * MULTI
        Return finVal
    End Function

    'calculate deposit or refund
    Function Calc_Deposit(ByVal d As Double, ByVal n As Integer, ByVal b As Boolean) As Double
        Dim finVal = Calc_Total(n, b) - d
        Return finVal
    End Function

    'calculate total cost
    Function Calc_Total(ByVal n As Integer, ByVal b As Boolean) As Double
        Dim finVal = BASE + Calc_Add(n)

        If b Then
            finVal *= EXPRESS_RATE
        End If

        Return finVal
    End Function
    'check valid first name
    Function Check_First(ByVal s As String) As Boolean
        Dim finVal = Regex.IsMatch(s, "^[A-Za-z]+$")

        If Not finVal Then
            txtFirst.Text = "Enter Name"
        End If

        Return finVal
    End Function

    'check valid last name
    Function Check_Last(ByVal s As String) As Boolean
        Dim finVal = Regex.IsMatch(s, "^[A-Za-z]+$")

        If Not finVal Then
            txtLast.Text = "Enter Name"
        End If

        Return finVal
    End Function

    'check valid phone
    Function Check_Phone(ByVal s As String) As Boolean
        Dim finVal = Regex.IsMatch(s, "^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$")

        If Not finVal Then
            txtPhone.Text = "Enter Phone"
        End If

        Return finVal
    End Function

    'check valid integer
    Function Check_Num(ByVal s As String) As Boolean
        Dim finVal = Regex.IsMatch(s, "^[0-9]+$")

        If Not finVal Then
            txtNum.Text = "Enter Integer"
        Else
            Dim temp As Integer = Convert.ToInt32(s)
            If Not (temp <= 1000 And temp > 0) Then
                finVal = False
            End If
        End If

        Return finVal
    End Function

    'check valid decimal
    Function Check_Deposit(ByVal s As String) As Boolean
        Dim finVal = Regex.IsMatch(s, "^[0-9]*(\.[0-9]{1,2})?$")

        If Not finVal Then
            txtDeposit.Text = "Enter Decimal"
        End If

        Return finVal
    End Function

End Class
