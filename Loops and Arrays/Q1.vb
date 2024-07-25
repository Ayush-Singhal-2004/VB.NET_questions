Module Program
    Sub Main(args() As string)
        Dim maxEven As Integer 
        For i As Integer = 1 To 5 Step 1
            Console.Write("Enter {0} number = ")
            Dim num As Integer = Integer.Parse(Console.ReadLine())
            If num Mod 2 = 0 And num > maxEven Then
                maxEven = num
            End If
        Next
        Console.Write("Maximum even number = " & maxEven)
    End Sub
End Module