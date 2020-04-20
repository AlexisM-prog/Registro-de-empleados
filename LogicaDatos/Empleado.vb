Imports System.IClonable
Public Class Empleado : Inherits Persona
    Implements ICloneable


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
    Public Property cargo As Integer
        Get
            Return _cargo
        End Get
        Set(value As Integer)
            _cargo = value
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
                   sueldoPorMes As Integer, cargo As Integer, activo As Boolean)
        MyBase.New(PNom, SNom, PApe, SApe, CI, calle, nroPuerta, esBis)
        Me.sueldoPorMes = sueldoPorMes
        Me.cargo = cargo
        Me.activo = activo
    End Sub
    Overridable Function getProfesionComoString() As String
        Return ""
    End Function
    Public Function Clone() As Object Implements ICloneable.Clone
        Return DirectCast(Me.MemberwiseClone, Empleado)
    End Function
End Class
