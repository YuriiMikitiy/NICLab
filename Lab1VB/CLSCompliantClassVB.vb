Imports System
Imports Lab1Interfaces


<Assembly: CLSCompliant(True)>

Public Class CLSCompliantClassVB
    Implements ICLSCompliant

    Public Function GetYearOfBirth(birthDate As DateTime) As Integer Implements ICLSCompliant.GetYearOfBirth
        Return birthDate.Year
    End Function

    Public Function GetFullName(firstName As String, lastName As String) As String Implements ICLSCompliant.GetFullName
        Return firstName & " " & lastName
    End Function

    Public Sub DisplayInfo(name As String, age As Integer) Implements ICLSCompliant.DisplayInfo
        Console.WriteLine($"Ім'я: {name}, Вік: {age}")
    End Sub
End Class

