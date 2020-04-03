Imports System.IClonable
Public Class Empleado
    Implements ICloneable
    Public Shared ReadOnly Gerente As Integer = 0,
        Operario As Integer = 1,
        Administrativo As Integer = 2

    Property PNom As String
    Property SNom As String
    Property PApe As String
    Property SApe As String
    Property CI As String
    Property calle As String
    Property nroPuerta As Integer
    Property esBis As Boolean
    Property sueldoPorMes As Integer
    Property tipoEmpleado As Integer
    Property telefonos As String()
    Property activo As Boolean
    Function setSueldoPorMes(_sueldoPorMes As Integer)
        Select Case tipoEmpleado
            Case 0 'Es Gerente
                _sueldoPorMes *= 1.97 '1 + 0.97
            Case 1 'Es Operario
                _sueldoPorMes *= 1.38
            Case 2 'Es administrativo
                _sueldoPorMes *= 1.27
        End Select
        Me.sueldoPorMes = _sueldoPorMes
    End Function

    Function getTipoEmpleadoComoString() As String
        Select Case Me.tipoEmpleado
            Case 0
                Return "Gerente"
            Case 1
                Return "Operario"
            Case 2
                Return "Administrativo"
        End Select
    End Function
    Public Function Clone() As Object Implements ICloneable.Clone
        Return DirectCast(Me.MemberwiseClone, Empleado)
    End Function
End Class
