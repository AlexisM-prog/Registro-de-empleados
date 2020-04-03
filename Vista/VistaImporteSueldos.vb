Imports System.Threading
Imports LogicaDatos

Public Class VistaImporteSueldos
    Inherits VistaMenuGeneral
    Private vAnterior As VistaMenuPrincipal
    Private filaTabla As Integer() = {1, 11, 22, 34, 46, 57,
                                    79, 92, 100, 115, 132}
    Public Sub New(vistaMenuPrincipal As VistaMenuPrincipal)
        Me.vAnterior = vistaMenuPrincipal
    End Sub

    Function mostrarMenu()

        Dim gastoTotalEnEmpleados = 0
        Console.Clear()
        Me.imprimirTitulo("IMPORTE A EMPLEADOS")
        Console.WriteLine()
        Console.CursorLeft() = filaTabla(0)
        Console.Write("PNom")
        Console.CursorLeft() = filaTabla(1)
        Console.Write("| SNom")
        Console.CursorLeft() = filaTabla(2)
        Console.Write("| PApe")
        Console.CursorLeft() = filaTabla(3)
        Console.Write("| SApe")
        Console.CursorLeft() = filaTabla(4)
        Console.Write("| CI")
        Console.CursorLeft() = filaTabla(5)
        Console.Write("| Calle")
        Console.CursorLeft() = filaTabla(6)
        Console.Write("| NroPuerta")
        Console.CursorLeft() = filaTabla(7)
        Console.Write("| EsBis")
        Console.CursorLeft() = filaTabla(8)
        Console.Write("| SueldoPorMes")
        Console.CursorLeft() = filaTabla(9)
        Console.Write("| TipoDeEmpleado")
        Console.CursorLeft() = filaTabla(10)
        Console.Write("| Activo")
        Console.CursorTop() = 3 ' Si pongo Console.WriteLine() da problemas
        For i As Integer = 0 To empleados.Count - 1
            empAux = empleados(i)
            Console.CursorLeft() = filaTabla(0)
            Console.Write(empAux.getPNom())
            Console.CursorLeft() = filaTabla(1)
            Console.Write("| " & empAux.getSNom())
            Console.CursorLeft() = filaTabla(2)
            Console.Write("| " & empAux.getPApe())
            Console.CursorLeft() = filaTabla(3)
            Console.Write("| " & empAux.getSApe())
            Console.CursorLeft() = filaTabla(4)
            Console.Write("| " & empAux.getCI())
            Console.CursorLeft() = filaTabla(5)
            Console.Write("| " & empAux.getCalle())
            Console.CursorLeft() = filaTabla(6)
            Console.Write("| " & empAux.getNroPuerta())
            Console.CursorLeft() = filaTabla(7)
            Console.Write("| ")
            If empAux.getEsBis() Then
                Console.Write("Si")
            Else
                Console.Write("No")
            End If
            Console.CursorLeft() = filaTabla(8)
            Console.Write("| " & empAux.getSueldoPorMes())
            Console.CursorLeft() = filaTabla(9)
            Console.Write("| ")
            Console.Write(empAux.getTipoEmpleadoComoString())
            Console.CursorLeft() = filaTabla(10)
            Console.Write("| ")
            If empAux.getActivo() Then
                Console.Write("Si")
            Else
                Console.Write("No")
            End If
            Console.WriteLine()
        Next
        Console.WriteLine()
        Console.CursorLeft() = filaTabla(8) - 5 ' para que quede alineado con sueldopormes
        For Each empl As Empleado In empleados
            If empl.getActivo() Then
                gastoTotalEnEmpleados += empl.getSueldoPorMes()
            End If
        Next
        Console.WriteLine("Gasto: " & gastoTotalEnEmpleados)
        Console.Write("Enter para volver:")
        Console.ReadLine()
        vAnterior.mostrarMenu()
    End Function
End Class
