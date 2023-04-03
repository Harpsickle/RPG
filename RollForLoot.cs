using System;
using System.Collections;
using System.Collections.Generic;

class LootRoll {

   public void RandomRollInfo () {

    List <int>items = new List <int>() { 14, 10, 6, 3, 2, 1 };
    int[] ranges = { 1, 6, 17, 32, 52, 67 };
    int index = -1;
    RollForLoot(items, ranges, index);
  }

  public void RollForLoot (List<int> items, int[] ranges, int index) {
    Random roll = new Random ();
    int number = roll.Next (0, 101);

    for (int i = 0; i < ranges.Length; i++) {
        
	if (number >= ranges[i]) {
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
        
	Console.WriteLine ("You received " + items[index] + " gold!");
	CharacterInventory.chargold += items[index];
      }
    Console.WriteLine ();
    
  }
  }