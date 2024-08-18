Module Program
    Structure Employee
        Private empId As Integer
        Private name As String
        Private salary As Integer

        Function accept()
            Console.Write("Enter empId = ")
            empId = Console.ReadLine()
            Console.Write("Enter name = ")
            name = Console.ReadLine()
            Console.Write("Enter salary = ")
            salary = Console.ReadLine()
        End Function
        Function display()
            Console.WriteLine("EmpId = " & empId)
            Console.WriteLine("Name = " & name)
            Console.WriteLine("Salary = " & salary)
        End Function
    End Structure
	Public Sub Main(args() As String)
		Dim employee As Employee
		employee.accept()
		employee.display()
	End Sub
End Module