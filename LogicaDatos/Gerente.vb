Public Class Gerente
    Inherits Empleado

    Public Sub New(PNom As String, SNom As String, PApe As String, SApe As String,
                  CI As String, calle As String, nroPuerta As Integer, esBis As Boolean,
                  sueldoPorMes As Integer, cargo As Integer, activo As Boolean, telefonos As String())
        MyBase.New(PNom, SNom, PApe, SApe, CI, calle, nroPuerta, esBis, sueldoPorMes, cargo, activo, telefonos)


    End Sub
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
