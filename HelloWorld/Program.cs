Console.WriteLine("Hello, to calculator app!");
int num1 = 0;
int num2 = 0;
Console.WriteLine("console calculator in c#\r");
Console.WriteLine("-------------------------\n");
Console.WriteLine("type a number, and then press enter");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("type an other number, and then press enter");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Substract");
Console.WriteLine("\tm - multiply");
Console.WriteLine("\td - divide");
Console.Write("your option ?");
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"your result: {num1} / {num2} = " + (num1 / num2));
        break;
}
Console.WriteLine("press any key to close the calculator console app ...");
Console.ReadKey();

