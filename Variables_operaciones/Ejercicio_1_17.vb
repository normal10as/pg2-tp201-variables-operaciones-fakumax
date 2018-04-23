Module Ejercicio_1_17
    '1.17. Al programa anterior (1.16), utilizando una enumeración para los días de la semana en
    'español, mostrar que día que corresponde al resultado.
    Enum dSemanas As Integer
        Domingo = 1
        Lunes = 2
        Martes = 3
        Miercoles = 4
        Jueves = 5
        Viernes = 6
        Sabado = 7

    End Enum


    Sub main()
        Dim fecha As Date
        Dim dias As Byte
        Dim semanadia As Byte
        Dim diaSemana As String = ""
        Console.Write("Ingrese una fecha : ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese los dias que desea añadir : ")
        dias = Console.ReadLine()
        fecha = fecha.AddDays(dias)
        semanadia = Weekday(fecha)

        Select Case semanadia

            Case dSemanas.Lunes
                diaSemana = "Lunes"
            Case dSemanas.Martes
                diaSemana = "Martes"
            Case dSemanas.Miercoles
                diaSemana = "Miercoles"
            Case dSemanas.Jueves
                diaSemana = "Jueves"
            Case dSemanas.Viernes
                diaSemana = "Viernes"
            Case dSemanas.Sabado
                diaSemana = "Sábado"
            Case dSemanas.Domingo
                diaSemana = "Domingo"

        End Select

        Console.WriteLine("La fecha final seria '{0}' y hoy es '{1}' ", fecha.ToString("dd/MM/yyyy"), diaSemana)
        Console.ReadKey()

    End Sub
End Module
