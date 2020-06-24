Imports System.ComponentModel

Public Class Entrega_Bolsa_Solidaria
    Dim id As String = 15
    Dim numero As Integer
    Private usuarios(100, 8) As String

    Private Sub imprimiraldata(ii)
        DataGridView1.Rows.Add(usuarios(ii, 1), usuarios(ii, 0), usuarios(ii, 2), usuarios(ii, 3), usuarios(ii, 5), usuarios(ii, 6), usuarios(ii, 7), usuarios(ii, 4))
    End Sub
    Private Sub reset()
        MaskedTextBox1.Clear()
        txtcatintegrantes.Clear()
        txtnombre.Clear()
        Label8.Text = ""
        TextBox1.Clear()
        TextBox3.Clear()

    End Sub
    Private Sub restablecer()
        txtcatintegrantes.Enabled = True
        txtnombre.Enabled = True

        TextBox1.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles E.Click

        Dim idusuario, longitud As String

        Dim valor As Integer
        valor = 0

        idusuario = MaskedTextBox1.Text
        longitud = idusuario.Length

        For a = 0 To 100 Step 1
            If idusuario = usuarios(a, 0) Then

                valor = 1
            End If

        Next
        If longitud = id Then

            MessageBox.Show("si es valido", "si se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)







            If valor = 1 Then
                MessageBox.Show("EL USUARIO YA EXISTE", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                usuarios(numero, 0) = idusuario
                usuarios(numero, 1) = txtnombre.Text
                usuarios(numero, 2) = txtcatintegrantes.Text
                usuarios(numero, 3) = ComboBox1.SelectedItem


                usuarios(numero, 4) = Label8.Text
                usuarios(numero, 5) = TextBox1.Text
                usuarios(numero, 6) = ComboBox2.SelectedItem
                usuarios(numero, 7) = TextBox3.Text


                imprimiraldata(numero)



            End If


        ElseIf longitud > id Then
            MessageBox.Show("es mayor que lo permitido", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("es menor que lo permitido", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        numero = numero + 1
        reset()
    End Sub

    Private Sub txtcatintegrantes_TextChanged(sender As Object, e As EventArgs) Handles txtcatintegrantes.TextChanged

        Dim bolsa As String
        Dim integrante As Integer

        integrante = Val(txtcatintegrantes.Text)
        If integrante <= 2 Then
            bolsa = "2 arros,1 aceite,2 maseca,3 maiz,1 frijoles"
            tipobolsa.Text = bolsa
            Label8.Text = "regular"
        ElseIf integrante > 2 And integrante <= 5 Then
            bolsa = "3 arros,2 aceite,3 maseca,4 maiz,5 frijoles"
            tipobolsa.Text = bolsa
            Label8.Text = "mediana"
        Else
            bolsa = "4 arros,4 aceite,4 maseca,4 maiz,7 frijoles"
            tipobolsa.Text = bolsa
            Label8.Text = "Grande"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_MouseHover(sender As Object, e As EventArgs) Handles MaskedTextBox1.MouseHover
        ToolTip1.SetToolTip(MaskedTextBox1, "Ingrese la identidad del usuario")
        ToolTip1.ToolTipTitle = "Ingresar la identidad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub MaskedTextBox1_Validating(sender As Object, e As CancelEventArgs) Handles MaskedTextBox1.Validating
        If Val(MaskedTextBox1.Text) - Int(Val(MaskedTextBox1.Text)) = 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese el id")
        End If
    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        restablecer()
    End Sub
End Class