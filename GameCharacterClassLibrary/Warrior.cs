public class Warrior: Character
{
    //child class constructor
    public Warrior(string name, int health, int attack, int defense) : base(name, health, attack, defense){}

    // Methods
    public void Charge(Character target)
    {
        base.AttackOpponent(target);
    }

    public override void Defend()
    {
        this.Defense += 5;
        Console.WriteLine(this.Name + " defends and gains 5 defense.");
    }
}
