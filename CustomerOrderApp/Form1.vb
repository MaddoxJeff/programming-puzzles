Imports System.Data.OleDb

Public Class Form1

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub ButtonCalc_Click(sender As Object, e As EventArgs) Handles ButtonCalc.Click

        Try
            Dim firstNum As Double = CDbl(TextBoxX.Text)
            Dim secondNum As Double = CDbl(TextBoxY.Text)
            Dim thirdNum As Double = CDbl(TextBoxZ.Text)
            Dim Vol = firstNum * secondNum * thirdNum

            TextBoxVol.Text = CStr(Vol)
        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers")
        Catch ex As Exception

            MessageBox.Show("An unkown error occured")

        End Try


    End Sub

    Private Sub ButtonPrice_Click(sender As Object, e As EventArgs) Handles ButtonPrice.Click

        Try
            Dim lines As String() = IO.File.ReadAllLines("C:\Users\Jeff\Documents\widgetParts.txt")
            Dim newLine As String = lines(1)
            If RadioButtonA.Checked Then
                newLine = lines(1)
            ElseIf RadioButtonB.Checked Then
                newLine = lines(3)
            ElseIf RadioButtonC.Checked Then
                newLine = lines(5)
            End If
            Dim price As Double = CDbl(newLine)
            Dim Vol As Double = CDbl(TextBoxVol.Text)
            Dim newPrice As Double = Vol * price
            TextBoxPrice.Text = CStr(newPrice)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Jeff\Documents\CustomerOrders.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into Customers([InvoiceID],[FirstName],[LastName],[State],[City],[Phone],[Volume],[Price]) Values (?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("InvoiceID", CType(TextBoxInvoice.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(TextBoxFName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(TextBoxLName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("State", CType(TextBoxState.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("City", CType(TextBoxCity.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone", CType(TextBoxPhone.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Volume", CType(TextBoxVol.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Price", CType(TextBoxPrice.Text, String)))

        Dim FILE_NAME As String = "C:\Users\Jeff\Documents\receipt.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.WriteLine(TextBoxFName.Text + " " + TextBoxLName.Text)
            objWriter.WriteLine(TextBoxCity.Text + ", " + TextBoxState.Text)
            objWriter.WriteLine("The volume of your widget is: " + TextBoxVol.Text)
            objWriter.WriteLine("The price of your widget is $" + TextBoxPrice.Text)
            objWriter.Close()
            MessageBox.Show("Text written to file")
        Else
            MessageBox.Show("File does not exist")
 
        End If
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBoxFName.Clear()
            TextBoxLName.Clear()
            TextBoxState.Clear()
            TextBoxCity.Clear()
            TextBoxPhone.Clear()
            TextBoxInvoice.Clear()
            TextBoxVol.Clear()
            TextBoxPrice.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
