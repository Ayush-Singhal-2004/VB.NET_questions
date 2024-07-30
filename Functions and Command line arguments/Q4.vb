Module Program

    Function ShowSum(num() As Integer) As Integer
        Dim sum As Integer = 0
        For i As Integer = 0 To 4 Step 1
            sum += num(i)
        Next
        Return sum
    End Function

    Function ShowSum(num As Integer) As Integer
        Dim sum As Integer = 0
        While num <> 0
            sum += num Mod 10
            num /= 10
        End While
        Return sum
    End Function

    Sub Main(args As String())
        Dim arr(4) As Integer

        For i As Integer = 0 To 4 Step 1
            Console.Write("Enter {0} number = ", i + 1)
            arr(i) = Integer.Parse(Console.ReadLine())
        Next
        Console.Write("Enter any number = ")
        Dim num As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine(ShowSum(arr))
        Console.WriteLine(ShowSum(num))
    End Sub

End Module