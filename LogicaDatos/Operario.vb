Public Class Operario
    Inherits Empleado

    Overloads Property sueldoPorMes As Integer
        Set(value As Integer)
            _sueldoPorMes = value * 1.38 ' 100% + 38%
        End Set
        Get
            Return _sueldoPorMes
        End Get
    End Property
    Overrides Function getProfesionComoString() As String
        Return "Operario"
    End Function
End Class
