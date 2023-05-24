public class Character
{
    //fields
    private string _name;
    private int _health;
    private int _attack;
    private int _defense;

    //Constructor

    public Character(string name, int health, int attack, int defense)
    {
        this._name = name;
        this._health = health;
        this._attack = attack;
        this._defense = defense;
    }

    //properties

    public string Name { get { return _name; } set { _name = value; } }
    public int Health { get { return _health; } set { _health = value; } }
    public int Attack { get { return _attack; } set { _attack = value; } }
    public int Defense { get { return _defense; } set { _defense = value; } }

    //methods

    public virtual void AttackOpponent(Character target)
    {
        int damageCounter = this.Attack - target.Defense;

        if (damageCounter > 0)
        {
            target.Health = target.Health - damageCounter;
            Console.WriteLine(this.Name + " attacks " + target.Name + " for " + damageCounter + " damage!");
        }
        else
        {
            Console.WriteLine(this.Name + "'s attack has no effect on " + target.Name + ".");
        }
    }

    public virtual void Defend()
    {
        Console.WriteLine(this.Name + " defends!");
    }


}