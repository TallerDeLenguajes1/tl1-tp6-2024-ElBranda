float A, B;

while (true) {
    Console.WriteLine("Elija la operación:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Op: ");

    if (int.TryParse(Console.ReadLine(), out int sel)) {
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
            case 1: Console.WriteLine(A+B); break;
            case 2: Console.WriteLine(A-B); break;
            case 3: Console.WriteLine(A*B); break;
            case 4: Console.WriteLine(A/B); break;
        }

        Console.WriteLine();
        break;
    } else Console.WriteLine("Entrada incorrecta");
}


float num;

while (true) {
    Console.Write("Ingrese un número: ");

    if (float.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out num)) break;
    else Console.WriteLine("Entrada incorrecta...");
}

Console.WriteLine("Absoluto: " + Math.Abs(num));
Console.WriteLine("Cuadrado: " + Math.Pow(num,2));
Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num));
Console.WriteLine("Seno: " + Math.Sin(num));
Console.WriteLine("Coseno: " + Math.Cos(num));
Console.WriteLine("Entero: " + Math.Ceiling(num));

while (true) {
    Console.Write("Ingrese A: ");

    if (float.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out A)) break;
    else Console.WriteLine("Entrada incorrecta...");
}

while (true) {
    Console.Write("Ingrese B: ");

    if (float.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out B)) break;
    else Console.WriteLine("Entrada incorrecta...");
}

Console.WriteLine("Mayor: " + Math.Max(A, B));
Console.WriteLine("Menor: " + Math.Min(A, B));