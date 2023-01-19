// See https://aka.ms/new-console-template for more information
int countOfOrders = int.Parse(Console.ReadLine());

double pricePerCapsule = 0;
int daysInMonth = 0;
int capsulesCount = 0;

var orderList = new List<dynamic>();

for (int i = 0; i < countOfOrders; i++)
{
    pricePerCapsule = double.Parse(Console.ReadLine());
    daysInMonth = int.Parse(Console.ReadLine());
    capsulesCount = int.Parse(Console.ReadLine());

    orderList.Add(((daysInMonth * capsulesCount) * pricePerCapsule));
    Console.WriteLine($"The price for the coffee is: ${orderList[i]:f2}");
}

double totalPrice = 0;

for (int i = 0; i < countOfOrders; i++)
{
    totalPrice += orderList[i];
}

Console.WriteLine($"Total: ${totalPrice:f2}");