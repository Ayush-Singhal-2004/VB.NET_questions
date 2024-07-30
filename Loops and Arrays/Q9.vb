Module Program
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
        For row As Integer = 0 To 2 Step 1
            Dim sum As Integer = 0
            For col As Integer = 0 To 2 Step 1
                sum += arr(row, col)
            Next
            Console.WriteLine("Sum of row {0} = {1}", row + 1, sum)
        Next
    End Sub
End Module