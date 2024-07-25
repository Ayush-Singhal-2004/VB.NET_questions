Module Program
    Sub Main(args() As string)
        Dim sum, avg, countOfEven As Integer
        For i As Integer = 1 To 5 Step 1
            Console.Write("Enter {0} number = ", i)
            Dim num As Integer = Integer.Parse(Console.ReadLine())
            If num Mod 2 = 0 Then
                countOfEven += 1
                avg += num
            Else
                sum += num
            End If
        Next
        Console.WriteLine("Sum of Odd numbers = " & sum)
        Console.WriteLine("Average of Even number = " & (avg \ countOfEven))
    End Sub
End Module