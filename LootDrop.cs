using System;
using System.Collections;
using System.Collections.Generic;


class LootDrop
{
static int charGold = 0;

  public static void RandomRollInfo () {

    List <int>items = new List <int>() { 14, 10, 6, 3, 2, 1 };
    int[] ranges = { 1, 6, 17, 32, 52, 67 };
    int index = -1;
    RollForLoot(items, ranges, index);
    
  }
  

  public static void ApproachingChest() {
    Console.WriteLine ("You come upon a sketchy looking chest. Open it? (y/n)");
    
    var decide = Console.ReadKey (true);
    switch (decide.Key) {
        
      case ConsoleKey.N:
      Console.Clear();
	LeavingChestAlone();
	break;
       case ConsoleKey.Y:
	  Console.Clear();
	  break;
      }
    }
    
  public static void RollForLoot (List<int>items, int[]ranges, int index) {
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
	charGold += items[index];
      }
    Console.WriteLine ();
    TravelAgain(charGold);
  }

  public static void TravelAgain (int charGold) {

    Console.
      WriteLine
      ("Would you like to continue traveling? (y/n)");
    Console.WriteLine ();

    var yesNo = Console.ReadKey (true);
    switch (yesNo.Key)
      {
      case ConsoleKey.Y:
	Console.Clear ();
	CharacterMovement move = new CharacterMovement ();
	move.CharacterWalk ();
	break;
      case ConsoleKey.N:
	Console.Clear ();
	Console.WriteLine ("You attained " + charGold + " Gold throughout your adventure!");
	Console.WriteLine ("Please come back soon!");
	Console.WriteLine ();
	RPG.Main ();
	break;
      }
  }
  public static void LeavingChestAlone() {
    Console.WriteLine("You decide to leave the potentially sketchy chest alone and continue traveling.");
    Console.WriteLine("Press enter to continue your traveling.");
    Console.WriteLine();
    
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    
    
    CharacterMovement move = new CharacterMovement ();
    move.CharacterWalk ();
  }
  
}