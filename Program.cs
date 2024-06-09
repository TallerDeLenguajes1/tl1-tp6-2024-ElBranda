using System.Diagnostics.CodeAnalysis;

string? cadena1, cadena2;

Console.Write("Ingrese una cadena de texto: ");
cadena1 = Console.ReadLine();

Console.WriteLine($"El tamaño de la cadena es: {cadena1?.Length}");

Console.Write("Ingrese otra cadena de texto: ");
cadena2 = Console.ReadLine();

Console.WriteLine($"Cadenas concatenadas: {string.Concat(cadena1, cadena2)}");
Console.WriteLine($"Subcadena de la segunda cadena: " + cadena2?[..^3]);

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

        switch (sel) {
            case 1: Console.WriteLine("La suma de "+A+" y de "+B+" es igual a: "+(A+B)); break;
            case 2: Console.WriteLine("La resta de "+A+" y de "+B+" es igual a: "+(A-B)); break;
            case 3: Console.WriteLine("La multiplicación de "+A+" y de "+B+" es igual a: "+(A*B)); break;
            case 4: Console.WriteLine("La división de "+A+" y de "+B+" es igual a: "+(A/B)); break;
        }

        Console.WriteLine();
        break;
    } else Console.WriteLine("Entrada incorrecta");
}

foreach (char i in (cadena1 == null ? "" : cadena1)) {
    Console.WriteLine(i);
}

Console.WriteLine(cadena1?.StartsWith("hola"));
Console.WriteLine(cadena1?.ToUpper());
Console.WriteLine(cadena1?.ToLower());

string? s = Console.ReadLine();

string[] ss = s.Split();

string? ecuacion = Console.ReadLine();
string signos="";

foreach (char el in ecuacion) {
    if (el == '+' || el == '-' || el == '*' || el == '/') signos+=el;
}

string[] ec = ecuacion.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);

int index =-1;
float sum=0;

Console.WriteLine(signos);

foreach (string el in ec) {
    if (index==-1) {
        sum += float.Parse(el);
    }
    else {
        switch (signos[index]) {
            case '+': sum += float.Parse(el); break;
            case '-': sum -= float.Parse(el); break;
            case '*': sum *= float.Parse(el); break;
            case '/': sum /= float.Parse(el); break;
        }
    }
    index++;
}

Console.WriteLine(sum);