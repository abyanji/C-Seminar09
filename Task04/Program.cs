Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SumOfAllNumbers(int num, int deg, int zero)
{
    
    if (deg == 1) return num;
    num = num * zero;
    return SumOfAllNumbers(num , deg - 1, zero);
}

int number = DataEntry("Enter the number ");
int numberZero = number;
int degree = DataEntry("Enter the degree ");
int sum = SumOfAllNumbers(number, degree, numberZero);
System.Console.WriteLine(sum);