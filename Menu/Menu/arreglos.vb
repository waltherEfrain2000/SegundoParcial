Public Class arreglos


    Private mcomputadoras(,) As String
    Private cantcomputadoras As Integer
        Private index As Byte
        Private encuentra As Boolean = False


        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim computadoras(3) As String

            computadoras(0) = "Toshiba"
            computadoras(1) = "Dell"
            computadoras(2) = "Asus"
            computadoras(3) = "Mac"

            For i = 0 To (computadoras.Length - 1) Step 1
                ComboBox1.Items.Add(computadoras(i))

            Next
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Dim precio(3) As Integer
            precio(0) = 22500
            precio(1) = 21000
            precio(2) = 29000
            precio(3) = 42000
            For i = 0 To (precio.Length - 1) Step 1
                ComboBox2.Items.Add(precio(i))

            Next
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Dim cantidad As Integer
            Dim comp() As String
            cantidad = Val(TextBox1.Text)

            ReDim comp(cantidad)

            For i = 0 To (cantidad) Step 1
                comp(i) = InputBox("ingrese la marca de la pc", "Ingreso")
            Next
            For j = 0 To cantidad Step 1
                ComboBox3.Items.Add(comp(j))
            Next
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        End Sub

        Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        End Sub

        Private Sub frmarreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
            cantcomputadoras = Val(TextBox2.Text)
            ReDim mcomputadoras(cantcomputadoras, 3)

            '3x3= comienza contar desde
            For i = 0 To (cantcomputadoras - 1) Step 1
            mcomputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
            mcomputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
            mcomputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
            mcomputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")
            index = i

        Next
        End Sub

        Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim marca As String
        marca = txtMarca.Text.ToLower

        For i = 0 To (cantcomputadoras - 1) Step 1
            If (mcomputadoras(i, 0).ToLower = marca) Then
                txtModelo.Text = mcomputadoras(i, 1)
                txtPrecio.Text = mcomputadoras(i, 2)
                txtCantidad.Text = mcomputadoras(i, 3)
                encuentra = True
                txtvender.Enabled = True
                Button8.Enabled = True
                Button9.Enabled = True
            End If
        Next
        If (encuentra = False) Then
            MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMarca.Clear()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim cantVender, stock As Integer

        cantVender = Val(txtvender.Text)
        stock = mcomputadoras(index, 3)

        If cantVender > stock Then
            MessageBox.Show("El stock es insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf cantVender = stock Then
            MessageBox.Show("Stock vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcantidad.Text = "0"

        Else
            mcomputadoras(index, 3) = stock - cantVender
            MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcantidad.Text = cantVender - stock

        End If
    End Sub
End Class