using System;
using System.Collections.Generic;

class Battle {
    
    string runAway = "You run away like a coward. (Enter to Continue)";
    
    public void Attack () {
        
      Console.WriteLine("You come upon an enemy. Would you like to battle? (y/n)");
      Console.WriteLine();
        
      var decide = Console.ReadKey (true);
    switch (decide.Key) {
        
      case ConsoleKey.N:
      Console.Clear();
      Console.WriteLine(runAway);
      EnemyStats.enemyHealth = EnemyStats.enemyMaxHealth;
      while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
	  break;
	  
       case ConsoleKey.Y:
	  Console.Clear();
	  EngageInBattle();
	  break;
      }
    }
       
       
    public void EngageInBattle() {
        
        List<string> battleOptions = new List<string> {"Attack", "Inventory", "Run"};
        int selectedIndex = 0;
        
        
        
        
        
        while (CharacterStats.charHealth > 0 && EnemyStats.enemyHealth > 0) {

	    Console.Clear();
	    Console.WriteLine("Your HP: " + CharacterStats.charHealth + "/" + CharacterStats.charMaxHealth + "    " + " Enemy HP: " + EnemyStats.enemyHealth + "/" + EnemyStats.enemyMaxHealth);
        Console.WriteLine();
        Console.WriteLine("Make your move!");
        Console.WriteLine();
	
	for (int i = 0; i < battleOptions.Count; i++)
	  {
	    if (i == selectedIndex)
	      {
		Console.Write ("> ");
	      }
	    Console.WriteLine (battleOptions[i]);
	  }
        
        
        var keyInfo = Console.ReadKey (true);
	switch (keyInfo.Key)
	  {
	  case ConsoleKey.UpArrow:
	    selectedIndex = (selectedIndex == 0) ? battleOptions.Count - 1 : selectedIndex - 1;
	    break;
	    
	  case ConsoleKey.DownArrow:
	    selectedIndex = (selectedIndex == battleOptions.Count - 1) ? 0 : selectedIndex + 1;
	    break;
	    
	  case ConsoleKey.Enter:
	    if (selectedIndex == 2) {
	        Console.WriteLine(runAway);
        while (Console.ReadKey ().Key != ConsoleKey.Enter) { 
            
        }
        return;
	    }
	    
	    if (selectedIndex == 1) {
	        CharacterInventory toInv = new CharacterInventory();
	        toInv.PrintCharInventory();
	        
	    }
	    
	    if (selectedIndex == 0) {
	        Console.Clear();
	        Console.WriteLine ($"You {battleOptions[selectedIndex]} for {CharacterStats.charDamage} damage!");
	        EnemyStats.enemyHealth -= CharacterStats.charDamage;
	        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
            Console.Clear();
	        Console.WriteLine("The enemy attacks for " + EnemyStats.enemyDamage + " damage!");
	        CharacterStats.charHealth -= EnemyStats.enemyDamage;
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
	    }
	    break;
	  default:
	    break;
	  }
	 
    }
    
    if (CharacterStats.charHealth > 0) {
        Console.WriteLine("You defeated the enemy!");
        EnemyStats.enemyHealth = EnemyStats.enemyMaxHealth;
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    }
    else if (EnemyStats.enemyHealth > 0 && CharacterStats.charHealth == 0) {
        Console.WriteLine("You have been defeated!");
        ExitGame gameOver = new ExitGame();
	    gameOver.EndGame();
    }

    }
    }

    