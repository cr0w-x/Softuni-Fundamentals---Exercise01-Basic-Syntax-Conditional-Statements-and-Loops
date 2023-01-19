// See https://aka.ms/new-console-template for more information
double ownedMoney = double.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());
double pricePerLightSaber = double.Parse(Console.ReadLine());
double pricePerRobe = double.Parse(Console.ReadLine()); 
double pricePerBelt = double.Parse(Console.ReadLine());

int freeBelts = 0;
double totalMoneyNeeded = 0;

for (int i = 1; i <= countOfStudents; i++)
{
    if (i % 6 == 0)
    {
        freeBelts++;
    }
}

totalMoneyNeeded = pricePerLightSaber * Math.Ceiling(countOfStudents * 1.10) + pricePerRobe * countOfStudents + pricePerBelt * (countOfStudents - freeBelts);

if (totalMoneyNeeded <= ownedMoney)
{
    Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:f2}lv.");
}

else
{
    Console.WriteLine($"John will need {Math.Abs(totalMoneyNeeded - ownedMoney):f2}lv more.");
}
