// See https://aka.ms/new-console-template for more information
string inputUserName = Console.ReadLine();
string password = new string(inputUserName.Reverse().ToArray());
string inputPwd = Console.ReadLine();
int cntr = 0;

while (inputPwd != password)
{           

    if (cntr == 3)
    {
        Console.WriteLine($"User {inputUserName} blocked!");
        return;
    }
    
    inputPwd = Console.ReadLine();
    cntr++;
    Console.WriteLine("Incorrect password. Try again.");
}

if (inputPwd == password)
{
    Console.WriteLine($"User {inputUserName} logged in.");
    return;
}
