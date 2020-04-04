Public Class Administrativo
    Inherits Empleado

    Overloads Property sueldoPorMes As Integer
        Set(value As Integer)
            _sueldoPorMes = value * 1.27 ' 100% + 27%
        End Set
        Get
            Return _sueldoPorMes
        End Get
    End Property

    Overrides Function getProfesionComoString() As String
        Return "Administrativo"
    End Function
End Class
