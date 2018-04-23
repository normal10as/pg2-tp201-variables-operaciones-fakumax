Module Sumatoria
    '1.7. Crear un programa que calcule la sumatoria y la media de cuatro números enteros ingresados
    'por teclado.
    Sub main()
        Dim numero1, numero2, numero3, numero4 As Integer
        Dim sumatoria As Integer
        Console.WriteLine("Ingrese un valor")
        numero1 = Console.ReadLine()
        Console.WriteLine("Ingrese otro valor")
        numero2 = Console.ReadLine()
        Console.WriteLine("Ingrese otro valor")
        numero3 = Console.ReadLine()
        Console.WriteLine("Ingrese otro valor")
        numero4 = Console.ReadLine()
        sumatoria = numero1 + numero2 + numero3 + numero4
        Console.WriteLine("La sumatoria es : {0} y la media es :{1} ", sumatoria, (sumatoria / 4))
        Console.ReadKey()


    End Sub
End Module
