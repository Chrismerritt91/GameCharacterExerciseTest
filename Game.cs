public class Game
{

    public static Character[] DeleteCharacter(Character[] characters, Character character)
    {
        int deadChar = Array.IndexOf(characters, character);

        if(deadChar < 0)
        {
            return characters;
        }

        Character[] newCharacters = new Character[characters.Length - 1];

        for(int i = 0, j = 0; i < characters.Length; i++)
        {
            if(i == deadChar)
            {
                continue;
            }
            newCharacters[j] = characters[i];
            j++;
        }
        return newCharacters;
    }
    
    public static void Battle(params Character[] characters)
    {
        do
        {
            Random rdm = new Random();

            for(int i = 0; i < characters.Length; i++)
            {
                int num = rdm.Next(1, 3);

                if(num == 1)
                {
                    if(i == characters.Length - 1)
                    {
                        characters[i].AttackOpponent(characters[0]);
                        if (characters[0].Health <= 0)
                        {
                            Console.WriteLine(characters[0].Name + " has been defeated!");
                            characters = DeleteCharacter(characters, characters[0]);
                        }
                    }
                    else
                    {
                        characters[i].AttackOpponent(characters[i + 1]);
                        if (characters[i+1].Health <= 0)
                        {
                            Console.WriteLine(characters[i+1].Name + " has been defeated!");
                            characters = DeleteCharacter(characters, characters[i+1]);
                        }
                    }

                }
                else
                {
                    characters[i].Defend();
                }
            }

        } while (characters.Length > 1);

        Console.WriteLine(characters[0].Name + " wins!");
    }

    static void Main()
    {

        Warrior war1 = new Warrior("Arthur", 70, 40, 40);
        Mage mag1 = new Mage("Merlin", 60, 50, 30);
        Dragon drag1 = new Dragon("Smaug", 100, 60, 40);

        Console.WriteLine(war1.Name + " is a " + war1);
        Console.WriteLine(mag1.Name + " is a " + mag1);
        Console.WriteLine(drag1.Name + " is a " + drag1);
        Console.WriteLine();

        Game.Battle(war1, mag1,drag1);

        Console.ReadKey();

    }


}