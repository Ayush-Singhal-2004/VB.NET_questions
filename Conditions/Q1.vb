Module Program
	Sub Main(args() As string)
		Console.Write("Enter a number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Last digit of {0} = {1}", num, (num Mod 10))
	End Sub
End Module