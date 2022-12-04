Console.Write("Please, enter the integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} yes");
}
else 
{
    Console.WriteLine($"{num} no");
}