Imports Control
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
        Me.relacionNroComponente = New Dictionary(Of Integer, Object()) From {
            {0, {Me.lblPNom, Me.txtPNom}},
            {1, {Me.lblSNom, Me.txtSNom}},
            {2, {Me.lblPApe, Me.txtPApe}},
            {3, {Me.lblSApe, Me.txtSApe}},
            {5, {Me.lblCalle, Me.txtCalle}},
            {6, {Me.lblNroPuerta, Me.txtNroPuerta}},
            {7, {Me.lblSueldoPorMes, Me.txtSueldoPorMes}}
        }

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Me.vAnterior.Show()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim auxEmpleado = control.tomarEmpleado(nroEmpleado)
        Dim problemas() As Boolean = control.testearDatosEmpleado(txtPNom.Text, txtSNom.Text, txtPApe.Text, txtSApe.Text,
                                Nothing, txtCalle.Text, txtNroPuerta.Text, txtSueldoPorMes.Text, cboEsBis.SelectedIndex)
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
            auxEmpleado.PNom = txtPNom.Text
            auxEmpleado.SNom = txtSNom.Text
            auxEmpleado.PApe = txtPApe.Text
            auxEmpleado.SApe = txtSApe.Text
            auxEmpleado.calle = txtCalle.Text
            auxEmpleado.nroPuerta = txtNroPuerta.Text
            auxEmpleado.esBis = cboEsBis.Text = "Si"
            auxEmpleado.sueldoPorMes = Integer.Parse(txtSueldoPorMes.Text)
            Select Case cboCargo.Text
                Case "Administrativo"
                    auxEmpleado.cargo = 0
                Case "Gerente"
                    auxEmpleado.cargo = 1
                Case "Operario"
                    auxEmpleado.cargo = 2
            End Select
            auxEmpleado.activo = cckActivo.AutoCheck
            For i As Integer = 0 To relacionNroComponente.Count - 1
                If i <> 4 Then
                    Me.relacionNroComponente(i)(1).Text = ""
                    Me.relacionNroComponente(i)(0).ForeColor = Drawing.Color.Red
                End If
            Next
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
            cboEsBis.Text = "Si"
        Else
            cboEsBis.Text = "No"
        End If
        cckActivo.AutoCheck = aux.activo
        txtSueldoPorMes.Text = aux.sueldoPorMes
        cboCargo.SelectedIndex = aux.cargo

        rojoSiEstaVacia(lblPNom, txtPNom)
        rojoSiEstaVacia(lblSNom, txtSNom)
        rojoSiEstaVacia(lblPApe, txtPApe)
        rojoSiEstaVacia(lblSApe, txtSApe)
        rojoSiEstaVacia(lblCalle, txtCalle)
        rojoSiEstaVacia(lblNroPuerta, txtNroPuerta)
        rojoSiEstaVacia(lblSueldoPorMes, txtSueldoPorMes)

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
End Class