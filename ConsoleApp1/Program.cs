namespace TextBasedAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string playerName = "";

            Console.WriteLine("What is your name?");

            input = Console.ReadLine();

            playerName = input;

            Console.WriteLine("Hello " + playerName + ", how are you today?");

            Console.ReadLine();
        }
    }
}
