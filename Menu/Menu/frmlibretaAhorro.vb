Public Class frmlibretaAhorro
    'procedimientos
    Private monto As Integer
    Private Sub activarControles()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub desactivarControles()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        TextBox1.Clear()
        TextBox2.Clear()
        ListDepositos.Items.Clear()
        ListRetiros.Items.Clear()
    End Sub

    Private Sub frmlibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliente As String
        cliente = TextBox1.Text
        monto = Val(TextBox2.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("monto mayor a 0", "Ingresar monto correcto ", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub mostrarsaldo()
        TextBox2.Text = monto

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
End Class