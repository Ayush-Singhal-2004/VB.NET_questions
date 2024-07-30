Module Program
    Sub Main(args As String())
        Dim arr(4) As Integer
        For i As Integer = 0 To 4 Step 1
            Console.Write("Enter {0} number = ", i + 1)
            arr(i) = Integer.Parse(Console.ReadLine())
        Next
        Dim count As Integer = 0
        For i As Integer = 0 To 4 Step 1
            Dim isPrime As Boolean = True
            For div As Integer = 2 To arr(i) - 1 Step 1
                If arr(i) Mod div = 0 Then
                    isPrime = False
                    Exit For
                End If
            Next
            If isPrime Then
                count += 1
            End If
        Next
        Console.WriteLine("Count of prime integers = " & count)
    End Sub
End Module