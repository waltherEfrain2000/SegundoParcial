Public Class arreglos


    Private mcomputadoras(,3) As String
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
                mcomputadoras(i, 0) = InputBox("ingrese la marca N." & (i + 1), "Registro")
                mcomputadoras(i, 1) = InputBox("ingrese la marca N." & (i + 1), "Registro")
                mcomputadoras(i, 2) = InputBox("ingrese la marca N." & (i + 1), "Registro")
                mcomputadoras(i, 3) = InputBox("ingrese la marca N." & (i + 1), "Registro")

            Next
        End Sub

        Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
            Dim marca As String
            marca = txtmarca.text
            For i = 0 To (cantcomputadoras - 1) Step 1
                If (mcomputadoras(i, 0) = marca) Then
        Next
        End Sub

End Class