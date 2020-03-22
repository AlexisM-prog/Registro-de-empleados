Imports LogicaRegistro
Imports System.Threading

Public Class VentanaMostrar
    Private empleados As List(Of Empleado)
    Private opcion As Integer
    Private espera As Integer
    Private empAux As Empleado
    Sub New()
        empleados = New List(Of Empleado)
        espera = 2000
        opcion = 0
        administrarPagos()
    End Sub
    Function administrarPagos()

        Do
            Console.Clear()
            Console.WriteLine("ADMINISTRADOR DE EMPLEADOS")
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

        Me.empAux = New Empleado()

        Dim telefonosAux As List(Of String) = New List(Of String)
        Dim telefonoAux = ""
        Do
            Console.Clear()
            Console.WriteLine("REGISTRO DE EMPLEADOS")
            Console.WriteLine("1) Ingresar")
            Console.WriteLine("2) Modificar")
            Console.WriteLine("2) Eliminar")
            Console.WriteLine("4) Atras")
            Console.Write("Ingresa opcion:")
            opcion = Integer.Parse(Console.ReadLine())
            Select Case opcion
                Case 1
                    Console.Clear()
                    Console.Write("Ingresa el primer nombre:")
                    Me.empAux.setPNom(Console.ReadLine())

                    Console.Write("Ingresa el segundo nombre:")
                    Me.empAux.setSNom(Console.ReadLine())

                    Console.Write("Ingresa el primer apellido:")
                    Me.empAux.setPApe(Console.ReadLine())

                    Console.Write("Ingresa el segundo apellido:")
                    Me.empAux.setSApe(Console.ReadLine())

                    Console.Write("Ingresa la cedula:")
                    Me.empAux.setCI(Console.ReadLine())

                    Console.Write("Ingresa la calle donde reside:")
                    Me.empAux.setCalle(Console.ReadLine())

                    Console.Write("Ingresa el nro de puerta de su residencia:")
                    Me.empAux.setNroPuerta(Integer.Parse(Console.ReadLine()))

                    Console.Write("Ingresa el nro de puerta es bis ('Si' si es):")
                    Me.empAux.setEsBis(Console.ReadLine().Equals("Si"))

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
                            Console.Write("Ingresa otro numero de telefono de contacto (N si no tiene mas telefonos):")
                        End If

                        telefonoAux = Console.ReadLine()
                        If Not telefonoAux.Equals("N") Then
                            telefonosAux.Add(telefonoAux)
                        End If
                    Loop While Not telefonoAux.Equals("N")

                    Me.empAux.setTelefonos(telefonosAux.ToArray())
                    empleados.Add(empAux)
                    empAux = New Empleado()
                Case 2
                    Console.WriteLine("Ingresa cedula del que quieres modificar:")
                    Dim ci = Console.ReadLine()
                    For Each empl In empleados
                        If empl.getCI().Equals(ci) Then

                        End If
                    Next
                Case 3

                Case 4x
                Case Else
                    Console.WriteLine("Opcion Incorrecta")
                    Thread.Sleep(espera)
                    administrarPagos()
            End Select
        Loop While Not opcion = 4
    End Function
    Function importeSueldos()

        Console.Clear()
        Console.WriteLine("//////////////////////////")
        Console.WriteLine("Importe a Empleados")
        Console.WriteLine("//////////////////////////")
        For i As Integer = 0 To empleados.Count - 1
            empAux = empleados(i)
            Console.Write(empAux.getPNom() & " " & empAux.getSNom() & " ")
            Console.Write(empAux.getPApe() & " " & empAux.getSApe() & " ")
            Console.Write(empAux.getCI() & " " & empAux.getCalle() & " ")
            Console.Write(empAux.getNroPuerta() & " " & empAux.getEsBis() & " ")
            Console.Write(empAux.getSueldoPorMes() & " " & empAux.getTipoEmpleado() & " ")
            Console
        Next
        Console.Write("Enter para volver:")
        Console.Read()
    End Function
    Function ingresarNumeroDeContacto()

    End Function

End Class
