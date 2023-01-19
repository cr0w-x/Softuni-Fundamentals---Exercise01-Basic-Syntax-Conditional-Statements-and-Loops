// See https://aka.ms/new-console-template for more information
int startingNumber = int.Parse(Console.ReadLine());
int endingNumber = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = startingNumber; i <= endingNumber; i++)
{
    sum+= i;
    Console.Write($"{i} ");
}

Console.WriteLine();
Console.WriteLine($"Sum: {sum}");