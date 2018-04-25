Module Promedio
    Sub Main()
        Console.WriteLine("Ingrese cuatro números enteros:")
        Dim a As SByte = Console.ReadLine()
        Dim b As SByte = Console.ReadLine()
        Dim c As SByte = Console.ReadLine()
        Dim d As SByte = Console.ReadLine()
        Console.WriteLine("Su sumatoria es igual a: " & a + b + c + d)
        Console.WriteLine("Su promedio es: " & (a + b + c + d) / 4)
        Console.ReadKey()

    End Sub

End Module
