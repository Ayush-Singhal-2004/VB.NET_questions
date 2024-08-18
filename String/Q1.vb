Module Program
	Public Sub Main(args() As String)
        Console.Write("Enter a string = ")
	    Dim str As String = Console.ReadLine()
	    Console.Write(str.Split(" ").Length)
	End Sub
End Module