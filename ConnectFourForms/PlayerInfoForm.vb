Public Class PlayerInfoForm

    Private _parent As GameForm

    Public Sub New(ByRef parent As GameForm)
        _parent = parent
        InitializeComponent()
    End Sub

    Private Sub PlayerInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = New Size(600, 800)
        Me.MinimumSize = New Size(600, 800)
        Me.Show()
    End Sub
End Class