Public Class Form1
    Dim Pesos, Dollar, Yen As Double
    Dim operation1, operation2 As Double
    Dim convert As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        operation1 = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        operation2 = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Pesos" And
                ComboBox2.Text = "Dollars" Then
            operation1 = TextBox2.Text

            convert = operation1 * 0.017
            TextBox1.Text = convert

        End If
        If ComboBox1.Text = "Dollars" And
                ComboBox2.Text = "Pesos" Then
            operation1 = TextBox2.Text

            convert = operation1 * 58.32
            TextBox1.Text = convert

        End If
        If ComboBox1.Text = "Pesos" And
                ComboBox2.Text = "Yen" Then
            operation1 = TextBox2.Text

            convert = operation1 * 2.57
            TextBox1.Text = convert

        End If
        If ComboBox1.Text = "Dollars" And
                ComboBox2.Text = "Yen" Then
            operation1 = TextBox2.Text

            convert = operation1 * 149.75
            TextBox1.Text = convert

        End If
        If ComboBox1.Text = "Yen" And
                ComboBox2.Text = "Pesos" Then
            operation1 = TextBox2.Text

            convert = operation1 * 0.39
            TextBox1.Text = convert

        End If
        If ComboBox1.Text = "Yen" And
                ComboBox2.Text = "Dollars" Then
            operation1 = TextBox2.Text

            convert = operation1 * 0.0067
            TextBox1.Text = convert

        End If
        If ComboBox1.Text = "Pesos" And
                ComboBox2.Text = "Pesos" Then
            operation1 = TextBox2.Text

            convert = operation1 * 1
            TextBox1.Text = convert

        End If
        If ComboBox1.Text = "Dollars" And
                ComboBox2.Text = "Dollars" Then
            operation1 = TextBox2.Text

            convert = operation1 * 1
            TextBox1.Text = convert

        End If
        If ComboBox1.Text = "Yen" And
                ComboBox2.Text = "Yen" Then
            operation1 = TextBox2.Text

            convert = operation1 * 1
            TextBox1.Text = convert

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
