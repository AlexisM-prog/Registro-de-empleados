Imports LogicaRegistro
Imports System.Threading


Public Class VentanaMostrar
    Private empleados As List(Of Empleado)
    Private opcion As Integer
    Private tiempoEsperaPorDefecto As Integer

    Private empAux As Empleado
    Private ciAux As String

    Private filaTabla As Integer() = {1, 11, 22, 34, 46,
                                        57, 79, 92, 100, 115}
    Sub New()
        empleados = New List(Of Empleado)
        Me.empAux = New Empleado()
        tiempoEsperaPorDefecto = 2000
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
            Console.Write("Elige opcion:")
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
                    Thread.Sleep(tiempoEsperaPorDefecto)
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
            Console.Write("Elige opcion:")
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
                    Thread.Sleep(tiempoEsperaPorDefecto)
            End Select
        Loop While Not opcion = 4
    End Function
    Function modificarEmpleado()
        Console.Clear()
        Console.Write("Ingresa cedula del que quieres modificar:")
        ciAux = Console.ReadLine()
        For i As Integer = 0 To empleados.Count - 1
            empAux = empleados(i)
            If empAux.getCI().Equals(ciAux) Then

                Do
                    Console.Clear()
                    Me.imprimirTitulo("QUE MODIFICO DE " & empAux.getPNom() & " " &
                                  empAux.getSNom() & ", " &
                                  empAux.getPApe() & " " &
                                  empAux.getSApe() & " " & "(" &
                                  empAux.getTipoEmpleadoComoString() & ")?")
                    Console.WriteLine("1) Nombre")
                    Console.WriteLine("2) Residencia")
                    Console.WriteLine("3) Empleo")
                    Console.WriteLine("4) Salario")
                    Console.WriteLine("5) Volver")
                    Console.Write("Elige opcion:")
                    opcion = Integer.Parse(Console.ReadLine())

                    Select Case opcion
                        Case 1
                            Console.Clear()
                            Me.imprimirTitulo("MODIFICAR NOMBRE")
                            Console.Write("Ingrese primer nombre:")
                            empAux.setPNom(Console.ReadLine())

                            Console.Write("Ingrese segundo nombre:")
                            empAux.setSNom(Console.ReadLine())

                            Console.Write("Ingrese primer apellido:")
                            empAux.setPApe(Console.ReadLine())

                            Console.Write("Ingrese segundo nombre:")
                            empAux.setSApe(Console.ReadLine())
                        Case 2
                            Console.Clear()
                            Me.imprimirTitulo("MODIFICAR RESIDENCIA")
                            Console.Write("Ingresa la calle donde reside:")
                            Me.empAux.setCalle(Console.ReadLine())

                            Console.Write("Ingresa el nro de puerta de su residencia:")
                            Me.empAux.setNroPuerta(Integer.Parse(Console.ReadLine()))

                            Console.Write("Ingresa el nro de puerta es bis ('s' si es):")
                            Me.empAux.setEsBis(Console.ReadLine().Equals("s"))
                        Case 3
                            Console.Clear()
                            Me.imprimirTitulo("MODIFICAR EMPLEO")
                            Console.WriteLine("Cual será su funcion:")
                            Console.WriteLine("0) Gerente")
                            Console.WriteLine("1) Operario")
                            Console.WriteLine("2) Administrativo")
                            Console.Write("Elige opcion:")
                            Me.empAux.setTipoEmpleado(Integer.Parse(Console.ReadLine()))
                        Case 4
                            Console.Clear()
                            Me.imprimirTitulo("MODIFICAR SALARIO")
                            Console.Write("Ingresa el sueldo por mes (se agregara un incremento segun oficio):")
                            Me.empAux.setSueldoPorMes(Console.ReadLine())
                        Case 5
                        Case Else
                            Console.WriteLine("Opcion Incorrecta")
                            Thread.Sleep(tiempoEsperaPorDefecto)
                    End Select
                Loop While Not opcion = 5
            End If
        Next
    End Function
    Function eliminarEmpleado()
        Dim encontrado As Boolean = False
        Do
            encontrado = False
            Console.Clear()
            Me.imprimirTitulo("ELIMINAR EMPLEADO")
            Console.Write("Ingresa cedula del que quieres eliminar:")
            ciAux = Console.ReadLine()

            ' busca en empleados una persona con la misma cedula
            For Each empl As Empleado In empleados
                If empl.getCI().Equals(ciAux) Then
                    Me.empAux = empl
                    encontrado = True
                End If
            Next
            If encontrado Then ' si lo encuentra lo elimina
                empleados.Remove(Me.empAux)
                Console.WriteLine("Eliminado correctamente")
                Thread.Sleep(Me.tiempoEsperaPorDefecto)
            Else ' si no lo encuentra da la opcion de reintentar 
                Console.Write("No he encontrado al empleado, quiere reintentar? ('s' para reintentar):")
                If Not Console.Read().Equals("s") Then
                    encontrado = True
                End If
            End If
        Loop While Not encontrado
    End Function
    Function agregarEmpleado()
        Dim telefonosAux As List(Of String) = New List(Of String)
        Dim telefonoAux = ""
        Dim existeCedulaEnEmpleados As Boolean = False
        empAux = New Empleado()

        Console.Clear()
        Me.imprimirTitulo("AGREGA EMPLEADO")
        Console.Write("Ingresa el primer nombre:")
        Me.empAux.setPNom(Console.ReadLine())

        Console.Write("Ingresa el segundo nombre:")
        Me.empAux.setSNom(Console.ReadLine())

        Console.Write("Ingresa el primer apellido:")
        Me.empAux.setPApe(Console.ReadLine())

        Console.Write("Ingresa el segundo apellido:")
        Me.empAux.setSApe(Console.ReadLine())

        Console.Write("Ingresa la cedula:")
        Do
            If existeCedulaEnEmpleados Then ' la primera vez no se ejecuta porque siempre es false
                Console.Write("Ingresa la cedula (que no haya sido ingresado):")
            End If

            ciAux = Console.ReadLine()

            For Each empl As Empleado In empleados
                If empl.getCI().Equals(ciAux) Then
                    existeCedulaEnEmpleados = True
                End If
            Next
            If Not existeCedulaEnEmpleados Then
                Me.empAux.setCI(ciAux)
            End If
        Loop While existeCedulaEnEmpleados


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
        Console.Write("Elige opcion:")
        Me.empAux.setTipoEmpleado(Integer.Parse(Console.ReadLine()))

        Console.Write("Ingresa el sueldo por mes:")
        Me.empAux.setSueldoPorMes(Console.ReadLine())

        Do
            If telefonosAux.Count = 0 Then
                Console.Write("Ingresa un numero de telefono de contacto:")
            Else
                Console.Write("Ingresa otro numero de telefono de contacto ('n' si no tiene mas telefonos):")
            End If

            telefonoAux = Console.ReadLine()
            If Not telefonoAux.Equals("n") Or telefonosAux.Count = 0 Then
                telefonosAux.Add(telefonoAux)
            End If
        Loop While Not telefonoAux.Equals("n") Or telefonosAux.Count = 0

        Me.empAux.setTelefonos(telefonosAux.ToArray())
        empleados.Add(empAux.Clone())
        empAux = New Empleado()
    End Function
    Function importeSueldos()

        'falta que de los numeros relacionados con una cuenta

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
            If empAux.getEsBis Then
                Console.Write("Si")
            Else
                Console.Write("No")
            End If
            Console.CursorLeft() = filaTabla(8)
            Console.Write("| " & empAux.getSueldoPorMes())
            Console.CursorLeft() = filaTabla(9)
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
