using System;
using System.Collections;
using System.Collections.Generic;

class CharacterInventory {
    
     
     public static int charGold = 900;
     public static List<string> charItems = new List<string>() {"Go Back"};
     public static int numberOfHerbs = 0;
     public static int numberOfPotions = 0;
     public static int numberOfManaPotions = 0;
     public static int numberOfFullRestores = 0;
     public static int selectedIndex = 0;
     public static int backSwitch = 0;
     public static string question = $"HP: {CharacterStats.charHealth}/{CharacterStats.charMaxHealth} {Environment.NewLine}" + 
                                     $"Mana: {CharacterStats.charMana}/{CharacterStats.charMaxMana} {Environment.NewLine}" + 
                                     $"Gold: {charGold} {Environment.NewLine}" +
                                     $"--------------- {Environment.NewLine}" + 
                                     $"All items in your inventory: {Environment.NewLine}";
                                     
     
  public void PrintCharInventory() { 
        
    charItems.Sort();
    charItems.Remove("Go Back");
    charItems.Add("Go Back");
        
    while (true) {

    ChoiceSelect.Selection(charItems, selectedIndex, question);
	selectedIndex = ChoiceSelect.overallIndex;
    Console.Clear ();
	    
	    
	    
	    if (charItems[selectedIndex] == "Herb") {
	    ItemHealing herbHeal = new ItemHealing();
        herbHeal.HerbHeal();
	    Console.WriteLine ();
            if (Battle.battleOnOff == 1){
                break;
            }
	    }
	    
	    if (charItems[selectedIndex] == "Health Potion") {
	    ItemHealing potionHeal = new ItemHealing();
        potionHeal.PotionHeal();
	    Console.WriteLine ();
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
            if (Battle.battleOnOff == 1){
                break;
            }
	    }
	    
	    if (charItems[selectedIndex] == "Mana Potion") {
	    ItemHealing manaRestore = new ItemHealing();
        manaRestore.ManaRestore();
	    Console.WriteLine ();
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
            if (Battle.battleOnOff == 1){
                break;
            }
	    }
	    
	    if (charItems[selectedIndex] == "Full Restore") {
	    ItemHealing allRestore = new ItemHealing();
        allRestore.RestoreHealthMana();
	    Console.WriteLine ();
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
            if (Battle.battleOnOff == 1){
                break;
            }
	    }
	    
	    if (charItems[selectedIndex] == "Go Back") {
	        backSwitch = 1;
	        break;
	    }
	    
	    
      }
    }
  }
