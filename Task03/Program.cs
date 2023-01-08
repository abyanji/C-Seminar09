Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SumOfAllNumbers(int num, int sum)
{
    if (num == 0) return sum;
    sum += num;
    return SumOfAllNumbers(num - 1, sum);
}

int number = DataEntry("Enter the number ");
int sum = 0;
sum = SumOfAllNumbers(number, sum);
System.Console.WriteLine(sum);
