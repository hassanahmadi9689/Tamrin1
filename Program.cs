// See https://aka.ms/new-console-template for more information

using ConsoleApp77;

while (true)
{ try
    {
        Run();
    }
    catch (Exception exception)
    {
        showerror(exception.Message);
        
    }

    
}
   
static void Run()
{
    var Option = GetNumberFromUser("Choose option:\n" +
                                   "1.Add Character\n" +
                                   "2.update health\n" +
                                   "3.Attack\n" +
                                   "4.Show detail of characters");
    switch (Option)
    {
        case 1:
        {
            var type = GetNumberFromUser("choose character:\n" +
                                         "1. hero\n" +
                                         "2.enemy\n" +
                                         "3.animal");
            var name = GetValidStringFromUser("enter name of character:");
            var power = GetNumberFromUser("enter power:");
            var speed = GetNumberFromUser("enter speed");
            Game.AddCharacter(type,name,power,speed);
            break;
        }
        case 2:
        {
            var name = GetValidStringFromUser("enter name of character");
            var newhealth = GetNumberFromUser("enter new health");
            Game.UpdateHealth(name,newhealth);
            break;
        }
        case 3:
        {
            var attacker = GetValidStringFromUser("enter name of attacker");
            var underattck = GetValidStringFromUser("enter name of under attack");
            Game.Attack(attacker,underattck);
            
            break;
        }
        case 4:
        {
            foreach (var character in Game.GetCharacters())
            {
                Console.WriteLine($"name:{character.Name} - power:{character.Power} - speed:{character.Speed} - health:{character.Health}");
            }
            break;
        }
            
    }
}






static string GetValidStringFromUser(string message)
{
    bool tryparse = false;
    string? value;
    do
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
          
    } while ( string.IsNullOrWhiteSpace(value)   );
 
    return value;
}

static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}

static void showerror(string error)
{
    Console.WriteLine("*********");
    Console.WriteLine(error);
    Console.WriteLine("*********");
}