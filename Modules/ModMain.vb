Option Explicit On
Option Strict On
Imports System.IO
Module ModMain
#Region "Fields"
    Public g_MDIForm As MDIForm
    Public Const strDATA_EXT As String = ".txt"
    Public Const strDATA_FOLDER As String = "\data\"
    Public Const strPIC_FOLDER As String = "\PicFiles\"
    Enum dataFile
        Exercise
        Sheet
        MajorClass
        SubClass
    End Enum
    Public sheetCollection As Collection
    Public exerciseCollection As Collection
    Public subclassCollection As Collection
    Public majorclassCollection As Collection
    Public dataLoaded As Boolean = False
#End Region
#Region "Loading Data"
    Sub LoadFile()
        Const strCOMMA As String = ","
        Const strCANNOT_LOAD As String = "Cannot load, please try again later"
        If Not (dataLoaded) Then
            Try
                For Each filename As dataFile In System.Enum.GetValues(GetType(dataFile))
                    Dim fileLocation As String = My.Application.Info.DirectoryPath.ToString & strDATA_FOLDER & filename.ToString & strDATA_EXT
                    If System.IO.File.Exists(fileLocation) Then
                        Dim textFile As StreamReader = File.OpenText(fileLocation)
                        Dim data() As String
                        Do Until textFile.EndOfStream
                            data = Split(textFile.ReadLine(), strCOMMA)
                            Select Case filename
                                Case dataFile.Exercise
                                    SortExerciseData(data)
                                Case dataFile.Sheet
                                    SortSheetData(data)
                                Case dataFile.MajorClass
                                    SortMajorClassData(data)
                                Case dataFile.SubClass
                                    SortSubClassData(data)
                            End Select
                        Loop
                        textFile.Close()
                    End If
                Next
                dataLoaded = True
            Catch ex As Exception
                MessageBox.Show(strCANNOT_LOAD)
            End Try
        End If
    End Sub
    Sub SortSheetData(ByVal data() As String)
        Try
            Dim strSheetCode As String = CStr(data(0).Trim), strDescription As String = CStr(data(1).Trim), arrExCode() As String = Nothing
            Dim intDataIndex As Integer, intCodeIndex As Integer = 0
            Dim strCode As String = String.Empty
            Const strDOESNT_EXIST As String = " Doesn't Exist"
            Const strNOT_FOUND As String = "Not Found"
            For intDataIndex = 2 To (data.GetUpperBound(0) - 1)
                strCode = CStr(data(intDataIndex).Trim)
                If ExerciseExists(strCode) Then
                    ReDim Preserve arrExCode(intCodeIndex)
                    arrExCode(intCodeIndex) += strCode
                    intCodeIndex += 1
                Else
                    MessageBox.Show(strCode & strDOESNT_EXIST, strNOT_FOUND)
                End If
            Next
            ModMain.sheetCollection.Add(New Sheet(strSheetCode, strDescription, arrExCode), strSheetCode)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function ExerciseExists(ByVal code As String) As Boolean
        Try
            Dim exercise As Exercise = DirectCast(exerciseCollection.Item(code), Exercise)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Sub SortExerciseData(ByVal data() As String)
        Try
            Dim strExCode As String, strMajorClass As String, strSubclass As String, strDescription As String, strOrientation As String, strPicFileName As String
            strExCode = CStr(data(0).Trim)
            strMajorClass = CStr(data(1).Trim)
            strSubclass = CStr(data(2).Trim)
            strDescription = CStr(data(3).Trim)
            strOrientation = CStr(data(4).Trim)
            strPicFileName = CStr(data(5).Trim)
            ModMain.exerciseCollection.Add(New Exercise(strExCode, strMajorClass, strSubclass, strDescription, strOrientation, strPicFileName), strExCode)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub SortMajorClassData(ByVal data() As String)
        Try
            Dim strMajorCode As String = CStr(data(0).Trim), strDescription As String = CStr(data(1).Trim)
            modMain.majorclassCollection.Add(New MajorClass(strMajorCode, strDescription), strMajorCode)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub SortSubClassData(ByVal data() As String)
        Try
            Dim strSubCode As String = CStr(data(0).Trim), strDescription As String = CStr(data(1).Trim)
            ModMain.subclassCollection.Add(New SubClass(strSubCode, strDescription), strSubCode)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Saving Data"
    Public Sub SaveData()
        Const strCANNOT_SAVE As String = "Cannot save, please try again later"
        If (dataLoaded) Then
            Try
                For Each filename As dataFile In System.Enum.GetValues(GetType(dataFile))
                    Dim outputFile As StreamWriter
                    Dim fileLocation As String = My.Application.Info.DirectoryPath.ToString & strDATA_FOLDER & filename.ToString & strDATA_EXT
                    outputFile = File.CreateText(fileLocation)
                    Select Case filename
                        Case dataFile.Exercise
                            SaveExerciseData(outputFile)
                        Case dataFile.Sheet
                            SaveSheetData(outputFile)
                        Case dataFile.MajorClass
                            SaveMajorClassData(outputFile)
                        Case dataFile.SubClass
                            SaveSubClassData(outputFile)
                    End Select
                    outputFile.Close()
                Next
            Catch ex As Exception
                MessageBox.Show(strCANNOT_SAVE)
            End Try
        End If
    End Sub
    Public Sub SaveSheetData(ByVal outputFile As StreamWriter)
        Dim strOutput As String = String.Empty
        Const strCOMMA As String = ","
        For Each sheet As Sheet In sheetCollection
            strOutput = sheet.SheetCode & strCOMMA & sheet.Description
            For Each code As String In sheet.ExCode
                strOutput += strCOMMA & code
            Next
            outputFile.WriteLine(strOutput)
        Next
    End Sub
    Public Sub SaveExerciseData(ByVal outputFile As StreamWriter)
        Const strCOMMA As String = ","
        For Each exercise As Exercise In exerciseCollection
            outputFile.WriteLine(exercise.ExCode & strCOMMA & exercise.MajorClass & strCOMMA & exercise.Subclass & strCOMMA & exercise.Description & strCOMMA & exercise.Orientation & strCOMMA & exercise.PicFileName)
        Next
    End Sub
    Public Sub SaveMajorClassData(ByVal outputFile As StreamWriter)
        Const strCOMMA As String = ","
        For Each majorclass As MajorClass In majorclassCollection
            outputFile.WriteLine(majorclass.MajorCode & strCOMMA & majorclass.Description)
        Next
    End Sub
    Public Sub SaveSubClassData(ByVal outputFile As StreamWriter)
        Const strCOMMA As String = ","
        For Each subclass As SubClass In subclassCollection
            outputFile.WriteLine(subclass.SubCode & strCOMMA & subclass.Description)
        Next
    End Sub
#End Region
    Public Sub main()
        sheetCollection = New Collection
        exerciseCollection = New Collection
        subclassCollection = New Collection
        majorclassCollection = New Collection
        g_MDIForm = New MDIForm
        g_MDIForm.ShowDialog()
    End Sub
End Module
