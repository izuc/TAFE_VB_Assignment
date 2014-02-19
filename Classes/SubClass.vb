Option Explicit On
Option Strict On
Public Class SubClass
    Private strSubCode As String
    Private strDescription As String

    Public Sub New(ByVal strSubCode As String, ByVal strDescription As String)
        Me.strSubCode = strSubCode
        Me.strDescription = strDescription
    End Sub

    ReadOnly Property SubCode() As String
        Get
            Return Me.strSubCode
        End Get
    End Property

    ReadOnly Property Description() As String
        Get
            Return Me.strDescription
        End Get
    End Property
    Public Overrides Function ToString() As String
        Return Me.strSubCode
    End Function
End Class
