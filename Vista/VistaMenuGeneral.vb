
Imports LogicaDatos



Public Class VistaMenuGeneral
    Public tiempoEsperaPorDefecto As Integer
    Public opcion As Integer
    Friend empAux As Empleado
    Friend ciAux As String
    Public Shared empleados As List(Of Empleado)

    Sub New()
        tiempoEsperaPorDefecto = 2000
        opcion = 0
        Console.SetWindowSize(140, 30)
        empleados = New List(Of Empleado)
    End Sub
    Function imprimirTitulo(titulo As String)
        Console.BackgroundColor = ConsoleColor.Red
        Console.ForegroundColor = ConsoleColor.White
        Console.CursorLeft() = 20
        Console.WriteLine(titulo)
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Yellow
    End Function

End Class
