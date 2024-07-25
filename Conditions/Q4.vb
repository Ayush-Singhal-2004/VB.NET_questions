Module Program
    Sub Main(args() As string)
        Console.Write("Enter a number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())
        If num Mod 3 = 0 And num Mod 5 = 0 Then
            Console.Write("True")
        Else
            Console.Write("False")
        End If
    End Sub
End Module