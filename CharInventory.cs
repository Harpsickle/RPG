using System;
using System.Collections;
using System.Collections.Generic;

class CharacterInventory {
    
     public static int charGold = 0;
     public static List<string> charItems = new List<string>();
     public static int numberOfHerbs = 0;
     int selectedIndex = 0;
     
  public void PrintCharInventory() { 
    
    while (true) { 
    Console.Clear();
    Console.WriteLine("Current Gold: " + charGold);
    Console.WriteLine();
    Console.WriteLine("All items in your inventory: ");
    charItems.Sort();
    
    for (int i = 0; i < charItems.Count; i++)
	  {
	    if (i == selectedIndex)
	      {
		Console.Write ("> ");
	      }
	    Console.WriteLine (charItems[i]);
	  }
	Console.WriteLine ();  
    Console.WriteLine ("Hit Backspace to go back");
    
    
    var keyInfo = Console.ReadKey (true);
	switch (keyInfo.Key)
	  {
	  case ConsoleKey.UpArrow:
	    selectedIndex = (selectedIndex == 0) ? charItems.Count - 1 : selectedIndex - 1;
	    break;
	  case ConsoleKey.DownArrow:
	    selectedIndex = (selectedIndex == charItems.Count - 1) ? 0 : selectedIndex + 1;
	    break;
	  case ConsoleKey.Enter:
	    Console.Clear ();
	    if (charItems[selectedIndex] == "Herb") {
	    HerbHealing heal = new HerbHealing();
        heal.Heal();
	    Console.WriteLine ();
	    }
	    else if (charItems[selectedIndex] != "Herb") {
	        Console.WriteLine("This item has no use.");
	    }
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
	    break;
	  case ConsoleKey.Backspace:
	    
	    return;
	  default:
	    break;
	  }  
    }
  }
}