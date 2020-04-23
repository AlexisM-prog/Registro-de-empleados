Imports System.ComponentModel
Imports Control
Imports System.Windows
Imports System.Windows.Forms
Imports System.Threading

Public Class VAgregarEmpleado
    Private vAnterior As VRegistroEmpleado
    Private control As ControlEmpleados
    Private relacionNroComponente As Dictionary(Of Integer, Object())
    Property vAgregarTelefonos As VAgregarTelefonos

    Public Sub New(control As ControlEmpleados, vAnterior As VRegistroEmpleado)
        Me.vAnterior = vAnterior
        Me.control = control
        Me.relacionNroComponente = New Dictionary(Of Integer, Object())
        Me.vAgregarTelefonos = New VAgregarTelefonos(control, Me)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.relacionNroComponente.Add(0, {Me.lblPNom, Me.txtPNom})
        Me.relacionNroComponente.Add(1, {Me.lblSNom, Me.txtSNom})
        Me.relacionNroComponente.Add(2, {Me.lblPApe, Me.txtPApe})
        Me.relacionNroComponente.Add(3, {Me.lblSApe, Me.txtSApe})
        Me.relacionNroComponente.Add(4, {Me.lblCI, Me.txtCI})
        Me.relacionNroComponente.Add(5, {Me.lblCalle, Me.txtCalle})
        Me.relacionNroComponente.Add(6, {Me.lblNroPuerta, Me.txtNroPuerta})
        Me.relacionNroComponente.Add(7, {Me.lblSueldoPorMes, Me.txtSueldoPorMes})
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Me.vAnterior.Show()

    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim problemas() As Boolean = control.testearDatosEmpleado(txtPNom.Text, txtSNom.Text, txtPApe.Text, txtSApe.Text,
                                txtCI.Text, txtCalle.Text, txtNroPuerta.Text, txtSueldoPorMes.Text, cboCargo.SelectedIndex, vAgregarTelefonos.telefonos.ToArray)
        Dim datosValidos As Boolean = True
        For i As Integer = 0 To problemas.Count - 1
            If problemas(i) Then
                Me.relacionNroComponente(i)(0).ForeColor = Drawing.Color.Red
                datosValidos = False
            Else
                Me.relacionNroComponente(i)(0).ForeColor = Drawing.Color.Black
            End If
        Next
        If datosValidos Then
            Me.control.agregarEmpleado(txtPNom.Text, txtSNom.Text, txtPApe.Text, txtSApe.Text, txtCI.Text, txtCalle.Text,
                                txtNroPuerta.Text, cboEsBis.Text = "Si", txtSueldoPorMes.Text,
                                cboCargo.SelectedIndex, cckActivo.Checked, vAgregarTelefonos.telefonos.ToArray)

            For i As Integer = 0 To problemas.Count - 1
                Me.relacionNroComponente(i)(1).text = ""
                Me.relacionNroComponente(i)(0).ForeColor = Drawing.Color.Red
            Next
            Me.vAgregarTelefonos.lbNumeros.Items.Clear()

            MsgBox("Se guardo exitosamente")
            Me.Hide()
            vAnterior.Show()
        End If

    End Sub
    Function rojoSiEstaVacia(label As Label, txtBox As TextBox)
        If txtBox.Text = "" Then
            label.ForeColor = Drawing.Color.Red
        Else
            label.ForeColor = Drawing.Color.Black
        End If
    End Function
    Function soloNumeros(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Function
    Private Sub cboInmodificable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCargo.KeyPress, cboEsBis.KeyPress
        e.Handled = True
    End Sub
    Private Sub todosLosTxt_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSueldoPorMes.KeyUp, txtSNom.KeyUp, txtSApe.KeyUp, txtPNom.KeyUp, txtPApe.KeyUp, txtNroPuerta.KeyUp, txtCI.KeyUp, txtCalle.KeyUp
        Select Case sender.GetHashCode
            Case Me.txtPNom.GetHashCode
                rojoSiEstaVacia(lblPNom, txtPNom)
            Case Me.txtSNom.GetHashCode
                rojoSiEstaVacia(lblSNom, txtSNom)
            Case Me.txtPApe.GetHashCode
                rojoSiEstaVacia(lblPApe, txtPApe)
            Case Me.txtSApe.GetHashCode
                rojoSiEstaVacia(lblSApe, txtSApe)
            Case Me.txtCI.GetHashCode
                rojoSiEstaVacia(lblCI, txtCI)
                If control.tomarEmpleadoConCedula(txtCI.Text) Is Nothing Then
                    lblCI.ForeColor = Drawing.Color.Black
                Else
                    lblCI.ForeColor = Drawing.Color.Red
                End If
            Case Me.txtCalle.GetHashCode
                rojoSiEstaVacia(lblCalle, txtCalle)
            Case Me.txtNroPuerta.GetHashCode
                rojoSiEstaVacia(lblNroPuerta, txtNroPuerta)
            Case Me.txtSueldoPorMes.GetHashCode
                rojoSiEstaVacia(lblSueldoPorMes, txtSueldoPorMes)
        End Select
    End Sub
    Private Sub VAgregarEmpleado_Load(sender As Object, e As EventArgs) Handles Me.Load
        rojoSiEstaVacia(lblPNom, txtPNom)
        rojoSiEstaVacia(lblSNom, txtSNom)
        rojoSiEstaVacia(lblPApe, txtPApe)
        rojoSiEstaVacia(lblSApe, txtSApe)
        rojoSiEstaVacia(lblCI, txtCI)
        rojoSiEstaVacia(lblCalle, txtCalle)
        rojoSiEstaVacia(lblNroPuerta, txtNroPuerta)
        rojoSiEstaVacia(lblSueldoPorMes, txtSueldoPorMes)
        Me.cboEsBis.SelectedIndex = 0
        Me.cboCargo.SelectedIndex = 0

    End Sub
    Private Sub txtLimiteANumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCI.KeyPress, txtNroPuerta.KeyPress, txtSueldoPorMes.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub btnTelefonos_Click(sender As Object, e As EventArgs) Handles btnTelefonos.Click
        Me.Hide()
        vAgregarTelefonos.Show()
    End Sub
End Class