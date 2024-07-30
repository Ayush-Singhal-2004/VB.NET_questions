Module Program
    Sub Main(args() As String)
        Dim arr(4) As Integer
        Dim countOfPrime As Integer = 0
        
        For i As Integer = 0 To 4 Step 1
            Console.Write("Enter {0} number = ", i + 1)
            arr(i) = Integer.Parse(Console.ReadLine())
            
            Dim isPrime As Boolean = True
            For div As Integer = 2 To arr(i) - 1 Step 1
                If arr(i) Mod div = 0 Then
                    isPrime = False
                    Exit For
                End If
            Next
            If isPrime Then
                countOfPrime += 1
            End If
        Next

        If countOfPrime > 1 Then
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
                    If count = 2 Then
                        Console.WriteLine("Second prime = " & arr(i))
                        Exit For
                    End If
                End If
            Next
        ElseIf countOfPrime = 1 Then
            For i As Integer = 0 To 4 Step 1
                Dim isPrime As Boolean = True
                For div As Integer = 2 To arr(i) - 1 Step 1
                    If arr(i) Mod div = 0 Then
                        isPrime = False
                        Exit For
                    End If
                Next
                If isPrime Then
                    Console.WriteLine("First prime = " & arr(i))
                    Exit For
                End If
            Next
        ElseIf countOfPrime = 0 Then
            Dim sum As Integer = 0
            For i As Integer = 0 To 4 Step 1
                sum += arr(i)
            Next
            Console.WriteLine("Avg of non primes = " & (sum / 5))
        End If
    End Sub
End Module