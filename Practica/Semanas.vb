Module Semanas
    Sub Main()
        Const dias_año As UShort = 365
        Const dias_laborales As SByte = 5
        Const dias_semana As SByte = 7
        Console.WriteLine("Las semanas del año son: " & dias_año / dias_semana)
        '(dias_año/dias_semana)=semanas del año;si multiplico por dias_laborales, me da los dias laborables'
        'y si divido por dias_semana me da las semanas laborables'
        Console.WriteLine("Las semanas laborales son: " & dias_año / dias_semana * dias_laborales / dias_semana)
        Console.ReadKey()
    End Sub

End Module
