Module Ejercicio_1_10
    Sub main()
        '1.10. Realizar un programa que dé como resultado los intereses producidos y el capital
        ' acumulado de un monto m invertido a un interés anual r durante t días. La fórmula utilizada es
        'I = (m ∗ r * t) / (360*100)
        'donde I es el interés producido. Ingresar por teclado el monto, el interés y el tiempo.
        Dim monto As Integer
        Dim interesAnual As Integer
        Dim tiempoDias As Integer
        Dim interesTotal As Integer
        Console.Write("Ingrese el monto :")
        monto = Console.ReadLine()
        Console.Write("Ingrese el interes anual :")
        interesAnual = Console.ReadLine()
        Console.Write("Ingrese los dias :")
        tiempoDias = Console.ReadLine()
        interesTotal = (monto * interesAnual * tiempoDias) / (360 * 100)
        Console.WriteLine("El interes producido es de : " & interesTotal)
        Console.ReadKey()
    End Sub
End Module
