Module Ejercicio_1_09
    '1.9. Crear un programa que muestre las tablas de verdad booleanas (And, Or, Not y Xor)
    Sub main()
        Dim x As Boolean = True
        Dim p As Boolean = False
        Console.WriteLine("Tabla AND")
        Console.WriteLine(x And x)
        Console.WriteLine(x And p)
        Console.WriteLine(p And x)
        Console.WriteLine(p And p)
        Console.WriteLine("Tabla OR")
        Console.WriteLine(x Or x)
        Console.WriteLine(x Or p)
        Console.WriteLine(p Or x)
        Console.WriteLine(p Or p)
        Console.WriteLine("Tabla NOT")
        Console.WriteLine(x And (Not p))
        Console.WriteLine((Not x) And p)
        Console.WriteLine(p And x)
        Console.WriteLine((Not x) And (Not p))
        Console.WriteLine("Tabla XOR")
        Console.WriteLine(x Xor x)
        Console.WriteLine(x Xor p)
        Console.WriteLine(p Xor x)
        Console.WriteLine(p Xor p)
        Console.ReadKey()
    End Sub
End Module
