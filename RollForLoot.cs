using System;
using System.Collections;
using System.Collections.Generic;

class LootRoll {

  public void RandomRollInfo () {
    
    List<string> items = new List<string> () { "Feather", "Iron Ore", "Glove", "Helmet", "Chest Plate", "Herb" };
    List<int> gold = new List <int>() { 14, 10, 6, 3, 2, 1 };
    int[] goldRanges = { 1, 6, 17, 32, 52, 67 };
    int[] itemsRanges = { 1, 10, 20, 35, 45, 55 };
    int index = -1;
    RollForGold(gold, goldRanges, index);
    RollForItems(items, itemsRanges, index);
  }

  public void RollForGold (List<int> gold, int[] goldRanges, int index) {
    
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
        
	Console.WriteLine ("You received " + gold[index] + " gold!");
	CharacterInventory.charGold += gold[index];
      }
    Console.WriteLine ();
  }
  
  public void RollForItems (List<string> items, int[] itemsRanges, int index) {
    
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
  
  
  
  
  