int num1;
int num2;
char symbol;
int result;

Console.Title = "CalculatorCSharp";

Console.Write("Enter num1 = ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Enter num2 = ");
num2 = int.Parse(Console.ReadLine());
Console.Write("Enter operation: ");
symbol = char.Parse(Console.ReadLine());

if (symbol == '+') 
{ 
    result = num1 + num2; 
    Console.WriteLine(result); 
}
else if (symbol == '-') 
{ 
    result = num1 - num2; 
    Console.WriteLine(result);
}
else if (symbol == '*') 
{ 
    result = num1 * num2; 
    Console.WriteLine(result); 
}
else if (symbol == '/') 
{ 
    result = num1 / num2; 
    Console.WriteLine(result);
}

Console.ReadLine();
