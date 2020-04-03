Imports System.IClonable
Public Class Empleado
    Implements ICloneable
    Public Shared ReadOnly Gerente As Integer = 0,
        Operario As Integer = 1,
        Administrativo As Integer = 2

    Private PNom As String
    Private SNom As String
    Private PApe As String
    Private SApe As String
    Private CI As String
    Private calle As String
    Private nroPuerta As Integer
    Private esBis As Boolean
    Private sueldoPorMes As Integer
    Private tipoEmpleado As Integer
    Private telefonos As String()
    Private activo As Boolean
    Function setActivo(activo As Boolean)
        Me.activo = activo
    End Function
    Function setPNom(PNom As String)
        Me.PNom = PNom
    End Function
    Function setSNom(SNom As String)
        Me.SNom = SNom
    End Function
    Function setPApe(PApe As String)
        Me.PApe = PApe
    End Function
    Function setSApe(SApe As String)
        Me.SApe = SApe
    End Function
    Function setCI(CI As String)
        Me.CI = CI
    End Function
    Function setCalle(calle As String)
        Me.calle = calle
    End Function
    Function setNroPuerta(nroPuerta As Integer)
        Me.nroPuerta = nroPuerta
    End Function
    Function setEsBis(esBis As Boolean)
        Me.esBis = esBis
    End Function
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
    Function setTipoEmpleado(tipoEmpleado As Integer)
        Me.tipoEmpleado = tipoEmpleado
    End Function
    Function setTelefonos(telefonos As String())
        Me.telefonos = telefonos
    End Function
    Function getPNom() As String
        Return Me.PNom
    End Function
    Function getSNom() As String
        Return Me.SNom
    End Function
    Function getPApe() As String
        Return Me.PApe
    End Function
    Function getSApe() As String
        Return Me.SApe
    End Function
    Function getCI() As String
        Return Me.CI
    End Function
    Function getCalle() As String
        Return Me.calle
    End Function
    Function getNroPuerta() As Integer
        Return Me.nroPuerta
    End Function
    Function getEsBis() As Boolean
        Return Me.esBis
    End Function
    Function getSueldoPorMes() As Integer
        Return Me.sueldoPorMes
    End Function
    Function getTipoEmpleado() As Integer
        Return Me.tipoEmpleado
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
    Function getActivo()
        Return Me.activo
    End Function
    Public Function Clone() As Object Implements ICloneable.Clone
        Return DirectCast(Me.MemberwiseClone, Empleado)
    End Function
End Class
