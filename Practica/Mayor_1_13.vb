Module Mayor_1_13

    Sub Main()

        Dim a As Single = 5
        Dim b As Single = 27.6
        Dim c As Single = 11

        Console.WriteLine("El mayor de los valores es: " & Math.Max(a, Math.Max(b, c)))

        Console.ReadKey()

    End Sub

End Module
