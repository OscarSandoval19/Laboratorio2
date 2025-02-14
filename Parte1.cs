int numeroEntero;
double numeroDecimal;
string texto;
bool valorBooleano;


Console.Write("Ingrese un número entero: ");
numeroEntero = int.Parse(Console.ReadLine());

Console.Write("Ingrese un número decimal: ");
numeroDecimal = double.Parse(Console.ReadLine());

Console.Write("Ingrese un texto: ");
texto = Console.ReadLine();

Console.Write("Ingrese un valor verdadero o falso: ");
valorBooleano = bool.Parse(Console.ReadLine());


Console.WriteLine("\nValores ingresados:");
Console.WriteLine($"Número entero: {numeroEntero}");
Console.WriteLine($"Número decimal: {numeroDecimal}");
Console.WriteLine($"Texto: {texto}");
Console.WriteLine($"Valor booleano: {valorBooleano}");
