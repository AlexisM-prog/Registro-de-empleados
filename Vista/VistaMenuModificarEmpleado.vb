Imports System.Threading

Public Class VistaMenuModificarEmpleado
    Inherits VistaMenuGeneral
    Private vAnterior As VistaMenuRegistroEmpleado

    Public Sub New(vistaMenuPrincipal As VistaMenuRegistroEmpleado)
        Me.vAnterior = vistaMenuPrincipal
    End Sub
    Function mostrarMenu()
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
                    Console.WriteLine("5) Cambiar estado de actividad")
                    Console.WriteLine("6) Volver")
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
                            Me.imprimirTitulo("CAMBIAR RESIDENCIA")
                            Console.Write("Ingresa la calle donde reside:")
                            Me.empAux.setCalle(Console.ReadLine())

                            Console.Write("Ingresa el nro de puerta de su residencia:")
                            Me.empAux.setNroPuerta(Integer.Parse(Console.ReadLine()))

                            Console.Write("Ingresa el nro de puerta es bis ('s' si es):")
                            Me.empAux.setEsBis(Console.ReadLine().Equals("s"))
                        Case 3
                            Console.Clear()
                            Me.imprimirTitulo("CAMBIAR EMPLEO")
                            Console.WriteLine("Cual será su funcion:")
                            Console.WriteLine("0) Gerente")
                            Console.WriteLine("1) Operario")
                            Console.WriteLine("2) Administrativo")
                            Console.Write("Elige opcion:")
                            Me.empAux.setTipoEmpleado(Integer.Parse(Console.ReadLine()))
                        Case 4
                            Console.Clear()
                            Me.imprimirTitulo("CAMBIAR SALARIO")
                            Console.Write("Ingresa el sueldo por mes (se agregara un incremento segun oficio):")
                            Me.empAux.setSueldoPorMes(Console.ReadLine())
                        Case 5
                            Console.Clear()
                            Me.imprimirTitulo("CAMBIAR ESTADO ACTIVIDAD")
                            Console.Write("El estado actual de " & Me.empAux.getPNom() & " es ")
                            If Me.empAux.getActivo() Then
                                Console.WriteLine("activo")
                            Else
                                Console.WriteLine("inactivo")
                            End If
                            Console.Write("Cambiar estado a actividad(a: activo, i:inactivo):")
                            Me.empAux.setActivo(Console.ReadLine().Equals("a"))
                        Case 6
                        Case Else
                            Console.WriteLine("Opcion Incorrecta")
                            Thread.Sleep(tiempoEsperaPorDefecto)
                    End Select
                    Me.mostrarMenu()
                Loop While Not opcion = 5
            End If
        Next
        vAnterior.mostrarMenu()
    End Function
End Class
