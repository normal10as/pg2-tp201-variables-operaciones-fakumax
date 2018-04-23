Imports System.Math

Module Ejercicio_1_13
    '1.13. Elabore un programa que lea tres números y muestre el mayor.
    Sub main()
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim numero3 As Integer
        Dim aux As Integer
        Dim aux2 As Integer
        Console.Write("Ingrese el valor 1 : ")
        numero1 = Console.ReadLine()
        Console.Write("Ingrese el valor 2 : ")
        numero2 = Console.ReadLine()
        Console.Write("Ingrese el valor 3 : ")
        numero3 = Console.ReadLine()
        aux = Max(numero1, numero2)
        aux2 = Max(aux, numero3)
        Console.WriteLine("El valor mas grande es : " & aux2)
        Console.ReadKey()
    End Sub
End Module
