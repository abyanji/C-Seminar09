Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int AllNumbersUpToSpec(int num, int count)
{
    if (count > num) return num;
    System.Console.Write($"{count} ");
    return AllNumbersUpToSpec(num, count + 1);
}

int number = DataEntry("Enter the number ");
int count = 1;
int allNumbers = AllNumbersUpToSpec(number, count);

