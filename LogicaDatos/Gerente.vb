Public Class Gerente
    Inherits Empleado


    Overloads Property sueldoPorMes As Integer
        Set(value As Integer)
            _sueldoPorMes = value * 1.97 '100% + 97%
        End Set
        Get
            Return _sueldoPorMes
        End Get
    End Property
    Overrides Function getProfesionComoString() As String
        Return "Gerente"
    End Function
End Class
