// See https://aka.ms/new-console-template for more information
int num = int.Parse(Console.ReadLine());
int[] numArr = num.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
int sumOfFactorials = 0;

for (int i = 0; i < numArr.Length; i++)
{
    sumOfFactorials += Enumerable.Range(1, numArr[i]).Aggregate(1, (p, item) => p * item);
}

if (sumOfFactorials == num)
{
    Console.WriteLine("yes");
}

else
{
    Console.WriteLine("no");
}