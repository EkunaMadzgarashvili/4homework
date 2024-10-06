#region Task1
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number % 5 == 0 ? "Yes" : "No");
#endregion

#region Task2

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int sum = firstNumber + secondNumber;
Console.WriteLine("The sum is " + sum);
double div = 0;
if (firstNumber >= secondNumber)
{
    int difference = firstNumber - secondNumber;
    Console.WriteLine("The difference is " + difference.ToString());
}
else if (firstNumber < secondNumber)
{
    int difference = secondNumber - firstNumber;
    Console.WriteLine("The difference is " + difference.ToString());
}
int prod = firstNumber * secondNumber;
Console.WriteLine("The product is " + prod.ToString());
if ((firstNumber >= secondNumber && secondNumber == 0) ||
    firstNumber < secondNumber && firstNumber == 0)
{
    Console.WriteLine("Error");
}
else
{
    if (firstNumber >= secondNumber)
    {
        div = firstNumber / secondNumber;
    }
    else
    {
        div = secondNumber / firstNumber;
    }
    Console.WriteLine("The division is " + div.ToString());
}

#endregion

#region Task3

string x = Console.ReadLine();
string y = Console.ReadLine();
string tmp = x;
x = y;
y = tmp;
Console.WriteLine("X changed to " + x);
Console.WriteLine("Y changed to " + y);

#endregion

#region Task4
int n = int.Parse(Console.ReadLine());
int m = 1;
while (m < 10)
{
    int nm = n * m;
    Console.WriteLine($"{n} * {m} = {nm}");
    m++; ;
}

#endregion

#region Task5
int k = int.Parse(Console.ReadLine());
int start = 1;
while (start <= k)
{
    if (start % 2 == 0)
    {
        Console.WriteLine(start.ToString());

    }
    start++;
}
#endregion






