// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("[A] para sumar \n [B] Restar \n [C] Multipricar \n [D] Dividir");
string x = Console.ReadLine();
string y = (x.ToLower());

int n1 = 11;
int n2 = 123;

switch (y)
{
    case "a":
        int result = n1 + n2;
        Console.WriteLine($"el resultado de la suma es {result}");
        break;
    case "b":
        int result2 = n1 - n2;
        Console.WriteLine($"el resultado de la resta es {result2}");
        break;
    case "c":
        int result3 = n1 * n2;
        Console.WriteLine($"el resultado de la multiplicasion es {result3}");
        break;
    case "d":
        float result4 = n1 / n2;
        Console.WriteLine($"el resultado de la division es {result4}");
        break;

    default:
        Console.WriteLine("este resultado no esta disponible");
        break;


}