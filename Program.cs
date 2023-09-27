using System.Reflection.PortableExecutable;

namespace NumbersGame //Wille Persson - NET23
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random random = new Random(); //stores ramdóm number
            int min = 1;  // min number
            int max = 20; // max number
            int guess = 0; // guess
            int number;  //number 
            int guessCount = 0;  //checks the guesses
            int guessLimit = 5;  //max guesses
            bool outOfGuesses = false; // tells us if the user has guesses left
            
            Console.WriteLine("Välkommen! Jag tänker på ett nummer." +
                "Kan du gissa vilket? Du får fem försök.");

            // generate new randoom number bettwen one and twenty
            number = random.Next(min, max + 1);


            // makes it so the user can guess while the guess is not equal to
            //the random number and also as long they are not out of guesses
            while (guess != number && !outOfGuesses)
            {
                // converting the guess user put in so the console can read it
                guess = Convert.ToInt32(Console.ReadLine());
                
                // if guess is more or less from the random number it will tell 
                //the user and also make the guess + 1
                if (guess > number)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    guessCount++;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    guessCount++;
                }
                // checking if the guess count is less than the guess limit
                // if not it will go the the else and it will be true
                if (guessCount < guessLimit)
                {

                }
                else
                {
                    outOfGuesses = true;

                }
            }
            // if the user used all the guessess it will tell them that they failed in 5 
            // guesses, else it will tell them that they got the right number
            if (outOfGuesses)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");

            }
            else
            {

                Console.WriteLine("Wohoo! Du klarade det!");

            }
        }
    }
}