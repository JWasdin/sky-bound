using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* Sky Bound! */
      
      // Welcome
      Console.WriteLine("Welcome to SKY BOUND!\n");
      Console.WriteLine("You are the captain of a sky bound airship, and you've just arrived at a floating sky port. As your ship pulls up the jetty, you glance up and see the rising spires and bustling crowds of the port. A spry young man moves towards you as you extend the gang plank...\n");
        
      // Start by asking for the user's name:
      Console.WriteLine("Good day Captain! What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"\nWelcome to Port Crescent, Captain {name}! ");
      
      // Ask the name of the ship:
      Console.WriteLine($"I see you have a three masted Star Rider corvette. A sturdy ship Captain. What do you call her?\n");
      string shipName = Console.ReadLine();
     
      // Pay for docking:
      Console.WriteLine($"\nAye, what a perfect name. The {shipName}! She is a beauty alright. Well captain, Port Master Regulus levies a 10 star shilling for docking the {shipName}. Would you like to pay now? (Y/N)\n");
      string dockingPayChoice = Console.ReadLine();
        
      //Console.WriteLine({dockingPayChoice});
    }
  }
}



