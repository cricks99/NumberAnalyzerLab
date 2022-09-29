string nameOfPerson, shouldContinue;
int chkNumber;

Console.Write("What is your name? ");
nameOfPerson = Console.ReadLine();

do
{
    Console.Write($"\nHi, {nameOfPerson}.  Enter a number between 1 and 100 (inclusive): ");

    do
    {
        chkNumber = Convert.ToInt32(Console.ReadLine());

        if (chkNumber < 1 || chkNumber > 100)
            Console.WriteLine($"{nameOfPerson}, the number is not between 1 and 100.  Try again.");
    }
    while (chkNumber < 1 || chkNumber > 100);

    if (chkNumber % 2 == 1)
    {
        if (chkNumber < 60)
            Console.WriteLine($"{chkNumber} is odd and less than 60");
        else if (chkNumber > 60)
            Console.WriteLine($"{chkNumber} is odd and greater than 60");
    }

    else
    {
        if (chkNumber >= 2 && chkNumber <= 24)
            Console.WriteLine($"{chkNumber} is even and less than 25");
        else if (chkNumber >= 26 && chkNumber <= 60)
            Console.WriteLine($"{chkNumber} is even and between 26 and 60 inclusive");
        else if (chkNumber > 60)
            Console.WriteLine($"{chkNumber} is even and greater than 60");
    }

    Console.WriteLine("\nWant to do this again?  Enter 'yes' if you do.");
    shouldContinue = Console.ReadLine();
 }
while (shouldContinue == "yes");

Console.WriteLine($"Have a great day, {nameOfPerson}!");
Console.ReadKey();
