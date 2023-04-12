using System;
using System.Collections;
using System.Collections.Generic;

class Title {
    
  public void GameTitle () {

    Console.WriteLine("Welcome to the game. Press Enter to get started!");
    
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
     GameLoop();
  }
  public void GameLoop() {

    int selectedOption = 0;
    List<string> possibleTasks = new List<string>() { 
        "Back to Title",
        "Character Stats",
        "Inventory",
        "Travel",
        "End Game",
    };
    
    while (true) {

	Console.Clear();
	Console.WriteLine("You are home!");
	Console.WriteLine("What would you like to do?");
	Console.WriteLine();
	
	for (int i = 0; i < possibleTasks.Count; i++)
	  {
	    if (i == selectedOption)
	      {
		Console.Write ("> ");
	      }
	    Console.WriteLine (possibleTasks[i]);
	  }

	var keyInfo = Console.ReadKey (true);
	switch (keyInfo.Key)
	  {
	  case ConsoleKey.UpArrow:
	    selectedOption = (selectedOption == 0) ? possibleTasks.Count - 1 : selectedOption - 1;
	    break;
	  case ConsoleKey.DownArrow:
	    selectedOption = (selectedOption == possibleTasks.Count - 1) ? 0 : selectedOption + 1;
	    break;
	  case ConsoleKey.Enter:
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
	    CharacterMovement.CharacterWalk();
	    }
	    if (selectedOption == 4) {
	    ExitGame gameOver = new ExitGame();
	    gameOver.EndGame();
	    }
	    Console.WriteLine ();
	    break;
	  default:
	    break;
	  }
    
    }
    
  }
}