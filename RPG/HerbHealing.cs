using System;
using System.Collections;
using System.Collections.Generic;

class HerbHealing {
    
    public void Heal() {
      
      int herbHeal = 5;
      
      while (true) {
          Console.WriteLine("Current HP: " + CharacterStats.charHealth + "/" + CharacterStats.charMaxHealth);
          Console.WriteLine("You have " + CharacterInventory.numberOfHerbs + " Herb(s), would you like to use one to heal 5 HP? (y/n)");
          Console.WriteLine();
          
      
          
      var decide = Console.ReadKey (true);
    switch (decide.Key) {
        
      case ConsoleKey.N:
      Console.Clear();
	  return;
	  
       case ConsoleKey.Y:
	  Console.Clear();
	  if (CharacterStats.charHealth == CharacterStats.charMaxHealth){
	        Console.WriteLine("You cant use that item, Your health is full.");
	        break;
	    }
        CharacterStats.charHealth += herbHeal;
        CharacterInventory.numberOfHerbs --;
        CharacterInventory.charItems.Remove("Herb");
	    Console.WriteLine();
	    Console.WriteLine("You heal 5 HP.");
	    Console.WriteLine();
	    if (CharacterStats.charHealth >= CharacterStats.charMaxHealth) {
            CharacterStats.charHealth = CharacterStats.charMaxHealth;
        } 
	  break;
      }
      return;
      }
    }
}