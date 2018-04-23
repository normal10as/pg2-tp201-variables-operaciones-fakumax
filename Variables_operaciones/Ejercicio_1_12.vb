Imports System.Math

Module Ejercicio_1_12
    '1.12. Ingresar un número real por teclado y mostrar su valor aproximado por exceso, su valor
    'aproximado por defecto y su valor redondeado.
    Sub main()
        Dim numeroReal As Single
        Dim otro As Single
        Console.Write("Ingrese un valor : ")
        numeroReal = Console.ReadLine
        otro = Floor(numeroReal)
        Console.Write("Su valor por exceso es de :" + Convert.ToString(otro))
        Console.ReadKey()

    End Sub
End Module
