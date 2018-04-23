Module Ejercicio_1_14
    '1.14. Crear un programa que muestre en líneas diferentes con sus correspondientes títulos los
    'siguientes valores en el momento de la ejecución: día del año, mes, hora y minuto
    Sub main()

        Console.WriteLine("El dia de hoy es :" & Now.Day)
        Console.WriteLine("El mes en el que estamos es :" & Now.Month)
        Console.WriteLine("Son las {0} con {1} minutos ", Now.Hour, Now.Minute)
        Console.ReadKey()

    End Sub
End Module
