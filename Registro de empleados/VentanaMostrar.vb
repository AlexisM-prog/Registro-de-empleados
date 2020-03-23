Imports LogicaRegistro
Imports System.Threading


Public Class VentanaMostrar
    Private empleados As List(Of Empleado)
    Private opcion As Integer
    Private espera As Integer
    Private empAux As Empleado
    Private filaTablas As Integer() = {1, 11, 22, 34, 46,
                                        57, 79, 92, 100, 115}
    Sub New()
        empleados = New List(Of Empleado)
        Me.empAux = New Empleado()
        espera = 2000
        opcion = 0

        Console.Title() = "Registro Empleado"
        Console.SetWindowSize(131, 30)

        administrarPagos()
    End Sub
    Function administrarPagos()

        Do
            Console.Clear()
            Me.imprimirTitulo("ADMINISTRADOR DE EMPLEADOS")
            Console.WriteLine("1) Registro de empleados")
            Console.WriteLine("2) Importe total a pagar por concepto de sueldos.")
            Console.WriteLine("3) Salir")
            Console.Write("Ingresa opcion:")
            Try
                opcion = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                opcion = 4
            End Try
            Select Case opcion
                Case 1
                    regristroEmpleado()
                Case 2
                    importeSueldos()
                Case 3
                Case Else
                    Console.WriteLine("Opcion Incorrecta")
                    Thread.Sleep(espera)
            End Select
        Loop While Not opcion = 3
    End Function
    Function regristroEmpleado()
        Do


            Console.Clear()
            Me.imprimirTitulo("REGISTRO DE EMPLEADOS")
            Console.WriteLine("1) Ingresar")
            Console.WriteLine("2) Modificar")
            Console.WriteLine("3) Eliminar")
            Console.WriteLine("4) Atras")
            Console.Write("Ingresa opcion:")
            Try
                opcion = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                opcion = 0
            End Try
            Select Case opcion
                Case 1
                    agregarEmpleado()
                Case 2
                    modificarEmpleado()
                Case 3
                    eliminarEmpleado()
                Case 4
                Case Else
                    Console.WriteLine("Opcion Incorrecta")
                    Thread.Sleep(espera)
            End Select
        Loop While Not opcion = 4
    End Function
    Function modificarEmpleado()
        Dim ci As String
        Console.Clear()
        Console.Write("Ingresa cedula del que quieres modificar:")
        ci = Console.ReadLine()
        For i As Integer = 0 To empleados.Count - 1
            If empleados(i).getCI().Equals(ci) Then
                Me.imprimirTitulo(empleados(i).getPNom() & " " &
                                  empleados(i).getSNom() & ", " &
                                  empleados(i).getPApe() & " " &
                                  empleados(i).getSApe() & " " & "(" &
                                  empleados(i).getTipoEmpleadoComoString())


                Console.WriteLine()
            End If
        Next
        Console.Write("Elije opcion:")
        opcion = Console.Read()


    End Function
    Function eliminarEmpleado()
        Dim encontrado As Boolean = False
        Dim ci As String

        Do
            encontrado = False
            Console.Write("Ingresa cedula del que quieres eliminar:")
            ci = Console.ReadLine()
            For Each empl As Empleado In empleados
                If empl.getCI().Equals(ci) Then
                    Me.empAux = empl
                    encontrado = True
                End If
            Next
            If Not encontrado Then
                Console.Write("No he encontrado al empleado, quiere reintentar? (S para reintentar):")
                If Not Console.Read().Equals("S") Then
                    encontrado = True
                End If
            Else
                empleados.Remove(Me.empAux)
                Console.WriteLine("Eliminado correctamente")
                Thread.Sleep(Me.espera)
            End If
        Loop While Not encontrado
    End Function
    Function agregarEmpleado()
        Dim telefonosAux As List(Of String) = New List(Of String)
        Dim telefonoAux = ""
        empAux = New Empleado()

        Console.Clear()
        Console.Write("Ingresa el primer nombre:")
        Me.empAux.setPNom(Console.ReadLine())

        Console.Write("Ingresa el segundo nombre:")
        Me.empAux.setSNom(Console.ReadLine())

        Console.Write("Ingresa el primer apellido:")
        Me.empAux.setPApe(Console.ReadLine())

        Console.Write("Ingresa el segundo apellido:")
        Me.empAux.setSApe(Console.ReadLine())

        'verificar repeticion de cedula
        Console.Write("Ingresa la cedula:")
        Me.empAux.setCI(Console.ReadLine())

        Console.Write("Ingresa la calle donde reside:")
        Me.empAux.setCalle(Console.ReadLine())

        Console.Write("Ingresa el nro de puerta de su residencia:")
        Me.empAux.setNroPuerta(Integer.Parse(Console.ReadLine()))

        Console.Write("Ingresa el nro de puerta es bis ('s' si es):")
        Me.empAux.setEsBis(Console.ReadLine().Equals("s"))

        Console.WriteLine("Cual será su funcion:")
        Console.WriteLine("0) Gerente")
        Console.WriteLine("1) Operario")
        Console.WriteLine("2) Administrativo")
        Console.Write("Opcion:")
        Me.empAux.setTipoEmpleado(Integer.Parse(Console.ReadLine()))

        Console.Write("Ingresa el sueldo por mes:")
        Me.empAux.setSueldoPorMes(Console.ReadLine())

        Do
            If telefonosAux.Count = 0 Then
                Console.Write("Ingresa un numero de telefono de contacto:")
            Else
                Console.Write("Ingresa otro numero de telefono de contacto (n si no tiene mas telefonos):")
            End If

            telefonoAux = Console.ReadLine()
            If Not telefonoAux.Equals("n") Then
                telefonosAux.Add(telefonoAux)
            End If
        Loop While Not telefonoAux.Equals("n")

        Me.empAux.setTelefonos(telefonosAux.ToArray())
        empleados.Add(empAux.Clone())
        empAux = New Empleado()
    End Function
    Function importeSueldos()

        'falta que de los numeros relacionados con una cuenta

        Console.Clear()
        Me.imprimirTitulo("Importe a Empleados")
        Console.WriteLine()
        Console.CursorLeft() = filaTablas(0)
        Console.Write("PNom")
        Console.CursorLeft() = filaTablas(1)
        Console.Write("| SNom")
        Console.CursorLeft() = filaTablas(2)
        Console.Write("| PApe")
        Console.CursorLeft() = filaTablas(3)
        Console.Write("| SApe")
        Console.CursorLeft() = filaTablas(4)
        Console.Write("| CI")
        Console.CursorLeft() = filaTablas(5)
        Console.Write("| Calle")
        Console.CursorLeft() = filaTablas(6)
        Console.Write("| NroPuerta")
        Console.CursorLeft() = filaTablas(7)
        Console.Write("| EsBis")
        Console.CursorLeft() = filaTablas(8)
        Console.Write("| SueldoPorMes")
        Console.CursorLeft() = filaTablas(9)
        Console.Write("| TipoDeEmpleado")
        Console.CursorTop() = 3
        For i As Integer = 0 To empleados.Count - 1
            empAux = empleados(i)
            Console.CursorLeft() = filaTablas(0)
            Console.Write(empAux.getPNom())
            Console.CursorLeft() = filaTablas(1)
            Console.Write("| " & empAux.getSNom())
            Console.CursorLeft() = filaTablas(2)
            Console.Write("| " & empAux.getPApe())
            Console.CursorLeft() = filaTablas(3)
            Console.Write("| " & empAux.getSApe())
            Console.CursorLeft() = filaTablas(4)
            Console.Write("| " & empAux.getCI())
            Console.CursorLeft() = filaTablas(5)
            Console.Write("| " & empAux.getCalle())
            Console.CursorLeft() = filaTablas(6)
            Console.Write("| " & empAux.getNroPuerta())
            Console.CursorLeft() = filaTablas(7)
            Console.Write("| ")
            If empAux.getEsBis Then
                Console.Write("Si")
            Else
                Console.Write("No")
            End If
            Console.CursorLeft() = filaTablas(8)
            Console.Write("| " & empAux.getSueldoPorMes())
            Console.CursorLeft() = filaTablas(9)
            Console.Write("| ")
            Console.Write(empAux.getTipoEmpleadoComoString())
            Console.WriteLine()
        Next
        Console.WriteLine()
        Console.Write("Enter para volver:")
        Console.Read()
    End Function
    Function imprimirTitulo(titulo As String)
        Console.BackgroundColor = ConsoleColor.Red
        Console.ForegroundColor = ConsoleColor.White
        Console.CursorLeft() = 20
        Console.WriteLine(titulo)
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Yellow
    End Function
End Class
