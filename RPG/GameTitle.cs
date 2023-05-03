using System;
using System.Collections;
using System.Collections.Generic;

class Title {
    
    public static int selectedOption = 0;
    public static List<string> possibleTasks = new List<string>() { 
        "Back to Title",
        "Character Stats",
        "Inventory",
        "Travel",
        "Merchant",
        "End Game",
    };
    
    public static string question = $"Welcome Home! {Environment.NewLine}" + 
                                    $"--------------- {Environment.NewLine}" + 
                                    $"What would you like to do? {Environment.NewLine}";
  
  public void GameTitle () {

    Console.WriteLine("Welcome to the game. Press Enter to get started!");
    
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
     GameLoop();
    }
 
  public void GameLoop() {
        
        while (true) {
        
        ChoiceSelect.Selection(possibleTasks, selectedOption, question);
	    selectedOption = ChoiceSelect.overallIndex;

	    Console.Clear ();
	    if (selectedOption == 0) {
	    Title toGameTitle = new Title();
	    toGameTitle.GameTitle();
	    }
	    if (selectedOption == 1) {
	    CharacterStats info = new CharacterStats();
	    info.Stats();
	    }
	    if (selectedOption == 2) {
	    CharacterInventory print = new CharacterInventory();
        print.PrintCharInventory();
	    }
	    if (selectedOption == 3) {
	    CharacterMovement walk = new CharacterMovement();
	    walk.MovementSelection();
	    }
	    if (selectedOption == 4) {
	    Merchant buy = new Merchant();
	    buy.BuyFromMerchant();
	    }
	    if (selectedOption == 5) {
	    RPG exit = new RPG();
        exit.Goodbye();
	    }
	}
    
  }
}