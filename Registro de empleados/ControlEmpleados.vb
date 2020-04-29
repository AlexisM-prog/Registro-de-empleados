Imports LogicaDatos

Public Class ControlEmpleados
    Private empleados As List(Of Empleado)

    Public Sub New()
        Me.empleados = New List(Of Empleado)

    End Sub

    ' si uno de los parametors de tomarDatosEmpleados es nothing es porque no se usa esa variable por lo tanto no hay probleamas
    Function testearDatosEmpleado(PNom As String, SNom As String, PApe As String, SApe As String,
                  CI As String, calle As String, nroPuerta As String,
                  sueldoPorMes As String, cargo As Integer, telefonos As String()) As Boolean()
        '(PNom, SNom, PApe, SApe, Nothing, calle, nroPuerta, sueldoPorMes, cargo, telefonos)
        Dim problemas() As Boolean = {
            True, True, True, True,' PNom, SNom, PApe, SApe,
            True, True, True, True} ' ci, calle, nroPuerta, sueldoPorMes

        If PNom = Nothing Or PNom <> "" Then
            problemas(0) = False
        End If
        If SNom = Nothing Or SNom <> "" Then
            problemas(1) = False
        End If
        If PApe Is Nothing Or PApe <> "" Then
            problemas(2) = False
        End If
        If SApe Is Nothing Or SApe <> "" Then
            problemas(3) = False
        End If
        If CI Is Nothing Or (CI <> "" And tomarEmpleadoConCedula(CI) Is Nothing) Then
            problemas(4) = False
        End If
        If calle Is Nothing Or calle <> "" Then
            problemas(5) = False
        End If
        If nroPuerta Is Nothing Or nroPuerta <> "" Then
            problemas(6) = False
        End If
        If sueldoPorMes Is Nothing Or sueldoPorMes <> "" Then
            problemas(7) = False
        End If
        Return problemas
    End Function
    Private Function eliminarEmpleado(pos As Integer)
        Me.empleados.RemoveAt(pos)
    End Function
    Function modificarEmpleado(pos As Integer, PNom As String, SNom As String, PApe As String, SApe As String,
                  CI As String, calle As String, nroPuerta As String, esBis As Boolean,
                  sueldoPorMes As String, cargo As String, activo As Boolean, telefonos As String())
        Me.eliminarEmpleado(pos)
        Me.agregarEmpleado(PNom, SNom, PApe, SApe, CI, calle, nroPuerta,
                           esBis, sueldoPorMes, cargo, activo, telefonos)
    End Function

    Function agregarEmpleado(PNom As String, SNom As String, PApe As String, SApe As String,
                  CI As String, calle As String, nroPuerta As String, esBis As Boolean,
                  sueldoPorMes As String, cargo As String, activo As Boolean, telefonos As String())

        Select Case cargo
            Case "Administrativo"
                Me.empleados.Add(
                    New Administrativo(PNom, SNom, PApe, SApe,
                        CI, calle, Integer.Parse(nroPuerta), esBis,
                        Integer.Parse(sueldoPorMes) + 1.27, 0, activo, telefonos)
                )

            Case "Gerente"

                Me.empleados.Add(
                    New Gerente(PNom, SNom, PApe, SApe,
                        CI, calle, Integer.Parse(nroPuerta), esBis,
                        Integer.Parse(sueldoPorMes) + 1.97, 1, activo, telefonos)
                )

            Case "Operario"
                Me.empleados.Add(
                    New Operario(PNom, SNom, PApe, SApe,
                        CI, calle, Integer.Parse(nroPuerta), esBis,
                        Integer.Parse(sueldoPorMes) + 1.38, 2, activo, telefonos)
                )
        End Select
    End Function
    Function modEmpleado(empleado As Empleado) As Boolean
        Dim modificicadoAnterior As Boolean = False
        For Each e As Empleado In empleados
            If e.CI = empleado.CI And Not modificicadoAnterior Then
                e = empleado
                modificicadoAnterior = True
            End If
        Next
        Return modificicadoAnterior
    End Function
    Function tomarEmpleado(pos As Integer) As Empleado
        If pos < empleados.Count And pos > -1 Then
            Return empleados(pos)
        End If
    End Function
    Function nroDeEmpleados() As Integer
        Return empleados.Count
    End Function
    Function tomarEmpleadoConCedula(cedula As String) As Object
        Dim resp As Object = Nothing
        For Each empleado As Empleado In empleados
            If cedula = empleado.CI Then
                resp = empleado
            End If
        Next
        Return resp
    End Function
    Function perteneceAlStringSegundo(pequeño As String, mayor As String, plus As Integer) As Boolean
        ' Verifica que en una posición especifica del string mas pequeño coincide con una parte del grande
        Return Mid(mayor, plus, pequeño.Count + plus) = pequeño
    End Function
End Class
