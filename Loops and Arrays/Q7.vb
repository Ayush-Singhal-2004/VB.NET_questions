Module Program
    Sub Main(args As String())
        Dim arr(4) As Integer
        For i As Integer = 0 To 4 Step 1
            Console.Write("Enter {0} number = ", i + 1)
            arr(i) = Integer.Parse(Console.ReadLine())
        Next

        Console.Write("Enter any number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())
        
        Dim count As Integer = 0
        For i As Integer = 0 To 4 Step 1
            If arr(i) = num Then
                count += 1
            End If
        Next

        Console.Write("Count = " & count)
    End Sub
End Module