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
      
      // Wallet
      int money = 25;
        
      // Time
      int day = 1;
      
      // Start by asking for the user's name and ship name:
      Console.WriteLine("[Port Master's aide]: Good day Captain! What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"\n[Port Master's aide]: Welcome to Port Crescent, Captain {name}! I see you have a three masted Star Rider corvette. A sturdy ship Captain. What do you call her?\n");
      string shipName = Console.ReadLine();
     
      // Pay for docking:
      Console.WriteLine($"\n[Port Master's aide]: Aye, what a perfect name. {shipName}! She is a beauty alright. Well captain, Port Master Regulus levies a star shilling each day for docking. Would you like to pay now? (Y/N)\n");
      string dockingPayChoice = Console.ReadLine();
      dockingPayChoice = dockingPayChoice.ToUpper();
      if (dockingPayChoice == "Y")
      {
        Console.WriteLine("\n[Port Master's aide]: Very well Captain! She will be in good hands. How many days do you intend to be at port?");
        int stayDuration = Convert.ToInt32(Console.ReadLine());
        money = money - stayDuration; // add logic to check if user can afford it
        Console.WriteLine($"\n[Port Master's aide]: Alright, that will be {stayDuration} star shillings then.\n\n<< They young man holds out his hand expectantly... >>\n\n [{name}]: << You dig into your coin purse and retrieve {stayDuration} shillings and hand them over. You remind yourself to be cautious as your coin purse feels rather light. You've only got {money} left... >> \n");

      }
      else
      {
        Console.WriteLine("\n[Port Maseter's aide]: That's fine Captain. I'll keep track of the days your in port and let you know how much you owe when your setting off. Good day to you!\n");
      }
      Console.WriteLine($"[{name}]: << You nod politely to the young man and stow your coin purse in your coat and head on in to Port Crescent. >>\n");
    }
  }
}



