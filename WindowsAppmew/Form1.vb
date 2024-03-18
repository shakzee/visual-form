Public Class female


    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = firstname.Text
        Dim surname As String = lastname.Text
        Dim email As String = userEmail.Text
        Dim password As String = userPassword.Text
        Dim confirmPassword As String = Me.confirmPassword.Text
        Dim male As String = userGender.Text
        Dim female As String = userfemalGender.Text
        'validate fields
        If name = "" Or surname = "" Or email = "" Or password = "" Or confirmPassword = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Critical, "Error")
        ElseIf password <> confirmPassword Then
            MsgBox("Password do not match", MsgBoxStyle.Critical, "Error")
        Else
            MsgBox("Welcome " & name & " " & surname & " " & "You have successfully registered", MsgBoxStyle.Information, "Success")
        End If








    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub surname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub mytextbox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles userPassword.TextChanged

    End Sub

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles userEmail.TextChanged

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub firstname_TextChanged(sender As Object, e As EventArgs) Handles firstname.TextChanged

    End Sub

    Private Sub confirmPassword_TextChanged(sender As Object, e As EventArgs) Handles confirmPassword.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles userGender.CheckedChanged

    End Sub
End Class
