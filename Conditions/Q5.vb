Module Program
    Sub Main(args() As string)
        Console.Write("Enter a 3 digit number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())
        Dim dig As Integer = num Mod 10
        num \= 10
        If dig Mod 2 = 0 Then
            Console.Write("False")
            Return
        End If
        dig = num Mod 10
        num \= 10
        If dig Mod 2 = 0 Then
            Console.Write("False")
            Return
        End If
        dig = num
        num /= 10
        If dig Mod 2 = 0 Then
            Console.Write("False")
            Return
        End If
        Console.Write("True")
    End Sub
End Module