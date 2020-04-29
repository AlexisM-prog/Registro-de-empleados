Public Class Empleado : Inherits Persona


    Protected _sueldoPorMes As Integer
    Protected _cargo As Integer ' 0: Administrativo, 1: Gerente, 2: Operario
    Protected _activo As Boolean
    Public Property sueldoPorMes As Integer
        Get
            Return _sueldoPorMes
        End Get
        Set(value As Integer)
            _sueldoPorMes = value
        End Set
    End Property
    Public Property cargo As String
        Get
            Return _cargo
        End Get
        Set(value As String)

            If value Is Nothing Then
                Throw New ArgumentNullException(NameOf(value))
            Else
                Select Case value
                    Case "Administrativo"
                        _cargo = 0
                    Case "Gerente"
                        _cargo = 1
                    Case "Operario"
                        _cargo = 2
                End Select

            End If

        End Set
    End Property
    Public Property activo As Boolean
        Get
            Return _activo
        End Get
        Set(value As Boolean)
            _activo = value
        End Set
    End Property
    Public Sub New(PNom As String, SNom As String, PApe As String, SApe As String,
                   CI As String, calle As String, nroPuerta As Integer, esBis As Boolean,
                   sueldoPorMes As Integer, cargo As Integer, activo As Boolean, telefonos As String())
        MyBase.New(PNom, SNom, PApe, SApe, CI, calle, nroPuerta, esBis, telefonos)
        Me.sueldoPorMes = sueldoPorMes
        Me.cargo = cargo
        Me.activo = activo
    End Sub
    Overridable Function getProfesionComoString() As String
        Return ""
    End Function
End Class
