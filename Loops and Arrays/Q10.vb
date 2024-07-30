Sub Main(args As String())
    Dim arr(2, 2) As Integer
    Dim temp As Integer = 1
    For row As Integer = 0 To 2 Step 1
        For col As Integer = 0 To 2 Step 1
            Console.Write("Enter {0} number = ", temp)
            arr(row, col) = Integer.Parse(Console.ReadLine())
            temp += 1
        Next
    Next
    Dim count As Integer = 0
    For row As Integer = 0 To 2 Step 1
        For col As Integer = 0 To 2 Step 1
            Dim isPrime As Boolean = True
            For div As Integer = 2 To arr(row, col) - 1 Step 1
                If arr(row, col) Mod div = 0 Then
                    isPrime = False
                    Exit For
                End If
            Next
            If isPrime Then
                count += 1
            End If
        Next
        Console.WriteLine("Count of row {0} = {1}", row + 1, count)
    Next
End Sub