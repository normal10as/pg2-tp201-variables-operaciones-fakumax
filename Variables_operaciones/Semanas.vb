Module Semanas
    '1.8. Crear un módulo llamado semanas y en el declarar las siguientes constantes: días del año, días
    'laborables y días de la semana. Informar cuantas semanas tiene el año y cuantas semanas son
    'laborables.
    Sub main()
        Const dAnio As UShort = 365
        Const dLaborales As Byte = 5
        Const dSemana As Byte = 7
        Dim semanasAnio As UShort = dAnio \ dSemana
        Console.WriteLine("El Año tiene {0} semanas", semanasAnio)
        Console.WriteLine("El Año tiene {0} semanas laborables", (semanasAnio * dLaborales) \ dSemana)
        Console.ReadKey()

    End Sub
End Module
