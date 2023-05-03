using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Battle {
    
      public static string runAway = "You run away like a coward!";
      public static List<string> yesNo = new List<string>() {"Yes", "No"};
      public static int yesNoIndex = 0;
      public static List<string> battleOptions = new List<string> {"Attack", "Inventory", "Run"};
      public static int selectedIndex = 0;
      public static int battleOnOff = 0;
      
    
  public static void Attack () {
      
        string question1 = "An enemy appears before you. Would you like to battle?";
        
        battleOnOff = 1;
        
        ChoiceSelect.Selection(yesNo, yesNoIndex, question1);
	    yesNoIndex = ChoiceSelect.overallIndex;

	    Console.Clear ();
	    
	    if (yesNoIndex == 0) {
	        ListOfEnemies.ActiveEncounter();
	        EngageInBattle();
	        BattleEnd();
	    }
	    
	    if (yesNoIndex == 1) {
            Console.WriteLine(runAway);
            battleOnOff = 0;
      
      while (Console.ReadKey ().Key != ConsoleKey.Enter)
        {
        }
	    }
  }      
     
    public static void EngageInBattle() {
        
        
        while (CharacterStats.charHealth > 0 && ListOfEnemies.newEnemy.health > 0) {
            
            string question2 = $"---------------------------------- {Environment.NewLine}" + 
                                    $"{ListOfEnemies.enemyOpponent} HP: {ListOfEnemies.newEnemy.health}/{ListOfEnemies.newEnemy.maxHealth} {Environment.NewLine}" +
                                    $"Attack: {ListOfEnemies.newEnemy.attack} {Environment.NewLine}" + 
                                    $"Armor: {ListOfEnemies.newEnemy.armor} {Environment.NewLine}" + 
                                    $"---------------------------------- {Environment.NewLine}" + 
                                    Environment.NewLine + 
                                    $"Character: {Environment.NewLine}" + 
                                    $"HP: {CharacterStats.charHealth}/{CharacterStats.charMaxHealth} {Environment.NewLine}" + 
                                    $"Mana: {CharacterStats.charMana}/{CharacterStats.charMaxMana} {Environment.NewLine}" + 
                                    Environment.NewLine + 
                                    $"Make your move! {Environment.NewLine}" + 
                                    Environment.NewLine;
            
            
            ChoiceSelect.Selection(battleOptions, selectedIndex, question2);
	        selectedIndex = ChoiceSelect.overallIndex;
            
	    if (selectedIndex == 2) {
	        Console.WriteLine(Battle.runAway);
	        battleOnOff = 0;
        while (Console.ReadKey ().Key != ConsoleKey.Enter) 
        { 
        }
        return;
	    }
	    
	    if (selectedIndex == 1) {
	        CharacterInventory toInv = new CharacterInventory();
	        toInv.PrintCharInventory();
	        
	        if (CharacterInventory.backSwitch == 0) {
	            BattleTurns.EnemyTurn();
	        continue;
	    }
	    
	        if (CharacterInventory.backSwitch == 1) {
	            CharacterInventory.backSwitch = 0;
	        continue;
	    }
	    }
	    
	    if (selectedIndex == 0) {
	        BattleTurns.PlayerTurn();
	        if (ListOfEnemies.newEnemy.health <= 0){
	            break;
	        }
	        BattleTurns.EnemyTurn();
	    }
    }
  }
    
  public static void BattleEnd() {   
    
    battleOnOff = 0;
    
    if (CharacterStats.charHealth > 0 && ListOfEnemies.newEnemy.health <= 0) {
        Console.Clear();
        Console.WriteLine("You defeated the enemy!");
        Console.WriteLine($"You gained {ListOfEnemies.newEnemy.exp} Experience!");
        CharacterStats.charExperience += ListOfEnemies.newEnemy.exp;
        LootRoll rolling = new LootRoll();
	    rolling.RollForGold();
	    
	  
      if (CharacterStats.charExperience >= CharacterStats.charMaxExp) {
          CharLevelUp.LevelUp();
      }
    }
    

    if ((ListOfEnemies.newEnemy.health > 0 && CharacterStats.charHealth <= 0) || (ListOfEnemies.newEnemy.health <= 0 && CharacterStats.charHealth <= 0)) {
        Console.WriteLine("You have been defeated!");
        Console.WriteLine();
        RPG exit = new RPG();
        exit.Goodbye();
    }
    }
    }

    