Public Class Gerente
    Inherits Empleado

    Public Property Departamento As String

    Public Sub New(ByVal nombre As String, ByVal salario As Decimal, ByVal departamento As String)
        MyBase.New(nombre, salario)
        Me.Departamento = departamento
    End Sub

    Public Overrides Function ObtenerDatos() As String
        Return $"Nombre: {Nombre} - Salario: {Salario} - Departamento: {Departamento}"
    End Function
End Class

