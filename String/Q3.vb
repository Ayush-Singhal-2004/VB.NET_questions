Module Program
	Public Sub Main(args() As String)
        Console.Write("Enter any string = ")
        Dim str As String = Console.ReadLine()
        Dim strArr() As String = str.Split(" ")
        Dim max As Integer = 0
        For Each s As String in strArr
        If s.Length > max Then
            max = s.Length
        End If
        Next
        Console.Write(max)
	End Sub
End Module