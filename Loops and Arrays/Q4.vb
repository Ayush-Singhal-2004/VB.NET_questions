Module Program
    Sub Main(args() As string)
        Console.Write("Enter a number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())
        Dim sum, count As Integer = 0
        While num <> 0
            Dim dig As Integer = num Mod 10
            num \= 10
            If dig Mod 2 = 0 Then
                count += 1
                sum += dig
            End If
        End While
        Dim avg As Integer = sum / count
        Console.WriteLine("Average of even digits = " & avg)
    End Sub
End Module