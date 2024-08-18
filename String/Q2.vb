Module Program
	Public Sub Main(args() As String)
        Console.Write("Enter any string = ")
        Dim str As String = Console.Read()
        Dim count As Integer = 0
        For i As Integer = 0 To str.Length - 1 Step 1
        Dim ch As Char = str(i)
        If ch >= "A" And ch <= "Z" Then
            count += 1
        End If
        Next
        Console.Write(count)
	End Sub
End Module