using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp77;

public static class Game
{
    private static List<Character> _characters = new();

    public static void AddCharacter(int Type, string name, int power, int speed)
    {
        if (Type==1)
        {
            var hero = new Hero(name);
            hero.setpower(power);
            hero.setSpeed(speed);
            _characters.Add(hero);
        }

        if (Type==2)
        {
            var enemy = new Enemy(name);
            enemy.setpower(power);
            enemy.setSpeed(speed);
            _characters.Add(enemy);

        }

        if (Type==3)
        {
            var animal = new Animal(name);
            animal.setpower(power);
            animal.setSpeed(speed);
            _characters.Add(animal);
        }
        if(Type>3 || Type<1)
        {
            throw new Exception("type not found");
        }
    }

    public static void UpdateHealth(string name,int newhealth)
    {
        var character = _characters.Find(_ => _.Name == name);
        if (character.Name is null)
        {
            throw new Exception("character not found");
        }
        character.sethealth(newhealth);
    }

    public static void Attack(string attacker, string underAttack)
    {
        var Attacker = _characters.Find(_ => _.Name == attacker);
        if (Attacker.Name is null)
        {
            throw new Exception("character not found");
        }

        var power = Attacker.Power;
        var Underattack = _characters.Find(_ => _.Name == underAttack);
        if (Underattack.Name is null)
        {
            throw new Exception("character not found");
        }

        var health = Underattack.Health;
        Underattack.sethealth(health-power);
        
    }

    public static List<Character> GetCharacters()
    {
        return _characters;
    }
    
}