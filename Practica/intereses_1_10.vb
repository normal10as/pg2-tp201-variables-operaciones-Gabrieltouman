Module intereses_1_10
    Sub Main()

        Dim monto As Integer
        Dim interes As Single
        Dim tiempo As UShort
        Dim interes_producido As Single

        Console.Write("Ingrese el monto: $")
        monto = Console.ReadLine()
        Console.Write("Ingrese el interes: %")
        interes = Console.ReadLine()
        Console.Write("Ingrese el tiempo en dias: ")
        tiempo = Console.ReadLine()

        interes_producido = monto * interes * tiempo / (360 * 100)
        Console.WriteLine(vbCrLf & "El interes producido es de: %" & interes_producido)
        Console.WriteLine("El capital acumulado es de: $" & monto + interes_producido)

        Console.ReadKey()

    End Sub

End Module
