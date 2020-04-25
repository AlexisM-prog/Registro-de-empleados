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
                  sueldoPorMes As String, cargo As Integer, activo As Boolean, telefonos As String())
        Me.eliminarEmpleado(pos)
        Me.agregarEmpleado(PNom, SNom, PApe, SApe, CI, calle, nroPuerta,
                           esBis, sueldoPorMes, cargo, activo, telefonos)
    End Function

    Function agregarEmpleado(PNom As String, SNom As String, PApe As String, SApe As String,
                  CI As String, calle As String, nroPuerta As String, esBis As Boolean,
                  sueldoPorMes As String, cargo As Integer, activo As Boolean, telefonos As String())

        Select Case cargo
            Case 0
                Me.empleados.Add(
                    New Administrativo(PNom, SNom, PApe, SApe,
                        CI, calle, Integer.Parse(nroPuerta), esBis,
                        Integer.Parse(sueldoPorMes), cargo, activo, telefonos)
                )

            Case 1

                Me.empleados.Add(
                    New Gerente(PNom, SNom, PApe, SApe,
                        CI, calle, Integer.Parse(nroPuerta), esBis,
                        Integer.Parse(sueldoPorMes), cargo, activo, telefonos)
                )

            Case 2
                Me.empleados.Add(
                    New Operario(PNom, SNom, PApe, SApe,
                        CI, calle, Integer.Parse(nroPuerta), esBis,
                        Integer.Parse(sueldoPorMes), cargo, activo, telefonos)
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

    Function buscarEmpleadosQue(nomVariable As String, formaComparar As Integer, valor As String, listaEmpleados As List(Of Empleado)) As List(Of Empleado)
        Dim empleadosAux As List(Of Empleado) = New List(Of Empleado)


        Select Case nomVariable
            Case "PNom"
                If formaComparar = 0 Then
                    For Each empl As Empleado In listaEmpleados
                        If empl.PNom = valor Then
                            empleadosAux.Add(empl)
                        End If
                    Next
                Else
                    For Each empl As Empleado In listaEmpleados
                        For plus As Integer = 0 To empl.PNom.Count - valor.Count 'Esto Busca en todas las ubicaciones posibles porque solo se sabe que se incluye
                            If Me.perteneceAlStringSegundo(valor, empl.PNom, plus) Then
                                empleadosAux.Add(empl)
                            End If
                        Next
                    Next
                End If
            Case "SNom"
                If formaComparar = 0 Then
                    For Each empl As Empleado In listaEmpleados
                        If empl.SNom = valor Then
                            empleadosAux.Add(empl)
                        End If
                    Next
                Else
                    For Each empl As Empleado In listaEmpleados
                        For plus As Integer = 0 To empl.SNom.Count - valor.Count 'Esto Busca en todas las ubicaciones posibles porque solo se sabe que se incluye
                            If Me.perteneceAlStringSegundo(valor, empl.SNom, plus) Then
                                empleadosAux.Add(empl)
                            End If
                        Next
                    Next
                End If
            Case "PApe"
                If formaComparar = 0 Then
                    For Each empl As Empleado In listaEmpleados
                        If empl.PApe = valor Then
                            empleadosAux.Add(empl)
                        End If
                    Next
                Else
                    For Each empl As Empleado In listaEmpleados
                        For plus As Integer = 0 To empl.PApe.Count - valor.Count 'Esto Busca en todas las ubicaciones posibles porque solo se sabe que se incluye
                            If Me.perteneceAlStringSegundo(valor, empl.PApe, plus) Then
                                empleadosAux.Add(empl)
                            End If
                        Next
                    Next
                End If
            Case "SApe"
                If formaComparar = 0 Then
                    For Each empl As Empleado In listaEmpleados
                        If empl.SApe = valor Then
                            empleadosAux.Add(empl)
                        End If
                    Next
                Else
                    For Each empl As Empleado In listaEmpleados
                        For plus As Integer = 0 To empl.SApe.Count - valor.Count 'Esto Busca en todas las ubicaciones posibles porque solo se sabe que se incluye
                            If Me.perteneceAlStringSegundo(valor, empl.SApe, plus) Then
                                empleadosAux.Add(empl)
                            End If
                        Next
                    Next
                End If
            Case "CI"
                If formaComparar = 0 Then
                    For Each empl As Empleado In listaEmpleados
                        If empl.CI = valor Then
                            empleadosAux.Add(empl)
                        End If
                    Next
                Else
                    For Each empl As Empleado In listaEmpleados
                        For plus As Integer = 0 To empl.CI.Count - valor.Count 'Esto Busca en todas las ubicaciones posibles porque solo se sabe que se incluye
                            If Me.perteneceAlStringSegundo(valor, empl.CI, plus) Then
                                empleadosAux.Add(empl)
                            End If
                        Next
                    Next
                End If
            Case "Calle"
                If formaComparar = 0 Then
                    For Each empl As Empleado In listaEmpleados
                        If empl.calle = valor Then
                            empleadosAux.Add(empl)
                        End If
                    Next
                Else
                    For Each empl As Empleado In listaEmpleados
                        For plus As Integer = 0 To empl.calle.Count - valor.Count 'Esto Busca en todas las ubicaciones posibles porque solo se sabe que se incluye
                            If Me.perteneceAlStringSegundo(valor, empl.calle, plus) Then
                                empleadosAux.Add(empl)
                            End If
                        Next
                    Next
                End If
            Case "NroPuerta"
                If formaComparar = 0 Then
                    For Each empl As Empleado In listaEmpleados
                        If empl.nroPuerta = valor Then
                            empleadosAux.Add(empl)
                        End If
                    Next
                End If
            Case "EsBis"
                For Each empl As Empleado In listaEmpleados
                    Dim resultado As Boolean
                    empl.esBis = Boolean.TryParse(valor, resultado)
                    If resultado Then
                        empleadosAux.Add(empl)
                    End If
                Next
            Case Else
        End Select
    End Function
End Class
