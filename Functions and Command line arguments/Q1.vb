Module Program

    Function AverageArray(Q() As Integer) As Double
        Dim sum As Integer = 0
        For i As Integer = 0 To 4 Step 1
            sum += Q(i)
        Next
        Return sum / 5
    End Function

    Sub Main(args As String())
        Dim arr(4) As Integer
        For i As Integer = 0 To 4 Step 1
            Console.Write("Enter {0} number = ", i + 1)
            arr(i) = Integer.Parse(Console.ReadLine())
        Next
        Console.WriteLine("Average = " & AverageArray(arr))
    End Sub

End Module