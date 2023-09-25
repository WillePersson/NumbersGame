namespace NumbersGame //Wille Persson - NET23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int min = 1;
            int max = 20;
            int guess = 0;
            int number;
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer." +
                "Kan du gissa vilket? Du får fem försök.");


            number = random.Next(min, max + 1);

            while (guess != number && !outOfGuesses)
            {
                guess = Convert.ToInt32(Console.ReadLine());


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
                if (guessCount < guessLimit)
                {

                }
                else
                {
                    outOfGuesses = true;

                }
            }
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