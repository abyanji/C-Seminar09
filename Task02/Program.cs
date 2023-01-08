Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int AllNumbersFromSpecToSpec(int numOne, int numTwo)
{
    if (numTwo > numOne) return numOne;
    System.Console.Write($"{numTwo} ");
    return AllNumbersFromSpecToSpec(numOne, numTwo + 1);
}

int numberOne = DataEntry("Enter the number ");
int numberTwo = DataEntry("Enter the number ");
int allNumbers = AllNumbersFromSpecToSpec(numberOne, numberTwo);
