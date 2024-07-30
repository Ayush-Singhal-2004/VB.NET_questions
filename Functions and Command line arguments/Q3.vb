Module Program

    Function MaxInteger(ParamArrayNum() As Integer) As Integer
        Dim max As Integer = 0
        For i As Integer = 0 To 4 Step 1
            If ParamArrayNum(i) > max Then
                max = ParamArrayNum(i)
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
        Console.WriteLine(MaxInteger(arr))
    End Sub

End Module