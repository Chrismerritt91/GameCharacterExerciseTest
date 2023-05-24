public class Game
{

    static void Main()
    {

        Warrior war1 = new Warrior("Arthur", 70, 30, 30);
        Mage mag1 = new Mage("Merlin", 60, 40, 20);
        Dragon drag1 = new Dragon("Smaug", 100, 50, 50);

        Console.WriteLine(war1.Name + " is a " + war1);
        Console.WriteLine(mag1.Name + " is a " + mag1);
        Console.WriteLine(drag1.Name + " is a " + drag1);



        Console.ReadKey();

    }


}