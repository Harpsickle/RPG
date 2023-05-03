using System;
using System.Collections;
using System.Collections.Generic;

class LootRoll {
    
    
    public static List<string> items = new List<string> () { "Feather", "Iron Ore", "Glove", "Helmet", "Chest Plate", "Herb" };
    public static List<int> gold = new List <int>() { 14, 10, 6, 3, 2, 1 };
    public static int[] goldRanges = { 1, 6, 17, 32, 52, 67 };
    public static int[] itemsRanges = { 1, 10, 20, 35, 45, 55 };
    public static int index = -1;
    
  

  public void RollForGold () {
    
    Random roll = new Random ();
    int number = roll.Next (0, 101);
    
    for (int i = 0; i < goldRanges.Length; i++) {
        
	if (number >= goldRanges[i]) {
	    index = i;
	  }
	else {
	    break;
	  }
     }

    if (index == -1) {
	Console.WriteLine ("You get nothing!");
      }
      
    else {
	Console.WriteLine ("You found " + gold[index] + " gold!");
	CharacterInventory.charGold += gold[index];
	Console.WriteLine ();
      }
    
    Random rollContinue = new Random ();
    int numberContinue = rollContinue.Next (0, 101);
    
    if (numberContinue <= 25) {
       RollForItems(); 
    }
    if (numberContinue > 25) {
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    }
  }
  
  public void RollForItems () {
    
    Random itemsRoll = new Random ();
    int itemsNumber = itemsRoll.Next (0, 101);

    for (int i = 0; i < itemsRanges.Length; i++) {
        
	if (itemsNumber >= itemsRanges[i]) {
	    index = i;
	  }
	else {
	    break;
	  }
     }

    if (index == -1) {
	Console.WriteLine ("You get nothing!");
      }
      
    else {
	Console.WriteLine ("You received " + items[index] + "!");
	CharacterInventory.charItems.Add(items[index]);
	    if (index == 5) {
	        CharacterInventory.numberOfHerbs++;
	    }
      }
    Console.WriteLine ();
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
  }  
  }
  
  
  
  
  