Module Concatenacion
    Sub Main()
        Dim NombreEmpresa As String = "YoQueSe S.A."
        Dim NombreCalle As String = "Corrientes"
        Dim AlturaCalle As UShort = 2650
        Dim FechInicioActividades As Date = "23 / 3 / 18"
        Console.WriteLine("Nombre:" + NombreEmpresa + " Calle:" + NombreCalle + " Altura Calle:" + Convert.ToString(AlturaCalle) + " Fecha Inicio:" + Convert.ToString(FechInicioActividades))
        Console.WriteLine("Nombre:" & NombreEmpresa & " Calle:" & NombreCalle & " Altura Calle:" & AlturaCalle & " Fecha Inicio: " & FechInicioActividades)
        Console.ReadKey()
    End Sub

End Module
