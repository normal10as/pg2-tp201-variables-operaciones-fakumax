Module Ejercicio_1_15
    '1.15. Crear un programa que lea separadamente un número de día (1 a 31) y una hora (0 a 24).
    'Con esos valores crea una variable de tipo Date usando el mes y año actual y mostrarla.
    Sub main()
        Dim fecha As Date
        Dim aux As Byte
        Dim aux2 As Byte
        Console.Write("Ingrese una cantidad de días de 1 a 31 : ")
        aux = Console.ReadLine
        fecha = Now.AddDays(aux)
        Console.Write("Ingrese una hora de 0 a 24 : ")
        aux2 = Console.ReadLine
        fecha = fecha.AddHours(aux2)
        Console.WriteLine(fecha)
        Console.ReadKey()

    End Sub
End Module
