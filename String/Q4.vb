Module Program
	Public Sub Main(args() As String)
        Dim str As String = Console.ReadLine()
        Dim strArr() As String = str.Split(" ")
        For Each s As String in strArr
        Dim count As Integer = 0
        For Each c As Char in s
            c = Char.ToLower(c)
            If c = "a" Or c = "e" Or c = "i" Or c = "o" Or c = "u" Then
            count += 1
        End If
        Next
        If count >= 3 Then
            Console.WriteLine(s)
        End If
        Next
	End Sub
End Module