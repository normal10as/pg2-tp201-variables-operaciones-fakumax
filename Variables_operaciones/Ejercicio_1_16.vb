Module Ejercicio_1_16
    '1.16. Crear un programa que se ingrese una fecha y un número dados de días, Mostrar como
    'resultado la fecha obtenida de sumar la cantidad de días a la fecha dada.
    Sub main()
        Dim fecha As Date
        Dim dias As Byte
        Console.Write("Ingrese una fecha : ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese los dias que desea añadir : ")
        dias = Console.ReadLine()
        fecha = fecha.AddDays(dias)
        Console.WriteLine("La fecha final seria : " & fecha)
        Console.ReadKey()
    End Sub

End Module
