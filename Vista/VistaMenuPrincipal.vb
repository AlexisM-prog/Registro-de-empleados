Imports System.Threading
Imports LogicaDatos

Public Class VistaMenuPrincipal
    Inherits VistaMenuGeneral
    Public vRegistroEmpleado As VistaMenuRegistroEmpleado
    Public vImporteSueldos As VistaImporteSueldos
    Sub New()
        vRegistroEmpleado = New VistaMenuRegistroEmpleado(Me)
        vImporteSueldos = New VistaImporteSueldos(Me)
        tiempoEsperaPorDefecto = 2000
        mostrarMenu()
    End Sub



    Function mostrarMenu()

        Console.Clear()
        Me.imprimirTitulo("ADMINISTRADOR DE EMPLEADOS")
        Console.WriteLine("1) Registro de empleados")
        Console.WriteLine("2) Importe total a pagar por concepto de sueldos.")
        Console.WriteLine("3) Salir")
        Console.Write("Elige opcion:")
        opcion = Integer.Parse(Console.ReadLine())
        Select Case opcion
            Case 1
                vRegistroEmpleado.mostrarMenu()
            Case 2
                vImporteSueldos.mostrarMenu()
            Case 3

            Case Else
                Console.WriteLine("Opcion Incorrecta")
                Thread.Sleep(tiempoEsperaPorDefecto)
                mostrarMenu()
        End Select

    End Function
End Class
