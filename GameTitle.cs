using System;
using System.Collections;
using System.Collections.Generic;

class Title {
    
  public void GameTitle () {

    Console.WriteLine ("Welcome to the game. Press Enter to get started!");
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      GameRecursion();
  }
  
  public void GameRecursion () {
    CharacterMovement move = new CharacterMovement();
    move.CharacterWalk();
    
    SketchyChest approach = new SketchyChest();
    approach.ApproachingChest();
    
    CharacterMovement moveAgain = new CharacterMovement();
    moveAgain.TravelAgain();
    
    GameRecursion();
    
    
    
  }
  
  public void EndGame () {
      
      Console.WriteLine("Thank you for Playing");
      Console.WriteLine();
      Console.WriteLine("Throughout your travels you attained " + CharacterInventory.chargold + " Gold!");
      Environment.Exit(0);
  }
}