namespace Humans;

public class Wizard : Human
{

    public Wizard(string val) : base(val)
    {
        Intelligence = 25;
        Health = 50;
    }

    public override int Attack(Human target)
    {
        target.Health -= (Intelligence * 5);
        Health += (Intelligence * 5);
        Console.WriteLine(target.Health);
        return target.Health;
    }

    public void Heal(Human target)
    {
        target.Health += (Intelligence * 10);
    }
}