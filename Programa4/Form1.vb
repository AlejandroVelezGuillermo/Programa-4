Public Class Form1
    Private Sub btnCrearEmpleado_Click(sender As Object, e As EventArgs)
        Dim nombre As String = txtNombre.Text
        Dim salario As Decimal = Decimal.Parse(txtSalario.Text)

        Dim empleado As New Empleado(nombre, salario)

        MessageBox.Show(empleado.ObtenerDatos())
    End Sub

    Private Sub btnCrearGerente_Click(sender As Object, e As EventArgs)
        Dim nombre As String = txtNombre.Text
        Dim salario As Decimal = Decimal.Parse(txtSalario.Text)
        Dim departamento As String = txtDepartamento.Text

        Dim gerente As New Gerente(nombre, salario, departamento)

        MessageBox.Show(gerente.ObtenerDatos())
    End Sub
End Class

