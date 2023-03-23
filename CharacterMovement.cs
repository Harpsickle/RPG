using System;
using System.Collections;
using System.Collections.Generic;

class CharacterMovement
{

  public void CharacterWalk ()
  {

    int selectedIndex = 0;
    string[] options = {"Travel West", "Travel North", "Travel East", "Travel South"};

    MovementSelection (selectedIndex, options);
  }

  public void MovementSelection (int selectedIndex, string[]options) {

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
	    LootDrop.ApproachingChest();
	    return;
	  default:
	    break;
	  }
      }
  }
  
}