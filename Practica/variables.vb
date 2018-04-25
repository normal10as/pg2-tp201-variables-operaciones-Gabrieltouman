Module variables

    Public nombre As String = "Gabriel"
    Friend DNI As String = "D.N.I."
    Friend numero As String = "32.818.140"
    Friend FechaNacimiento As Date = "21 / 5 / 87"
    Private localidad As String = "Posadas"

    Sub Main()
        Dim FechaNacimiento As Date = "21 / 5 / 87"
        Dim edad As Byte = 35
        Dim altura As Single = 1.88
        Dim EstCivil As String = "Soltero"
        Dim Argentino As Boolean = True
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine(DNI & ":" & numero)
        Console.WriteLine("Localidad: " & localidad)
        Console.WriteLine("Fecha De Nacimiento:" & FechaNacimiento)
        Console.WriteLine("Edad: " & edad)
        Console.WriteLine("Altura: " & altura)
        Console.WriteLine("Estado Civil: " & EstCivil)
        Console.WriteLine("Argentino: " & Argentino)
        Console.ReadKey()
    End Sub

End Module
