Module valorAproximado_1_12

    Sub Main()

        Dim a As Single
        Console.Write("Ingresar Valor: ")
        a = Console.ReadLine()

        Console.WriteLine("{0} Valor aproximado por exceso: " & Math.Ceiling(a), a)
        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(3.2))
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(a))
        Console.WriteLine("Valor redondeado: " & Math.Round(a))
        'No sale!
        Console.ReadKey()

    End Sub

End Module
