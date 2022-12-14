Console.Write("Please enter 3 digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int amount = num.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("You entered a non-three-digit number");
}
else
int ShowMidNum(int num)
{
    int remain = number % 100;
    return remain / 10;
}

Console.WriteLine(ShowMidNum(num));