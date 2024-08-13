namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumberGuessGame();
        }

        public static void NumberGuessGame()

        {
            Random r = new Random();
            int favoriteNumber = r.Next(1, 20);
            Console.WriteLine("Hello. Please Pick a number from 1 to 1000: ");
            int userInput;

            do
            {
                
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favoriteNumber)
                {
                    Console.WriteLine($"the number {userInput} is too low");
                }

                else if (userInput > favoriteNumber)
                {
                    Console.WriteLine($"the number {userInput} is too high");
                }

                else
                {
                    Console.WriteLine("Congrats. You guessed the number");
                }

            } while (userInput != favoriteNumber);


        }
    }
}
