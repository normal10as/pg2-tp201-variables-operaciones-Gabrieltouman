Module programa_1_15

    Sub Main()

        Dim num_de_dia As UShort
        Dim hora As UShort
        Dim var As Date = Now

        Console.Write("Ingrese un numero de 1 a 31: ")
        num_de_dia = Console.ReadLine()
        Console.Write("Ingrese un numero de 0 a 24: ")
        hora = Console.ReadLine()

        Console.WriteLine(New Date(var.Year, var.Month, num_de_dia, hora, var.Minute, var.Second))
        Console.ReadKey()

    End Sub

End Module
