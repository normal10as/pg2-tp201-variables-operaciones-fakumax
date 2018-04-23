Imports System.Math

Module Ejercicio_1_11
    '1.11. Ingresar un número por teclado y mostrar su valor absoluto, el resultado de elevarlo a la
    'décima potencia y su raíz cuadrada.

    Sub main()
        Dim numero As Integer
        Dim valorAbsoluto As Integer

        Console.Write("Ingrese un valor : ")
        numero = Console.ReadLine
        valorAbsoluto = Abs(numero)
        Console.WriteLine("El valor absoluto es : " & valorAbsoluto)
        Console.WriteLine("El valor a la decima potencia es : " & Log10(valorAbsoluto))
        Console.WriteLine("El valor de la raiz es : " & Sqrt(valorAbsoluto))
        Console.ReadKey()

    End Sub
End Module
