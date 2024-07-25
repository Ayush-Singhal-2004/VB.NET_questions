Module Program
    Sub Main(args() As string)
        Console.Write("Enter a 3 digit number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())
        Dim dig, max As Integer
        max = num Mod 10
        num \= 10
        dig = num Mod 10
        num \= 10
        If dig > max Then
            max = dig
        End If
        dig = num
        num \= 10
        If dig > max Then
        max = dig
        End If
        Console.Write("Max digit = " & max)
    End Sub
End Module