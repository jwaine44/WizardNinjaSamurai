namespace Humans;

public class Ninja : Human
{

    public Ninja(string val) : base(val)
    {
        Dexterity = 175;
    }

    public override int Attack(Human target)
    {
        Random rand = new Random();
        int roll = rand.Next(1, 6);
        if(roll == 5) {
            target.Health -= (Dexterity * 5) + 10;
        }
        target.Health -= (Dexterity * 5);
        Console.WriteLine(target.Health);
        return target.Health;
    }

    public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
    }
}