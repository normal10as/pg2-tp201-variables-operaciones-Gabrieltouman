Module valorAbsoluto_1_11

    Sub Main()

        Dim a As Single
        Console.Write("Ingresar Valor: ")
        a = Console.ReadLine()

        Console.WriteLine(vbCrLf & "Valor absoluto: " & Math.Abs(a))
        a = Math.Abs(a)
        Console.WriteLine("Elevado a la 10: " & Math.Pow(a, 10))
        Console.WriteLine("Raiz cuadrada: " & Math.Sqrt(a))

        Console.ReadKey()

    End Sub

End Module
