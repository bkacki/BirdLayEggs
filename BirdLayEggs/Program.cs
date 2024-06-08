namespace BirdLayEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Bird bird;
                Console.Write("\nWciśnij [G]ołąb lub [S]truś: ");
                char keyChar = Char.ToUpper(Console.ReadKey().KeyChar);

                if (keyChar == 'G') bird = new Pigeon();
                else if (keyChar == 'S') bird = new Ostrich();
                else return;

                Console.Write("\nIle jajek składa ptak: ");
                if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;

                Egg[] eggs = bird.LayEggs(numberOfEggs);

                foreach (Egg egg in eggs)
                    Console.WriteLine(egg.Destription);
            }
        }
    }
}
