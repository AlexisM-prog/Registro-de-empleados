Public Class Persona
    Property PNom As String
    Property SNom As String
    Property PApe As String
    Property SApe As String
    Property CI As String
    Property calle As String
    Property nroPuerta As Integer
    Property esBis As Boolean
    Property telefonos As String()
    Public Sub New(PNom As String, SNom As String, PApe As String, SApe As String,
                   CI As String, calle As String, nroPuerta As Integer, esBis As Boolean)
        Me.PNom = PNom
        Me.SNom = SNom
        Me.PApe = PApe
        Me.SApe = SApe
        Me.CI = CI
        Me.calle = calle
        Me.nroPuerta = nroPuerta
        Me.esBis = esBis
    End Sub
End Class
