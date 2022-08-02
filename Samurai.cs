namespace Humans;

public class Samurai : Human
{

    public Samurai(string val) : base(val)
    {
        Health = 200;
    }

    public override int Attack(Human target)
    {
        target.Health -= (Strength * 5);
        if(target.Health < 50){
            target.Health = 0;
        }
        Console.WriteLine(target.Health);
        return target.Health;
    }

    public void Meditate()
    {
        Health = 200;
    }

}