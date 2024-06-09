while (true) {
    Console.WriteLine("Elija la operación:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Salir");
    Console.Write("Op: ");

    if (int.TryParse(Console.ReadLine(), out int sel) && sel >= 0 && sel <= 4) {
        if (sel == 0) break;

        float A, B;

        while (true) {
            Console.Write("Ingrese número A: ");

            if (!float.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out A)) Console.WriteLine("Entrada incorrecta");
            else break;
        }

        while (true) {
            Console.Write("Ingrese número B: ");

            if (!float.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out B)) Console.WriteLine("Entrada incorrecta");
            else break;
        }

        Console.Write("Resultado: ");

        switch (sel) {
            case 2: Console.WriteLine(A-B); break;
            case 3: Console.WriteLine(A*B); break;
            case 4: Console.WriteLine(A/B); break;
            default: Console.WriteLine(A+B); break;
        }

        Console.WriteLine();
    } else Console.WriteLine("Entrada incorrecta");
}

