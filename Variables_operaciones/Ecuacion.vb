Module Ecuacion
    '1.6. Crear un programa que resuelva la siguiente ecuación x = b^2-4*a*c/2*a
    ' donde a=1, b=5 y c=2.
    'Mostrar el resultado obtenido.

    Sub main()
        Dim a As Byte = 1
        Dim b As Byte = 5
        Dim c As Byte = 2
        Console.WriteLine("El resultado es : " & (b ^ 2 - 4 * a * c) / (2 * a))
        Console.ReadKey()

    End Sub
End Module
