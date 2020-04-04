Imports System.IClonable
Public Class Empleado
    Implements ICloneable

    Protected _sueldoPorMes As Integer

    Property PNom As String
    Property SNom As String
    Property PApe As String
    Property SApe As String
    Property CI As String
    Property calle As String
    Property nroPuerta As Integer
    Property esBis As Boolean
    Public Property sueldoPorMes As Integer
        Get
            Return _sueldoPorMes
        End Get
        Set
            _sueldoPorMes = Value
        End Set
    End Property
    Property telefonos As String()
    Property activo As Boolean

    Overridable Function getProfesionComoString() As String
        Return "NULL"
    End Function
    Public Function Clone() As Object Implements ICloneable.Clone
        Return DirectCast(Me.MemberwiseClone, Empleado)
    End Function
End Class
