using System;
using System.Collections;
using System.Collections.Generic;

class Title {
    
  public void GameTitle () {

    Console.WriteLine("Welcome to the game. Press Enter to get started!");
    
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      
      while (true) {
          HomePage toHomePage = new HomePage();
    toHomePage.Home();
      }
  }
  
  public void GameLoop () {
    
    
    while (true) {  
    
      
    CharacterMovement move = new CharacterMovement();
    move.CharacterWalk();
    
    Random travelOutcome = new Random ();
    int outcome = travelOutcome.Next (0, 101);
    
    if (outcome <= 40) {
        SketchyChest approach = new SketchyChest();
        approach.ApproachingChest();
    }
    if (outcome > 40 && outcome <= 80) {
        Battle enemy = new Battle();
        enemy.Attack();
    } 
    else if (outcome > 80) {
        Console.Clear();
        Console.WriteLine("Nothing out of the ordinary happens.");
        Console.WriteLine();
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    }
    
    CharacterMovement moveAgain = new CharacterMovement();
    moveAgain.TravelAgain();
    
    }
    
  }
}