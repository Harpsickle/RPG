using System;
using System.Collections;
using System.Collections.Generic;

class CharacterMovement
{

    public static int selectedIndex = 0;
    public static int yesNoIndex = 0;
    public static List<string> options = new List<string>() {"Travel West", "Travel North", "Travel East", "Travel South"};
    public static List<string> yesNo = new List<string>() {"Yes", "No"};
    public static string question1 = "Where would you like to travel?";
    public static string question2 = "Would you like to continue traveling?";

  public void MovementSelection () {

        while (true) {

	    ChoiceSelect.Selection(options, selectedIndex, question1);
	    selectedIndex = ChoiceSelect.overallIndex;
	    
	    Console.Clear ();
	    Console.WriteLine ($"You {options[selectedIndex]}");
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
	    
	    Random travelOutcome = new Random ();
        int outcome = travelOutcome.Next (0, 101);
    
    if (outcome <= 40) {
        SketchyChest approach = new SketchyChest();
        approach.ApproachingChest();
    }
    
    if (outcome > 40 && outcome <= 80) {
        Battle.Attack();
    } 
    
    if (outcome > 80) {
        Console.Clear();
        Console.WriteLine("Nothing out of the ordinary happens.");
        Console.WriteLine();
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      }
      
      TravelAgain();
      if (yesNoIndex == 1) {
          
          return;
      }
  }
  }
  
  public static void TravelAgain() {

    ChoiceSelect.Selection(yesNo, yesNoIndex, question2);
	yesNoIndex = ChoiceSelect.overallIndex;
	
      if (yesNoIndex == 1) {
            Console.Clear();
            Console.WriteLine("You decide to return home.");
    	while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
        
	  }
	}
}
  
      