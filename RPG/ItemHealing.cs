using System;
using System.Collections;
using System.Collections.Generic;

class ItemHealing {
    
        public static List<string> yesNo = new List<string>() {"Yes", "No"};
        public static int selectedIndex = 0;
        public static string question1 = $"Current HP: {CharacterStats.charHealth}/{CharacterStats.charMaxHealth} {Environment.NewLine}" + 
                                        $"Mana: {CharacterStats.charMana}/{CharacterStats.charMaxMana} {Environment.NewLine}" + 
                                        $"Use Herb to heal 5 HP? {Environment.NewLine}";
                                        
        public static string question2 = $"Current HP: {CharacterStats.charHealth}/{CharacterStats.charMaxHealth} {Environment.NewLine}" + 
                                        $"Mana: {CharacterStats.charMana}/{CharacterStats.charMaxMana} {Environment.NewLine}" + 
                                        $"Use Health Potion to heal {Items.itemStatValues[1]} HP? {Environment.NewLine}";
        
        public static string question3 = $"Current HP: {CharacterStats.charHealth}/{CharacterStats.charMaxHealth} {Environment.NewLine}" + 
                                        $"Mana: {CharacterStats.charMana}/{CharacterStats.charMaxMana} {Environment.NewLine}" + 
                                        $"Use Mana Potion to restore {Items.itemStatValues[2]} Mana? {Environment.NewLine}";
        
        public static string question4 = $"Current HP: {CharacterStats.charHealth}/{CharacterStats.charMaxHealth} {Environment.NewLine}" + 
                                        $"Mana: {CharacterStats.charMana}/{CharacterStats.charMaxMana} {Environment.NewLine}" + 
                                        $"Use Full Restore to restore all health and mana? {Environment.NewLine}";
        
    
    public void HerbHeal() {
      
      while (true) {
          
        ChoiceSelect.Selection(yesNo, selectedIndex, question1);
	    selectedIndex = ChoiceSelect.overallIndex;  
      
      if (selectedIndex == 0) {  
          
         Console.Clear();
	  if (CharacterStats.charHealth == CharacterStats.charMaxHealth){
	        Console.WriteLine("You cant use that item, Your health is full.");
	        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
	        break;
	    }
        CharacterStats.charHealth += Items.itemStatValues[0];
        CharacterInventory.numberOfHerbs --;
        CharacterInventory.charItems.Remove("Herb");
	    Console.WriteLine();
	    Console.WriteLine("You heal 5 HP.");
	    Console.WriteLine();
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
	    if (CharacterStats.charHealth >= CharacterStats.charMaxHealth) {
            CharacterStats.charHealth = CharacterStats.charMaxHealth;
        } 
	  break;
      }
       if (selectedIndex == 1) {
          break;
      }
      }
    }

    public void PotionHeal() {
      
      while (true) {
          
        ChoiceSelect.Selection(yesNo, selectedIndex, question2);
	    selectedIndex = ChoiceSelect.overallIndex;
      
      if (selectedIndex == 0) {
          
          Console.Clear();
	  if (CharacterStats.charHealth == CharacterStats.charMaxHealth){
	        Console.WriteLine("You cant use that item, Your health is full.");
	        break;
	    }
        CharacterStats.charHealth += Items.itemStatValues[1];
        CharacterInventory.numberOfPotions --;
        CharacterInventory.charItems.Remove("Health Potion");
	    Console.WriteLine();
	    Console.WriteLine("You heal " + Items.itemStatValues[1] + " HP.");
	    Console.WriteLine();
	    if (CharacterStats.charHealth >= CharacterStats.charMaxHealth) {
            CharacterStats.charHealth = CharacterStats.charMaxHealth;
        } 
	  break;
      }
      if (selectedIndex == 1) {
          break;
      }
      }
    }
    
    public void ManaRestore() {
      
      while (true) {
          
        ChoiceSelect.Selection(yesNo, selectedIndex, question3);
	    selectedIndex = ChoiceSelect.overallIndex;
       
      if (selectedIndex == 0) { 
         
         Console.Clear(); 
	  if (CharacterStats.charMana == CharacterStats.charMaxMana){
	        Console.WriteLine("You cant use that item, Your mana is full.");
	        break;
	    }
        CharacterStats.charMana += Items.itemStatValues[2];
        CharacterInventory.numberOfPotions --;
        CharacterInventory.charItems.Remove("Mana Potion");
	    Console.WriteLine();
	    Console.WriteLine("You restore " + Items.itemStatValues[2] + " HP.");
	    Console.WriteLine();
	    if (CharacterStats.charMana >= CharacterStats.charMaxMana) {
            CharacterStats.charMana = CharacterStats.charMaxMana;
        } 
	  break;
      }
      if (selectedIndex == 1) {
          break;
      }
      }
    }

    public void RestoreHealthMana() {
      
      
      while (true) {
          
        ChoiceSelect.Selection(yesNo, selectedIndex, question4);
	    selectedIndex = ChoiceSelect.overallIndex;
      
      if (selectedIndex == 0) {
          
          Console.Clear();
	  if (CharacterStats.charMana == CharacterStats.charMaxMana && CharacterStats.charHealth == CharacterStats.charMaxHealth){
	        Console.WriteLine("You cant use that item, Your health and mana are full.");
	        break;
	    }
	    
        CharacterStats.charMana += Items.itemStatValues[3];
        CharacterStats.charHealth += Items.itemStatValues[3];
        CharacterInventory.numberOfFullRestores --;
        CharacterInventory.charItems.Remove("Full Restore");
	    Console.WriteLine();
	    Console.WriteLine("You restore all health and mana!");
	    Console.WriteLine();
	    if (CharacterStats.charMana >= CharacterStats.charMaxMana || CharacterStats.charHealth >= CharacterStats.charMaxHealth) {
            CharacterStats.charMana = CharacterStats.charMaxMana;
            CharacterStats.charHealth = CharacterStats.charMaxHealth;
        } 
	  break;
      }
      if (selectedIndex == 1) {
          break;
      }
      }
    }
}