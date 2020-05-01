Imports Control
Imports LogicaDatos
Imports System.Windows.Forms

Public Class VModificarEmpleado
    Private vAnterior As VBuscarEmpleado
    Private control As ControlEmpleados
    Property nroEmpleado As Integer
    Private relacionNroComponente As Dictionary(Of Integer, Object())
    Private vAgregarTelefonos As VAgregarTelefonos

    Public Sub New(control As ControlEmpleados, vAnterior As VBuscarEmpleado)

        Me.vAnterior = vAnterior
        Me.control = control
        Me.nroEmpleado = 0
        Me.vAgregarTelefonos = New VAgregarTelefonos(control, Me)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.relacionNroComponente = New Dictionary(Of Integer, Object())
        With relacionNroComponente
            .Add(0, {Me.lblPNom, Me.txtPNom})
            .Add(1, {Me.lblSNom, Me.txtSNom})
            .Add(2, {Me.lblPApe, Me.txtPApe})
            .Add(3, {Me.lblSApe, Me.txtSApe})
            .Add(4, {Nothing, Nothing})
            .Add(5, {Me.lblCalle, Me.txtCalle})
            .Add(6, {Me.lblNroPuerta, Me.txtNroPuerta})
            .Add(7, {Me.lblSueldoPorMes, Me.txtSueldoPorMes})
        End With
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        vAgregarTelefonos.recargar = True
        Me.vAnterior.Show()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim auxEmpleado = control.tomarEmpleado(nroEmpleado)
        Dim problemas() As Boolean = control.testearDatosEmpleado(txtPNom.Text, txtSNom.Text, txtPApe.Text, txtSApe.Text,
                                Nothing, txtCalle.Text, txtNroPuerta.Text, txtSueldoPorMes.Text, cboEsBis.SelectedIndex, vAgregarTelefonos.getNumerosTelefonicos())
        Dim datosValidos As Boolean = True
        For i As Integer = 0 To problemas.Count - 1
            If i <> 4 Then
                If problemas(i) Then
                    Me.relacionNroComponente(i)(0).ForeColor = Drawing.Color.Red
                    datosValidos = False
                Else
                    Me.relacionNroComponente(i)(0).ForeColor = Drawing.Color.Black
                End If
            End If
        Next
        If datosValidos Then
            control.modificarEmpleado(nroEmpleado, txtPNom.Text, txtSNom.Text,
                txtPApe.Text, txtSApe.Text, auxEmpleado.CI, txtCalle.Text,
                Integer.Parse(txtNroPuerta.Text), cboEsBis.SelectedIndex = 0,
                Integer.Parse(txtSueldoPorMes.Text), cboCargo.SelectedItem, cckActivo.Checked,
                vAgregarTelefonos.getNumerosTelefonicos()
            )
            vAgregarTelefonos.recargar = True

            For i As Integer = 0 To relacionNroComponente.Count - 1
                If i <> 4 Then
                    Me.relacionNroComponente(i)(1).Text = ""
                    Me.relacionNroComponente(i)(0).ForeColor = Drawing.Color.Red
                End If
            Next
            Me.vAgregarTelefonos.lbNumeros.Items.Clear()
            Me.Hide()
            vAnterior.Show()
        End If
    End Sub
    Private Sub VModificarEmpleado_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim aux = control.tomarEmpleado(nroEmpleado)
        Dim datosValidos As Boolean = True

        txtPNom.Text = aux.PNom
        txtSNom.Text = aux.SNom
        txtPApe.Text = aux.PApe
        txtSApe.Text = aux.SApe
        txtCalle.Text = aux.calle
        txtNroPuerta.Text = aux.nroPuerta
        If aux.esBis Then
            cboEsBis.SelectedIndex = 0
        Else
            cboEsBis.SelectedIndex = 1
        End If
        cckActivo.Checked = aux.activo
        txtSueldoPorMes.Text = aux.sueldoPorMes
        cboCargo.SelectedIndex = aux.cargo

        For i As Integer = 0 To Me.relacionNroComponente.Count - 1
            rojoSiEstaVacia(relacionNroComponente(i)(0), relacionNroComponente(i)(1))
        Next
    End Sub
    Function rojoSiEstaVacia(label As Label, txtBox As TextBox)
        If Not txtBox Is Nothing Then
            If txtBox.Text = "" Then
                label.ForeColor = Drawing.Color.Red
            Else
                label.ForeColor = Drawing.Color.Black
            End If
        End If
    End Function
    Function soloNumeros(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Function
    Private Sub txtPApe_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSueldoPorMes.KeyUp, txtNroPuerta.KeyUp, txtPApe.KeyUp, txtSApe.KeyUp, txtPNom.KeyUp, txtSNom.KeyUp, txtCalle.KeyUp
        Select Case sender.GetHashCode
            Case Me.txtPNom.GetHashCode
                rojoSiEstaVacia(lblPNom, txtPNom)
            Case Me.txtSNom.GetHashCode
                rojoSiEstaVacia(lblSNom, txtSNom)
            Case Me.txtPApe.GetHashCode
                rojoSiEstaVacia(lblPApe, txtPApe)
            Case Me.txtSApe.GetHashCode
                rojoSiEstaVacia(lblSApe, txtSApe)
            Case Me.txtCalle.GetHashCode
                rojoSiEstaVacia(lblCalle, txtCalle)
            Case Me.txtNroPuerta.GetHashCode
                rojoSiEstaVacia(lblNroPuerta, txtNroPuerta)
            Case Me.txtSueldoPorMes.GetHashCode
                rojoSiEstaVacia(lblSueldoPorMes, txtSueldoPorMes)
        End Select
    End Sub
    Private Sub cboInmodificable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCargo.KeyPress, cboEsBis.KeyPress
        e.Handled = True
    End Sub
    Private Sub txtLimiteANumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroPuerta.KeyPress, txtSueldoPorMes.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub btnAgregarTelefonos_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefonos.Click
        Me.Hide()
        vAgregarTelefonos.Show()
    End Sub

    Private Sub cboEsBis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEsBis.SelectedIndexChanged

    End Sub
End Class