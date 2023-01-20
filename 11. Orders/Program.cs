// See https://aka.ms/new-console-template for more information
int countOfOrders = int.Parse(Console.ReadLine());

double pricePerCapsule = 0;
int daysInMonth = 0;
int capsulesCount = 0;

double totalPrice = 0;

for (int i = 0; i < countOfOrders; i++)
{
    pricePerCapsule = double.Parse(Console.ReadLine());
    daysInMonth = int.Parse(Console.ReadLine());
    capsulesCount = int.Parse(Console.ReadLine());

    double tempVar = 0;
    tempVar = ((daysInMonth * capsulesCount) * pricePerCapsule);
    Console.WriteLine($"The price for the coffee is: ${tempVar:f2}");
    totalPrice += tempVar;
}

Console.WriteLine($"Total: ${totalPrice:f2}");