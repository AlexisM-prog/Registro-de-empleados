Imports Control
Imports LogicaDatos
Imports System
Imports System.Windows.Forms

Public Class VAgregarTelefonos
    Private vAnterior As Object
    Private empleado As Empleado
    Private control As ControlEmpleados
    Private _nroEmpleado As Integer
    Private _telefonos As List(Of String)
    Property telefonos As List(Of String)
        Get
            Return _telefonos
        End Get
        Set(value As List(Of String))
            _telefonos = value
        End Set
    End Property

    Public Property nroEmpleado As Integer
        Get
            Return _nroEmpleado
        End Get
        Set(value As Integer)
            _nroEmpleado = value
        End Set
    End Property

    Public Sub New(control As ControlEmpleados, vAnterior As VAgregarEmpleado)
        Me.vAnterior = vAnterior
        Me.empleado = Nothing
        Me.control = control
        Me.telefonos = New List(Of String)
        InitializeComponent()

    End Sub
    Public Sub New(control As ControlEmpleados, vAnterior As VModificarEmpleado)
        Me.vAnterior = vAnterior
        Me.control = control
        'Me.empleado = control.tomarEmpleado(pos)
        Me.telefonos = New List(Of String)
        InitializeComponent()

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        vAnterior.show()
    End Sub
    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        If txtNumero.Text <> "" Then
            telefonos.Add(txtNumero.Text)
            lbNumeros.Items.Add(txtNumero.Text)
            txtNumero.Text = ""
        End If
    End Sub
    Private Sub btnEliminarTelefono_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim telefonoB As String = ""
        For Each eachItem As String In lbNumeros.SelectedItems
            telefonoB = eachItem
        Next
        If telefonoB <> "" Then
            lbNumeros.Items.Remove(telefonoB)
            telefonos.Remove(telefonoB)
        End If

    End Sub

    Private Sub VAgregarTelefonos_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If vAnterior.GetType.IsAssignableFrom(GetType(VAgregarEmpleado)) Then

        Else
            If Me.Visible Then
                Dim auxEmpleado = control.tomarEmpleado(nroEmpleado)
                If Not auxEmpleado Is Nothing Then
                    For Each telefono As String In auxEmpleado.telefonos
                        lbNumeros.Items.Add(telefono)
                    Next
                End If
            End If
        End If

    End Sub

    Private Sub txtNumero_Enter(sender As Object, e As EventArgs) Handles txtNumero.Enter
        If txtNumero.Text <> "" Then
            telefonos.Add(txtNumero.Text)
            lbNumeros.Items.Add(txtNumero.Text)
            txtNumero.Text = ""
        End If
    End Sub
End Class