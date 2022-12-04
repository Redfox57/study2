Console.Write("Please enter the number from 1 to 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Yes");
    } 
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("Number is out of the range!!!");
}