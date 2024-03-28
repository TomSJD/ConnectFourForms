Public Class GameForm

    Private Players() As Player

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim PInfoForm As New PlayerInfoForm(Me)
    End Sub

    ' Sub called by PlayerInfoForm once the players have entered their details
    Public Sub SetupPlayerInfo(players() As Player)
        Me.Players = players
        Me.Show()
    End Sub
End Class
