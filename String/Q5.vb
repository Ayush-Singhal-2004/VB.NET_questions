Public Module Program
	Public Sub Main(args() As String)
        Dim str As String = Console.ReadLine()
        Dim i As Integer = 0
        Dim j As Integer = str.Length - 1
        Dim result As String = ""
        For i = str.Length - 1 To 0 Step -1 
        result += str(i)
        Next
        Console.Write(result)
	End Sub
End Module