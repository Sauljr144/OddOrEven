//------Variables-----//

int num1;
bool isValid;
string playAgain = "Y";

//This will prompt the user to input a number and the program will store the input.

while(playAgain != "N")
{
    Console.WriteLine("Hello there! Please enter a number.");
    isValid = int.TryParse(Console.ReadLine(), out num1);

    if(!isValid)
    {
        Console.WriteLine("Please enter a valid number.");
    }

    else
    {
        //----Conditionals---//

        //This conditional will check if the number that was given is even or odd.
        //

        if(num1 % 2 == 0)
        {
            Console.WriteLine($"{num1} is an even number!");
        }


        else
        {
            Console.WriteLine($"{num1} is an odd number!");
        }

        Console.WriteLine("Do you want to play again? Y/N");
        playAgain = Console.ReadLine().ToUpper();
    }
}

Console.WriteLine("Bye!");