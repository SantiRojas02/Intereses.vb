Module Module1

    Sub Main(args As String())

        Dim m, r, t, i As Integer

        Console.Write("Ingrese Monto: ")
        m = Console.ReadLine()
        Console.Write("Ingrese Interes: ")
        r = Console.ReadLine()
        Console.Write("Ingrese dias: ")
        t = Console.ReadLine()

        i = m * r * t / 360 * 100

        Console.WriteLine("Intereses totales: " & i)

        Console.ReadKey()



    End Sub

End Module
