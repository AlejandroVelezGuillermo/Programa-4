Public Class Empleado
    Public Property Nombre As String
    Public Property Salario As Decimal

    Public Sub New(ByVal nombre As String, ByVal salario As Decimal)
        Me.Nombre = nombre
        Me.Salario = salario
    End Sub

    Public Overridable Function ObtenerDatos() As String
        Return $"Nombre: {Nombre} - Salario: {Salario}"
    End Function
End Class

