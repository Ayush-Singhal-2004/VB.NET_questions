Module Program
    Sub Main(args() As string)
        For i As Integer = 1 To 5 Step 1
            Console.Write("Enter {0} number = ", i)
            Dim num As Integer = Integer.Parse(Console.ReadLine())
            Dim temp As Integer = num
            While temp <> 0
                Dim dig As Integer = temp Mod 10
                temp \= 10
                If dig Mod 2 = 0 Then
                    Console.WriteLine(num)
                    Exit While
                End If
            End While
        Next
    End Sub
End Module