using System;
using System.Collections;
using System.Collections.Generic;

class Title {
    
  public void GameTitle () {

    string welcome = "Welcome to the game. Press Enter to get started!";
    Console.WriteLine("{0," + ((Console.WindowWidth / 2) + welcome.Length / 2) + "}", welcome);
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      HomePage toHomePage = new HomePage();
    toHomePage.Home();
  }
  
  public void GameLoop () {
    
    
    
    while (true) {  
    
      
    CharacterMovement move = new CharacterMovement();
    move.CharacterWalk();
    
    Random travelOutcome = new Random ();
    int outcome = travelOutcome.Next (0, 101);
    
    if (outcome <= 25) {
        SketchyChest approach = new SketchyChest();
        approach.ApproachingChest();
    }
    if (outcome > 25 && outcome <= 65) {
        Battle enemy = new Battle();
        enemy.Attack();
    } 
    else if (outcome > 65) {
        Console.Clear();
        Console.WriteLine("Nothing out of the ordinary happens.");
        Console.WriteLine();
    }
    
    CharacterMovement moveAgain = new CharacterMovement();
    moveAgain.TravelAgain();
    
    }
  }
}