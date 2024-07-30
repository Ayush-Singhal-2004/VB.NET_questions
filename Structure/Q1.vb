Structure Book
    Public Title As String
    Public Author As String
    Public Price As Integer
End Structure

Module Module1

    Sub Main(args As String())
        Dim book As New Book

        Console.Write("Enter book title = ")
        book.Title = Console.ReadLine()

        Console.Write("Enter book author = ")
        book.Author = Console.ReadLine()
        
        Console.Write("Enter book price = ")
        book.Price = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Title = " & book.Title)
        Console.WriteLine("Author = " & book.Author)
        Console.WriteLine("Price = " & book.Price)
    End Sub

End Module