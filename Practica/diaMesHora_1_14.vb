Module diaMesHora_1_14

    Sub Main()

        Dim fecha As Date = Date.Now
        'Console.WriteLine(fecha)
        Console.WriteLine("Día del año: " & fecha.DayOfYear)
        Console.WriteLine("Mes: " & fecha.Month)
        Console.WriteLine("Hora: " & fecha.Hour)
        Console.WriteLine("Minuto: " & fecha.Minute)
        Console.ReadKey()

    End Sub

End Module
