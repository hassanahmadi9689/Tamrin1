using System.Net.Mail;

namespace ConsoleApp77;

public abstract class Character
{
    public Character(string name)
    {
        Name = name;
        Health = 100;
        
    }

    

    public string Name { get; set; }
    public int Health { get; private set; }
    public int Power { get; private set; }
    public int Speed { get; private set; }
    public enum Live
    {
        zende,
        morde
    }

    public virtual void setSpeed(int speed)
    {
        if (speed<0)
        {
            throw new Exception("speed cant be zero");
        }

        Speed = speed;
    }

    public virtual void setpower(int power)
    {
        if (power<0)
        {
            throw new Exception("power cant be zero");
        }

        Power = power;
    }

    public virtual void sethealth(int health)
    {
        if (health<0)
        {
            throw new Exception("under attacker died");
        }

        Health = health;
    }
    
    
}

public class Hero : Character
{
    public Hero(string name) : base(name)
    {
        
    }
    
}

public class Enemy : Character
{
    

    public Enemy(string name) : base(name)
    {
        
    }
}

public class Animal : Character
{
    public Animal(string name) : base(name)
    {
        
    }
}

