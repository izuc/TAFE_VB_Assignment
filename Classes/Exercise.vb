Option Explicit On
Option Strict On
Public Class Exercise
    Private strExCode As String         'Unique code to identify a sheet
    Private strMajorClass As String     'Major category for this exercise
    Private strSubclass As String       'Minor category for this exercise
    Private strDescription As String    'Exercise description
    Private strOrientation As String    'Orientation of picture: (L)andscape, (P)ortrait, (S)quare
    Private strPicFileName As String    'File name of picture for this exercise


    Public Sub New(ByVal strExCode As String, ByVal strMajorClass As String, ByVal strSubclass As String, ByVal strDescription As String, ByVal strOrientation As String, ByVal strPicFileName As String)
        Me.strExCode = strExCode
        Me.strMajorClass = strMajorClass
        Me.strSubclass = strSubclass
        Me.strDescription = strDescription
        Me.strOrientation = strOrientation
        Me.strPicFileName = strPicFileName
    End Sub
    ReadOnly Property ExCode() As String
        Get
            Return Me.strExCode
        End Get
    End Property
    ReadOnly Property MajorClass() As String
        Get
            Return Me.strMajorClass
        End Get
    End Property
    ReadOnly Property Subclass() As String
        Get
            Return Me.strSubclass
        End Get
    End Property
    ReadOnly Property Description() As String
        Get
            Return Me.strDescription
        End Get
    End Property
    ReadOnly Property Orientation() As String
        Get
            Return Me.strOrientation
        End Get
    End Property
    ReadOnly Property PicFileName() As String
        Get
            Return Me.strPicFileName
        End Get
    End Property
    Public Overrides Function ToString() As String
        Return Me.strExCode & " - " & Me.strDescription
    End Function
End Class
