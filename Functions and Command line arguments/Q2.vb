Module Program

    Function MaxPrime(A() As Integer) As Integer
        Dim max As Integer = 0
        For i As Integer = 0 To 4 Step 1
            Dim isPrime As Boolean = True
            For div As Integer = 2 To A(i) - 1 Step 1
                If A(i) Mod div = 0 Then
                    isPrime = False
                    Exit For
                End If
            Next
            If isPrime And A(i) > max Then
                max = A(i)
            End If
        Next
        Return max
    End Function

    Sub Main(args As String())
        Dim arr(4) As Integer
        For i As Integer = 0 To 4 Step 1
            Console.Write("Enter {0} number = ", i + 1)
            arr(i) = Integer.Parse(Console.ReadLine())
        Next
        Console.WriteLine("Max prime = " & MaxPrime(arr))
    End Sub

End Module