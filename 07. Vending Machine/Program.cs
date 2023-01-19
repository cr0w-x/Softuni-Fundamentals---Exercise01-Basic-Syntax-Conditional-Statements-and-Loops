// See https://aka.ms/new-console-template for more information
double totalCoins = 0;
string input = string.Empty;
string input2 = string.Empty;

double nutsPrice = 2;
double waterPrice = 0.7;
double crispsPrice = 1.5;
double sodaPrice = 0.8;
double cokePrice = 1;

do
{
    input = Console.ReadLine();
    double.TryParse(input, out double tempNum);
    if (tempNum == 0.1 || tempNum == 0.2 || tempNum == 0.5 || tempNum == 1 || tempNum == 2)
    {
        totalCoins += tempNum;
    }

    else if (input == "Start")
        continue;

    else
    {
        Console.WriteLine($"Cannot accept {input}");
    }

} while (input != "Start");

do
{
    input2 = Console.ReadLine();
    if (input2 == "Nuts")
    {
        if (totalCoins >= nutsPrice)
        {
            Console.WriteLine($"Purchased nuts");
            totalCoins -= nutsPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input2 == "Water")
    {
        if (totalCoins >= waterPrice)
        {
            Console.WriteLine($"Purchased water");
            totalCoins -= waterPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input2 == "Crisps")
    {
        if (totalCoins >= crispsPrice)
        {
            Console.WriteLine($"Purchased crisps");
            totalCoins -= crispsPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }

    }
    else if (input2 == "Soda")
    {
        if (totalCoins >= sodaPrice)
        {
            Console.WriteLine($"Purchased soda");
            totalCoins -= sodaPrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }

    }
    else if (input2 == "Coke")
    {
        if (totalCoins >= cokePrice)
        {
            Console.WriteLine($"Purchased coke");
            totalCoins -= cokePrice;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }

    }
    else if (input2 == "End")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
} while (input2 != "End");

Console.WriteLine($"Change: {totalCoins:f2}");
