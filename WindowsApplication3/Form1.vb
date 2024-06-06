Public Class Form1
    Dim num, x As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ListBox1.ClearSelected()
        'num = Val(TextBox1.Text)
        If ComboBox1.SelectedIndex = 1 Then
            For a = 1 To 10
                ListBox1.Items.Add(1 & "*" & a & "=" & 1 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next
        End If
        If ComboBox1.SelectedIndex = 2 Then
            For a = 1 To 10
                ListBox1.Items.Add(2 & "*" & a & "=" & 2 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next

        End If
        If ComboBox1.SelectedIndex = 3 Then
            For a = 1 To 10
                ListBox1.Items.Add(3 & "*" & a & "=" & 3 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next

        End If
        If ComboBox1.SelectedIndex = 4 Then
            For a = 1 To 10
                ListBox1.Items.Add(4 & "*" & a & "=" & 4 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next

        End If
        If ComboBox1.SelectedIndex = 5 Then
            For a = 1 To 10
                ListBox1.Items.Add(5 & "*" & a & "=" & 5 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next

        End If
        If ComboBox1.SelectedIndex = 6 Then
            For a = 1 To 10
                ListBox1.Items.Add(6 & "*" & a & "=" & 6 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next

        End If
        If ComboBox1.SelectedIndex = 7 Then
            For a = 1 To 10
                ListBox1.Items.Add(7 & "*" & a & "=" & 7 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next
        End If
        If ComboBox1.SelectedIndex = 8 Then
            For a = 1 To 10
                ListBox1.Items.Add(8 & "*" & a & "=" & 8 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next

        End If
        If ComboBox1.SelectedIndex = 9 Then
            For a = 1 To 10
                ListBox1.Items.Add(9 & "*" & a & "=" & 9 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next

        End If
        If ComboBox1.SelectedIndex = 10 Then
            For a = 1 To 10
                ListBox1.Items.Add(10 & "*" & a & "=" & 10 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next

        End If

        If ComboBox1.SelectedIndex = 11 Then
            MsgBox("Por favor escriba el numero en el cuadro de texto", MsgBoxStyle.Critical, "Nuevo número")

            Label1.Visible = True
            TextBox1.Visible = True
            TextBox1.Focus()
            Button3.Visible = True
            Button1.Visible = False


        End If
        ComboBox1.Visible = False
        Button1.Visible = False

        '  ListBox1.ClearSelected()

        ' Size = New Size(599, 412)

    End Sub


   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Seleccione un numero")
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ComboBox1.Items.Add("6")
        ComboBox1.Items.Add("7")
        ComboBox1.Items.Add("8")
        ComboBox1.Items.Add("9")
        ComboBox1.Items.Add("10")
        ComboBox1.Items.Add("Otro número")
        ComboBox1.SelectedIndex = 0

    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Visible = True
        ListBox1.ClearSelected()
        num = Val(TextBox1.Text)
        For a = 1 To 10
            ListBox1.Items.Add(num & "*" & a & "=" & TextBox1.Text * a)

        Next
        Label1.Visible = False
        TextBox1.Visible = False
        Button3.Visible = False
        Size = New Size(599, 412)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ComboBox1.Visible = True
        Button1.Visible = True
        ComboBox1.SelectedIndex = 0
        Size = New Size(339, 412)
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        TextBox1.Clear()




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RadioButton1.Checked Then
            For a = 1 To 10
                ListBox1.Items.Add(11 & "*" & a & "=" & 11 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)

            Next
        End If
        If RadioButton2.Checked Then
            For a = 1 To 10
                ListBox1.Items.Add(12 & "*" & a & "=" & 12 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)
            Next
        End If
        If RadioButton3.Checked Then
            For a = 1 To 10
                ListBox1.Items.Add(13 & "*" & a & "=" & 13 * a)
                ListBox1.Visible = True
                Size = New Size(599, 412)
            Next
        End If
    End Sub

   
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Close()

    End Sub

    
    
End Class
