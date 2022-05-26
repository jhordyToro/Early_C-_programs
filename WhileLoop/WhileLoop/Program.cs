// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool continueSoftwareExecution = false;
do
{
    Console.WriteLine("Do you wish to keep the software running? Write 1 if yes, 0 if not");
    int keepGoing = Convert.ToInt16(Console.ReadLine());
    if (keepGoing == 1) {
        Console.WriteLine("Hello World! the Software will keep running");
        continueSoftwareExecution = true;
    }
    else if (keepGoing == 0) {
        Console.WriteLine("the software not will keep running");
        continueSoftwareExecution = false;
    }
    else
        Console.WriteLine("not available");
} while (continueSoftwareExecution == true);