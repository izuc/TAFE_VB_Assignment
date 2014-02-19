Option Explicit On
Option Strict On
Public Class Sheet
    Private strSheetCode As String      'Unique code to identify a sheet
    Private strDescription As String    'Sheet description
    Private arrExCode() As String       'There are 10 exercise codes per sheet

    Public Sub New(ByVal strSheetCode As String, ByVal strDescription As String, ByVal arrExCode() As String)
        Me.strSheetCode = strSheetCode
        Me.strDescription = strDescription
        Me.arrExCode = arrExCode
    End Sub

    ReadOnly Property SheetCode() As String
        Get
            Return Me.strSheetCode
        End Get
    End Property

    ReadOnly Property Description() As String
        Get
            Return Me.strDescription
        End Get
    End Property

    ReadOnly Property ExCode() As String()
        Get
            Return Me.arrExCode
        End Get
    End Property
End Class