Imports LogicaDatos

Public Class VistaMenuAgregarEmpleado
    Inherits VistaMenuGeneral
    Private vAnterior As VistaMenuRegistroEmpleado

    Public Sub New(vistaMenuPrincipal As VistaMenuRegistroEmpleado)
        Me.vAnterior = vistaMenuPrincipal
    End Sub
    Function mostrarMenu()
        Dim telefonosAux As List(Of String) = New List(Of String)
        Dim telefonoAux = ""
        Dim existeCedulaEnEmpleados As Boolean = False

        Console.Clear()
        Me.imprimirTitulo("AGREGA EMPLEADO")

        Console.WriteLine("Cual será su funcion:")
        Console.WriteLine("0) Gerente")
        Console.WriteLine("1) Operario")
        Console.WriteLine("2) Administrativo")
        Console.Write("Elige opcion:")
        Select Case Integer.Parse(Console.ReadLine())
            Case 0
                empAux = New Gerente()
            Case 1
                empAux = New Operario()
            Case 2
                empAux = New Administrativo()
        End Select

        Console.Write("Ingresa el primer nombre:")
        Me.empAux.PNom = Console.ReadLine()

        Console.Write("Ingresa el segundo nombre:")
        Me.empAux.SNom = Console.ReadLine()

        Console.Write("Ingresa el primer apellido:")
        Me.empAux.PApe = Console.ReadLine()

        Console.Write("Ingresa el segundo apellido:")
        Me.empAux.SApe = Console.ReadLine()

        Console.Write("Ingresa la cedula:")
        Do
            If existeCedulaEnEmpleados Then ' la primera vez no se ejecuta porque siempre es false
                Console.Write("Ingresa la cedula (que no haya sido ingresado antes):")
            End If

            ciAux = Console.ReadLine()
            existeCedulaEnEmpleados = False
            For Each empl As Empleado In empleados
                If empl.CI.Equals(ciAux) Then
                    existeCedulaEnEmpleados = True
                End If
            Next
            If Not existeCedulaEnEmpleados Then
                Me.empAux.CI = ciAux
            End If
        Loop While existeCedulaEnEmpleados


        Console.Write("Ingresa la calle donde reside:")
        Me.empAux.calle = Console.ReadLine()

        Console.Write("Ingresa el nro de puerta de su residencia:")
        Me.empAux.nroPuerta = Integer.Parse(Console.ReadLine())

        Console.Write("Ingresa el nro de puerta es bis ('s' si es):")
        Me.empAux.esBis = Console.ReadLine().Equals("s")

        Console.Write("Ingresa el sueldo por mes:")
        Me.empAux.sueldoPorMes = Console.ReadLine()

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

        Me.empAux.telefonos = telefonosAux.ToArray()
        Me.empAux.activo = True

        empleados.Add(empAux.Clone())
        empAux = New Empleado()
        vAnterior.mostrarMenu()
    End Function
End Class
