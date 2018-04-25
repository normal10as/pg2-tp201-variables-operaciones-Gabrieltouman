Module programa_1_16

    Sub Main()

        Dim fecha As Date
        Dim dias As UShort

        Console.Write("Ingrese una fecha de la forma #dd-mm-aa#: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese un numero de dias a sumar a la fecha anterior: ")
        dias = Console.ReadLine()
        Console.WriteLine("La fecha caera el: " & fecha.AddDays(dias))
        Console.ReadKey()

    End Sub

End Module
