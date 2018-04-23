Module Concatenacion
    '1.4. Crear un módulo llamado concatenación y en el declarar variables para almacenar los siguientes
    'datos: nombre de la empresa, nombre de la calle, altura de la calle y fecha de inicio de
    'actividades. Mostrar los mismos concatenados en la salida de la consola dos veces: la primera
    'utilizando conversión explícita y la segunda conversión implícita.
    Sub main()
        Dim empresa As String = "OLX S.A"
        Dim calle As String = "algo street"
        Dim altura As UShort = "1234"
        Dim fecha As Date = "28/04/2017"
        Console.WriteLine(empresa & " " & calle & " " & altura & " " & fecha)
        Console.WriteLine(empresa + " " + calle + " " + Convert.ToString(altura) + " " + fecha)
        Console.ReadKey()


    End Sub
End Module
