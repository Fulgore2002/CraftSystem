/*
* CraftSystem
* Tyler Hitchcock, 2/12/25
* Credits
* - code from class
* -some help from my brother
 */


namespace CraftSystem
{
    internal class Program
    {
        static void Main()
        {
            Person player = new Person("Anonymous Player");

            Engine engine = new Engine(player);
            engine.Start();  // Start the game engine
        }
    }

}
