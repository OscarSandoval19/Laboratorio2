int num1, num2;


Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());


Console.WriteLine($"{num1} > {num2} = {num1 > num2}");
Console.WriteLine($"{num1} < {num2} = {num1 < num2}");
Console.WriteLine($"{num1} == {num2} = {num1 == num2}");


Console.WriteLine($"({num1} > 0 && {num2} > 0) = {(num1 > 0 && num2 > 0)}");
Console.WriteLine($"({num1} > 0 || {num2} > 0) = {(num1 > 0 || num2 > 0)}");