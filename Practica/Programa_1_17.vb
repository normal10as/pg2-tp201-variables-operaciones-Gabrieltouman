Module Programa_1_17

    Enum dias_semana As Integer
        Domingo
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
    End Enum

    Sub Main()

        Dim fecha As Date
        Dim dias As UShort
        Dim a As Date

        Console.Write("Ingrese una fecha de la forma #dd-mm-aa#: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese un numero de dias a sumar a la fecha anterior: ")
        dias = Console.ReadLine()
        a = fecha.AddDays(dias)
        Console.WriteLine("La fecha caera el: " & a)

        If a.DayOfWeek = dias_semana.Domingo Then
            Console.WriteLine("Dia de la semana: Domingo")
        ElseIf a.DayOfWeek = dias_semana.Lunes Then
            Console.WriteLine("Dia de la semana: Lunes")
        ElseIf a.DayOfWeek = dias_semana.Martes Then
            Console.WriteLine("Dia de la semana: Martes")
        ElseIf a.DayOfWeek = dias_semana.Miercoles Then
            Console.WriteLine("Dia de la semana: Miercoles")
        ElseIf a.DayOfWeek = dias_semana.Jueves Then
            Console.WriteLine("Dia de la semana: Jueves")
        ElseIf a.DayOfWeek = dias_semana.Viernes Then
            Console.WriteLine("Dia de la semana: Viernes")
        Else
            Console.WriteLine("Dia de la semana: Sabado")
        End If

        Console.ReadKey()

    End Sub

End Module
