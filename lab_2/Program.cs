Console.Write("Enter the 1st number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 2nd number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 3rd number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"Max number is: {n1}");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"Max number is: {n2}");
} 
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"Max number is: {n3}");
}
else
{
    Console.WriteLine("Numbers are equal");
}