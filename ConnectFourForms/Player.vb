Public Class Player

    Private _name As String
    Private _symbol As String

    Public Sub New(name As String, symbol As String)
        Me._name = name
        Me._symbol = symbol
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property Symbol As String
        Get
            Return _symbol
        End Get
    End Property
End Class
