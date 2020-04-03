Imports System.Threading

Public Class VistaMenuRegistroEmpleado
    Inherits VistaMenuGeneral
    Private vAnterior As VistaMenuPrincipal
    Public vAgregarEmpleado As VistaMenuAgregarEmpleado
    Public vModificarEmpleado As VistaMenuModificarEmpleado

    Public Sub New(vistaMenuPrincipal As VistaMenuPrincipal)
        Me.vAnterior = vistaMenuPrincipal
        vAgregarEmpleado = New VistaMenuAgregarEmpleado(Me)
        vModificarEmpleado = New VistaMenuModificarEmpleado(Me)
    End Sub

    Friend Sub mostrarMenu()
        Console.Title() = "Registro Empleado"
        Console.Clear()
        Me.vAnterior.imprimirTitulo("REGISTRO DE EMPLEADOS")
        Console.WriteLine("1) Ingresar")
        Console.WriteLine("2) Modificar")
        Console.WriteLine("3) Atras")
        Console.Write("Elige opcion:")
        Try
            opcion = Integer.Parse(Console.ReadLine())
        Catch ex As Exception
            opcion = 0
        End Try
        Select Case opcion
            Case 1
                vAgregarEmpleado.mostrarMenu()
            Case 2
                vModificarEmpleado.mostrarMenu()
            Case 3
                vAnterior.mostrarMenu()
            Case Else
                Console.WriteLine("Opcion Incorrecta")
                Thread.Sleep(tiempoEsperaPorDefecto)
                mostrarMenu()
        End Select
    End Sub
End Class
