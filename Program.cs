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

float A, B;

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