// See https://aka.ms/new-console-template for more information
int lostGamesCount = int.Parse(Console.ReadLine());
double headSetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());   
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int headSetCrashCount = 0;
int mouseCrashCount = 0;
int keyboardCrashCount = 0;
int displayCrashCount = 0;

for (int i = 1; i <= lostGamesCount; i++)
{
    if (i % 2 == 0)
        headSetCrashCount++;
    if (i % 3 == 0)
        mouseCrashCount++;
    if (i % 6 == 0)
        keyboardCrashCount++;
}

if (keyboardCrashCount >= 2)
    displayCrashCount= keyboardCrashCount/2;

double rageExpenses = headSetPrice * headSetCrashCount + mousePrice* mouseCrashCount + keyboardPrice * keyboardCrashCount + displayPrice * displayCrashCount;

Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
