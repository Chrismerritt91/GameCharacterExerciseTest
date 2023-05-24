public class Mage : Character
{
    //child class constructor
    public Mage(string name, int health, int attack, int defense): base(name, health, attack, defense) { }

    // Methods
    public void CastSpell(Character target)
    {
        base.AttackOpponent(target);
    }

    public sealed override void Defend()
    {
        Console.WriteLine(this.Name + " defends!");
    }

}

