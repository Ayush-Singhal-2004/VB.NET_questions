Module Program
    Sub Main(args() As string)
        Console.Write("Enter a number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())
        If num Mod 2 = 0 Then
            Console.Write("EVEN")
        Else
            Console.Write("ODD")
        End If
    End Sub
End Module