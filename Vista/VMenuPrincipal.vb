Imports Control
Public Class VMenuPrincipal
    Private vRegistroEmpleados As VRegistroEmpleado
    Private vImporte As VImporte
    Private control As ControlEmpleados
    Public Sub New()
        Me.control = New ControlEmpleados()
        vImporte = New VImporte(control, Me)
        vRegistroEmpleados = New VRegistroEmpleado(control, Me)
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub clickbtnRegistroDeEmpleados(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Me.Hide()
        vRegistroEmpleados.Show()
    End Sub

    Private Sub clickbtnImporte(sender As Object, e As EventArgs) Handles btnImportePago.Click
        Me.Hide()
        vImporte.Show()
    End Sub
End Class