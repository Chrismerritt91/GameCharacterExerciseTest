public class Dragon : Character
{
    //child class constructor
    public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense) { }

    //Methods

    public override void AttackOpponent(Character target)
    {
        int damageCounter = (this.Attack * 2) - target.Defense;

        if (damageCounter > 0)
        {
            target.Health = target.Health - damageCounter;
            Console.WriteLine(this.Name + " breathes fire on " + target.Name + " for " + damageCounter + " damage!");
        }
        else
        {
            Console.WriteLine(this.Name + "'s attack has no effect on " + target.Name);
        }
    }

    public void BreatheFire(Character target)
    {
        AttackOpponent(target);
    }

}
