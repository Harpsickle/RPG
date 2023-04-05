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
    
    SketchyChest approach = new SketchyChest();
    approach.ApproachingChest();
    
    CharacterMovement moveAgain = new CharacterMovement();
    moveAgain.TravelAgain();
    
    }
  }
}