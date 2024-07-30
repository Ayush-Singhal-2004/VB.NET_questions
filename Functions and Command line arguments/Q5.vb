Module Program

    Sub Main(args As String())
        Dim sum As Integer = 0
        For i As Integer = 0 To args.GetUpperBound(0) Step 1
            Dim num As Integer = Integer.Parse(args(i))
            If num Mod 2 = 0 Then
                sum += num
            End If
        Next
        Console.WriteLine("Sum = " & sum)
    End Sub

End Module