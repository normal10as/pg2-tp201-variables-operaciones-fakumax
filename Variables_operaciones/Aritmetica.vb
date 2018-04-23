Module Aritmetica
    '1.5. Crear un módulo llamado aritmética que declare y asigne dos valores enteros y dos valores de
    'punto flotante. Luego demostrar las operaciones aritméticas básicas mezclando los tipos de
    'datos utilizados y mostrar los resultados por consola previo un mensaje adecuado. Por ejemplo:
    'sumar entero con entero, entero con punto flotante y punto flotante con punto flotante'
    Sub Main()
        Dim entero1 As Byte = 4
        Dim entero2 As Byte = 2
        Dim flotante1 As Single = 4.2
        Dim flotante2 As Single = 2.2
        Console.WriteLine("La suma de enteros es :" & entero1 + entero2)
        Console.WriteLine("La resta de enteros es :" & entero1 - entero2)
        Console.WriteLine("La suma de flotantes es :" & flotante1 + flotante2)
        Console.WriteLine("La resta de flotantes es :" & flotante1 - flotante2)
        Console.WriteLine("La multiplicacion de enteros es :" & entero1 * entero2)
        Console.WriteLine("La division de enteros es :" & entero1 / entero2)
        Console.WriteLine("La multiplicacion de flotantes es :" & flotante1 * flotante2)
        Console.WriteLine("La division de flotantes es :" & flotante1 / flotante2)
        Console.WriteLine("La suma de flotantes y entero es :" & flotante1 + entero1)
        Console.WriteLine("La resta de flotantes y entero es :" & flotante1 - entero2)
        Console.WriteLine("La multiplicacion de flotantes y entero es :" & flotante1 * entero1)
        Console.WriteLine("La division de flotantes y entero es :" & flotante1 / entero1)

        Console.ReadKey()
    End Sub

End Module
