// See https://aka.ms/new-console-template for more information
int countOfPeopleInput = int.Parse(Console.ReadLine());
string typeOfGroupInput = Console.ReadLine();
string dayOfWeekInput = Console.ReadLine();
double singlePersonPrice = 0;
double totalPrice = 0;

if (dayOfWeekInput == "Friday")
{
    switch (typeOfGroupInput)
    {
        case "Students":
            singlePersonPrice = 8.45;
            break;
        case "Business":
            singlePersonPrice = 10.90;
            break;
        case "Regular":
            singlePersonPrice = 15;
            break;
    }   
}
if (dayOfWeekInput == "Saturday")
{
    switch (typeOfGroupInput)
    {
        case "Students":
            singlePersonPrice = 9.80;
            break;
        case "Business":
            singlePersonPrice = 15.60;
            break;
        case "Regular":
            singlePersonPrice = 20;
            break;
    }
}
if (dayOfWeekInput == "Sunday")
{
    switch (typeOfGroupInput)
    {
        case "Students":
            singlePersonPrice = 10.46;
            break;
        case "Business":
            singlePersonPrice = 16;
            break;
        case "Regular":
            singlePersonPrice = 22.50;
            break;
    }
}

totalPrice = countOfPeopleInput * singlePersonPrice;

if (countOfPeopleInput >= 30 && typeOfGroupInput == "Students")
{
    totalPrice *= 0.85;
}

if (countOfPeopleInput >= 100 && typeOfGroupInput == "Business")
{
    totalPrice -= singlePersonPrice * 10;
}

if (countOfPeopleInput >= 10 && countOfPeopleInput <= 20 && typeOfGroupInput == "Regular")
{
    totalPrice *= 0.95;
}

Console.WriteLine($"Total price: {totalPrice:f2}");
