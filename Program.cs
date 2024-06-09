// SCOPE
int number;
string? resNum;

static int Inverter(int num) {
    int n;
    string r="";

    while (num > 0) {
        n = num%10;
        num /= 10;
        r += n;
    }

    return Convert.ToInt32(r);
}

//MAIN
Console.WriteLine("Ingrese un número: ");
resNum = Console.ReadLine();

if (int.TryParse(resNum, out number) && number > 0) {
    int inverted_number = Inverter(number);

    Console.WriteLine(inverted_number);
} else Console.WriteLine("No se pudo, pa");
