using System;
using System.Collections;
using System.Collections.Generic;


class SketchyChest {

  public static void LeavingChestAlone() {
    Console.WriteLine("You decide to leave the potentially sketchy chest alone.");
    Console.WriteLine();
    
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
  }
  
  public void ApproachingChest() {
    Console.WriteLine ("You come upon a sketchy looking chest. Open it? (y/n)");
    
    var decide = Console.ReadKey (true);
    switch (decide.Key) {
        
      case ConsoleKey.N:
      Console.Clear();
      LeavingChestAlone();
	break;
       case ConsoleKey.Y:
	  Console.Clear();
	  LootRoll rolling = new LootRoll();
	  rolling.RandomRollInfo();
	  break;
      }
    }
} 
  
  
  