Public Class frmlibretaAhorro
    'procedimientos
    Private monto As Integer
    Dim id As String = 13

    Private usuarios(100, 6) As String
    Private Sub activarControles()
        txtnombreusuario.Enabled = False
        txtedad.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub desactivarControles()
        txtnombreusuario.Enabled = True
        txtedad.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        txtnombreusuario.Clear()
        txtedad.Clear()
        ListDepositos.Items.Clear()
        ListRetiros.Items.Clear()
    End Sub

    Private Sub frmlibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer

        numero = 0

        ' usuarios(0, 0) = "0318200300249"
        ' usuarios(0, 1) = "Miguelito"
        ' usuarios(0, 2) = "17"
        ' usuarios(0, 3) = "Honduras"
        ' usuarios(0, 4) = "prefiero no decirlo"
        ' usuarios(0, 5) = "20000"
        'usuarios(0, 6) = "15%"


        ' txtidentidad.Text = usuarios(0, 0)
        ''txtnombreusuario.Text = usuarios(0, 1)
        'txtedad.Text = usuarios(0, 2)
        'txtpais.Text = usuarios(0, 3)
        'txtsexo.Text = usuarios(0, 4)
        'txt.Text = usuarios(0, 5)
        'txtdescuento.Text = usuarios(0, 6)




        Dim idusuario, longitud As String

        idusuario = txtidentidad.Text
        longitud = idusuario.Length


        If longitud = id Then


            MessageBox.Show("si es valido", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For i = 0 To (0) Step 1
                usuarios(i, 0) = idusuario
                usuarios(i, 1) = InputBox("Ingrese el nombre" & (i + 1), "Registro")
                usuarios(i, 2) = InputBox("Ingrese el edad" & (i + 1), "Registro")
                usuarios(i, 3) = InputBox("Ingrese la pais" & (i + 1), "Registro")
                usuarios(i, 4) = InputBox("Ingrese la sexo" & (i + 1), "Registro")
                usuarios(i, 5) = InputBox("Ingrese la saldo" & (i + 1), "Registro")
                usuarios(i, 6) = InputBox("Ingrese la descuento" & (i + 1), "Registro")


            Next
        ElseIf longitud > id Then
            MessageBox.Show("es mayor que lo permitido", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("es menor que lo permitido", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




        'cliente = txtnombreusuario.Text
        'monto = Val(txtedad.Text)
        'If (monto > 0) Then
        'activarControles()
        'Else
        'MessageBox.Show("monto mayor a 0", "Ingresar monto correcto ", MessageBoxButtons.OK)
        'End If
    End Sub
    Private Sub mostrarsaldo()
        TextBox3.Text = monto

    End Sub
    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("ingrese un monto" & mensaje, "Operacion")
        mostrarsaldo()
        Return cantidad
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim deposito As Double
        deposito = leer("depositar")

        monto += deposito
        ListDepositos.Items.Add(deposito)
        mostrarsaldo()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > monto) Then
            MessageBox.Show("saldo insuficiente", "deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retiro
            ListRetiros.Items.Add(retiro)
            mostrarsaldo()
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)





    End Sub

    Private Sub txtidentidad_TextChanged(sender As Object, e As EventArgs) Handles txtidentidad.TextChanged



    End Sub

    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim idusuario, longitud, numero As String

        idusuario = TextBox1.Text
        longitud = idusuario.Length
        numero = 0

        If longitud = id Then

            MessageBox.Show("si es valido ss", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)

            While idusuario <> usuarios(numero, 0)
                numero += 1
            End While


            For i = 0 To (0) Step 1
                txtidentidad.Text = usuarios(numero, 0)
                txtnombreusuario.Text = usuarios(numero, 1)
                txtedad.Text = usuarios(numero, 2)
                txtpais.Text = usuarios(numero, 3)
                txtsexo.Text = usuarios(numero, 4)
                txt.Text = usuarios(numero, 5)
                txtdescuento.Text = usuarios(numero, 6)

            Next
        ElseIf longitud > id Then
            MessageBox.Show("es mayor que lo permitido", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("es menor que lo permitido", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        'cliente = txtnombreusuario.Text
        monto = Val(txtedad.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("monto mayor a 0", "Ingresar monto correcto ", MessageBoxButtons.OK)
        End If
    End Sub
End Class