using System;
using System.Collections;
using System.Collections.Generic;

class CharacterMovement
{

  public static void  CharacterWalk ()
  {

    int selectedIndex = 0;
    string[] options = {"Travel West", "Travel North", "Travel East", "Travel South"};
    MovementSelection (selectedIndex, options);
    
  }

  public static void MovementSelection (int selectedIndex, string[]options) {

    while (true)
      {

	Console.Clear();
	Console.WriteLine("Where would you like to travel?");
	Console.WriteLine();
	
	for (int i = 0; i < options.Length; i++)
	  {
	    if (i == selectedIndex)
	      {
		Console.Write ("> ");
	      }
	    Console.WriteLine (options[i]);
	  }

	var keyInfo = Console.ReadKey (true);
	switch (keyInfo.Key)
	  {
	  case ConsoleKey.UpArrow:
	    selectedIndex = (selectedIndex == 0) ? options.Length - 1 : selectedIndex - 1;
	    break;
	  case ConsoleKey.DownArrow:
	    selectedIndex = (selectedIndex == options.Length - 1) ? 0 : selectedIndex + 1;
	    break;
	  case ConsoleKey.Enter:
	    Console.Clear ();
	    Console.WriteLine ($"You {options[selectedIndex]}");
	    Console.WriteLine ();
	    break;
	  default:
	    break;
	  }
	  
	  Random travelOutcome = new Random ();
    int outcome = travelOutcome.Next (0, 101);
    
    if (outcome <= 40) {
        SketchyChest approach = new SketchyChest();
        approach.ApproachingChest();
    }
    if (outcome > 40 && outcome <= 80) {
        Battle enemy = new Battle();
        enemy.Attack();
    } 
    else if (outcome > 80) {
        Console.Clear();
        Console.WriteLine("Nothing out of the ordinary happens.");
        Console.WriteLine();
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
          
      }
    }
    

    Console.Clear();
    Console.WriteLine("Would you like to continue traveling? (y/n)");
    Console.WriteLine ();

    var yesNo = Console.ReadKey (true);
    switch (yesNo.Key)
      {
      case ConsoleKey.Y:
	Console.Clear ();
	break;
      case ConsoleKey.N:
	Console.Clear ();
	Console.WriteLine("You decide to return home.");
	while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      Console.Clear();
	
	return;
      }
      
  }
      
  }
}
      