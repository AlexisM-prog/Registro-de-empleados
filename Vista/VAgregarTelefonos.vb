Imports Control
Imports LogicaDatos
Imports System
Imports System.Windows.Forms

Public Class VAgregarTelefonos
    Private vAnterior As Object
    Private empleado As Empleado
    Private control As ControlEmpleados
    Private _nroEmpleado As Integer
    Private _recargar As Boolean
    Public Property nroEmpleado As Integer
        Get
            Return _nroEmpleado
        End Get
        Set(value As Integer)
            _nroEmpleado = value
        End Set
    End Property
    Public Property recargar As Boolean
        Get
            Return _recargar
        End Get
        Set(value As Boolean)
            _recargar = value
        End Set
    End Property

    Function getNumerosTelefonicos() As String()
        Dim telefonos As List(Of String) = New List(Of String)
        For Each tel As String In lbNumeros.Items
            telefonos.Add(tel)
        Next
        Return telefonos.ToArray()
    End Function

    Public Sub New(control As ControlEmpleados, vAnterior As VAgregarEmpleado)
        Me.vAnterior = vAnterior
        Me.empleado = Nothing
        Me.control = control
        InitializeComponent()

    End Sub
    Public Sub New(control As ControlEmpleados, vAnterior As VModificarEmpleado)
        Me.vAnterior = vAnterior
        Me.control = control
        Me.recargar = True
        InitializeComponent()

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        vAnterior.show()
    End Sub
    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        If txtNumero.Text <> "" Then
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
        End If

    End Sub

    Private Sub VAgregarTelefonos_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If vAnterior.GetType.IsAssignableFrom(GetType(VAgregarEmpleado)) Then

        Else
            Me.nroEmpleado = vAnterior.nroEmpleado
            If Me.recargar Then
                Me.lbNumeros.Items.Clear()
                Dim auxEmpleado = control.tomarEmpleado(nroEmpleado)
                If Not auxEmpleado Is Nothing Then
                    For Each telefono As String In auxEmpleado.telefonos
                        lbNumeros.Items.Add(telefono)
                    Next
                End If

                recargar = False
            End If
        End If

    End Sub

    Private Sub txtNumero_Enter(sender As Object, e As EventArgs) Handles txtNumero.Enter
        If txtNumero.Text <> "" Then
            lbNumeros.Items.Add(txtNumero.Text)
            txtNumero.Text = ""
        End If
    End Sub
End Class