/*
*Validar si es usuario existente o si se debe registrar 
*El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
*el programa debe repetirse  hasta que se registren las 10 personas
*/

namespace Restaurant10TablesReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] {"","", "", "", "", "", "", "", "", ""};
            int arrayCurrenIndex = 0;
            bool userType;

            Console.WriteLine("welcome to the best restaurant in the world!");
            while (arrayCurrenIndex < 10)
            {   
                Console.WriteLine("Are you a register user? Write true, or write false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                
                // if (arrayCurrenIndex == 10)
                // {
                //     Console.WriteLine("the restaurant is full,try again next year");
                //     Environment.Exit(0);
                // }
                if (userType == true)
                { 
                    Console.WriteLine("hi, you are a register user, please enter your exact user name");
                    string userToSearch = Console.ReadLine();
                    int index = Array.IndexOf(userNames, userToSearch);
                    if(index == -1)
                    {
                        Console.WriteLine("no user not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine($"welcome {userNames[index]}");
                    }
                }
                else if (userType == false) 
                {
                    Console.WriteLine("please write and remember your user name");
                    userNames[arrayCurrenIndex] = Console.ReadLine();
                    Console.WriteLine("your user has been saved successfully \n" + "your name is: " + userNames[arrayCurrenIndex]);
                    arrayCurrenIndex++;
                }
            }
            Console.WriteLine("the restaurant is full, try it next year.");
            foreach (string item in userNames)
            {
                Console.WriteLine($"name user: {item}");
            }

        }
    }
}