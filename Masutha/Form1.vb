Option Explicit On
Option Strict On
'MASUTHA AMPFARISAHO 202228633 4A L3
Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'QUESTION 3.11
        Clear()
    End Sub

    Sub Clear()
        'CLEARING ALL THE INPUTS 
        Dim intAnswer As Integer
        intAnswer = MessageBox.Show("Are you sure you want to clear all", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If intAnswer = DialogResult.OK Then
            txtEmail.Clear()
            txtName.Clear()
            txtSurname.Clear()
            mskContact.Text = ""
            radBlack.Checked = False
            radHeineken.Checked = False
            chkCoolerBox.Checked = False
            chkGlass.Checked = False
            chkOpener.Checked = False

        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'QUESTION 3.11
        terminate()
    End Sub

    Sub terminate()
        'TERMINATING THE PROGRAM 
        Dim answer As Integer
        answer = MessageBox.Show("Are you sure you want to close", "CLEAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DECLARING VARIABLES GLOBAL 



    End Sub

    Private Sub btnShowPromotion_Click(sender As Object, e As EventArgs) Handles btnShowPromotion.Click
        CalculatingTotal()
        lstOutput.Items.Add("Total" & CalculatingTotal().ToString("C2").PadLeft(25))
        ' lstOutput.Items.Add("Total:".PadRight(25))
    End Sub
    Function Vat() As Decimal
        Const decVat As Decimal = 0.15D
    End Function

    Function CalculatingTotal() As Decimal
        Dim decTotal As Decimal
        Const Black As Decimal = 320D
        Const heineken As Decimal = 360D
        Const Opener As Decimal = 50D
        Const Coolerbox As Decimal = 150D
        Const BeerGlass As Decimal = 100D
        Dim BlackandOpener As Decimal
        Dim BlackandCoolerBox As Decimal
        Dim BlackandBeerGlass As Decimal
        Dim HeinekenandOpener As Decimal
        Dim HeinekenandCoolerBox As Decimal
        Dim HeinekenandBeerGlass As Decimal

        If radBlack.Checked = True Then
            If chkOpener.Checked = True Then
                BlackandOpener = Black + Opener
            End If
            If chkCoolerBox.Checked = True Then
                BlackandCoolerBox = Black + Coolerbox
            End If
            If chkGlass.Checked = True Then
                BlackandBeerGlass = Black + BeerGlass
            End If
            decTotal = BlackandOpener + BlackandCoolerBox + BlackandBeerGlass
        ElseIf radHeineken.Checked = True Then
            If chk Then

            End If
            Return decTotal
    End Function


End Class
