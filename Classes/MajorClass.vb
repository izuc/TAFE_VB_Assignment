Option Explicit On
Option Strict On
Public Class MajorClass
    Private strMajorCode As String
    Private strDescription As String

    Public Sub New(ByVal strMajorCode As String, ByVal strDescription As String)
        Me.strMajorCode = strMajorCode
        Me.strDescription = strDescription
    End Sub

    ReadOnly Property MajorCode() As String
        Get
            Return Me.strMajorCode
        End Get
    End Property

    ReadOnly Property Description() As String
        Get
            Return Me.strDescription
        End Get
    End Property
    Public Overrides Function ToString() As String
        Return Me.strMajorCode
    End Function
End Class
