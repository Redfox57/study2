Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Max number is: {a}");
}
else if (a < b)
{
    Console.WriteLine($"Max number is: {b}");
} 
else 
{
    Console.WriteLine("Numbers are equal");
}