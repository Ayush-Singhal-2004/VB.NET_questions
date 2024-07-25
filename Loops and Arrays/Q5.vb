Module Program
    Sub Main(args() As Integer)
        Console.Write("Enter a number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())
        Dim max, secondMax As Integer
        Dim temp As Integer = num
        While temp <> 0
            Dim dig = temp Mod 10
            temp \= 10
            If dig > max Then
                max = dig
            End If
        End While
        While num <> 0
            Dim dig = num Mod 10
            num \= 10
            If dig > secondMax And dig < max Then
                secondMax = dig
            End If
        End While
        Console.Write("Second maximum digit = " & secondMax)
    End Sub
End Module