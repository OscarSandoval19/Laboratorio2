int num1, num2;
float numFloat1, numFloat2;
decimal numDecimal1, numDecimal2;
short numShort1, numShort2;
byte numByte1, numByte2;


Console.Write("Ingrese el primer número entero: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número entero: ");
num2 = int.Parse(Console.ReadLine());


Console.WriteLine($"Suma (int): {num1} + {num2} = {num1 + num2}");
Console.WriteLine($"Resta (int): {num1} - {num2} = {num1 - num2}");
Console.WriteLine($"Multiplicación (int): {num1} * {num2} = {num1 * num2}");
Console.WriteLine($"División (int): {num1} / {num2} = {(double)num1 / num2}");


Console.Write("Ingrese el primer número flotante: ");
numFloat1 = float.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número flotante: ");
numFloat2 = float.Parse(Console.ReadLine());


Console.WriteLine($"Suma (float): {numFloat1} + {numFloat2} = {numFloat1 + numFloat2}");
Console.WriteLine($"Resta (float): {numFloat1} - {numFloat2} = {numFloat1 - numFloat2}");
Console.WriteLine($"Multiplicación (float): {numFloat1} * {numFloat2} = {numFloat1 * numFloat2}");
Console.WriteLine($"División (float): {numFloat1} / {numFloat2} = {numFloat1 / numFloat2}");


Console.Write("Ingrese el primer número decimal: ");
numDecimal1 = decimal.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número decimal: ");
numDecimal2 = decimal.Parse(Console.ReadLine());


Console.WriteLine($"Suma (decimal): {numDecimal1} + {numDecimal2} = {numDecimal1 + numDecimal2}");
Console.WriteLine($"Resta (decimal): {numDecimal1} - {numDecimal2} = {numDecimal1 - numDecimal2}");
Console.WriteLine($"Multiplicación (decimal): {numDecimal1} * {numDecimal2} = {numDecimal1 * numDecimal2}");
Console.WriteLine($"División (decimal): {numDecimal1} / {numDecimal2} = {numDecimal1 / numDecimal2}");


Console.Write("Ingrese el primer número short: ");
numShort1 = short.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número short: ");
numShort2 = short.Parse(Console.ReadLine());


Console.WriteLine($"Suma (short): {numShort1} + {numShort2} = {numShort1 + numShort2}");
Console.WriteLine($"Resta (short): {numShort1} - {numShort2} = {numShort1 - numShort2}");
Console.WriteLine($"Multiplicación (short): {numShort1} * {numShort2} = {numShort1 * numShort2}");
Console.WriteLine($"División (short): {numShort1} / {numShort2} = {(double)numShort1 / numShort2}");


Console.Write("Ingrese el primer número byte: ");
numByte1 = byte.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número byte: ");
numByte2 = byte.Parse(Console.ReadLine());


Console.WriteLine($"Suma (byte): {numByte1} + {numByte2} = {numByte1 + numByte2}");
Console.WriteLine($"Resta (byte): {numByte1} - {numByte2} = {numByte1 - numByte2}");
Console.WriteLine($"Multiplicación (byte): {numByte1} * {numByte2} = {numByte1 * numByte2}");
Console.WriteLine($"División (byte): {numByte1} / {numByte2} = {(double)numByte1 / numByte2}");
