namespace Humans;
public class Human
{
    public string Name {get;set;}
    public int Strength {get;set;}
    public int Intelligence {get;set;}
    public int Dexterity {get;set;}
    public int Health {get;set;}

    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string val)
    {
        Name = val;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    
    // Add a constructor to assign custom values to all fields
    public Human(string val, int strengthNum, int intelligenceNum, int dexNum, int healthNum)
    {
        Name = val;
        Strength = strengthNum;
        Intelligence = intelligenceNum;
        Dexterity = dexNum;
        Health = healthNum;
    }

    public string AllAttributes()
    {
        return $"Name: {Name}, strength is {Strength}, intelligence is {Intelligence}, dexterity is {Dexterity}, health is {Health}!";
    }
    
    // Build Attack method

    public virtual int Attack(Human target)
    {
        target.Health -= (Strength * 5);
        Console.WriteLine(target.Health);
        return target.Health;
    }
}

