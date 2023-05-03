using System;
using System.Collections;
using System.Collections.Generic;


class SketchyChest {

    public static List<string> openYesNo = new List<string>() {"Yes", "No"};
    public static int openIndex = 0;
    public static string question = "You come upon a sketchy looking chest. Open it?";
    
  public void ApproachingChest() {
    
	    ChoiceSelect.Selection(openYesNo, openIndex, question);
        openIndex = ChoiceSelect.overallIndex;
	    Console.Clear ();
	    
	    if (openIndex == 1) {
	        Console.Clear();
            LeavingChestAlone();
            
	    }
	    if (openIndex == 0) {
	        Console.Clear();
	        LootRoll rolling = new LootRoll();
	        rolling.RollForGold();
	    }
    }
    
  public static void LeavingChestAlone() {
    Console.WriteLine("You decide to leave the potentially sketchy chest alone.");
    Console.WriteLine();
    
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
  }
} 
  
  
  