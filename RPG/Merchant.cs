using System;
using System.Linq;
using System.Collections.Generic;

class Merchant {
    
    public static int selectedIndex = 0;
    
    
  public void BuyFromMerchant() {
        
         while (true) {
             
        string question = $"Merchant: Welcome to my shop. What items would you like? {Environment.NewLine}" +
                          $"------------------------------------------------------------ {Environment.NewLine}" +
                          $"Available Gold: {CharacterInventory.charGold} {Environment.NewLine}";

        ChoiceSelect.Selection(Items.merchantItemSell, selectedIndex, question);
	    selectedIndex = ChoiceSelect.overallIndex;
        
        
        
        if (selectedIndex != 4) {
        
	    if (CharacterInventory.charGold < Items.merchantItemValues[selectedIndex]) {
	        Console.Clear();
	        Console.WriteLine("You don't have enough gold to purchase that item.");
	        while (Console.ReadKey ().Key != ConsoleKey.Enter)
            {
            }
	        continue;
	    }
	    
	    
	    if (CharacterInventory.charGold >= Items.merchantItemValues[selectedIndex]) {
	    CharacterInventory.charGold -= Items.merchantItemValues[selectedIndex];
	    Console.Clear();
	    Console.WriteLine ($"You purchased a {Items.merchantItems[selectedIndex]}");
	    Console.WriteLine();
	    CharacterInventory.charItems.Add(Items.merchantItems[selectedIndex]);
	      if (selectedIndex == 0){
	          CharacterInventory.numberOfHerbs++;
	      }
	      if (selectedIndex == 1){
	          CharacterInventory.numberOfPotions++;
	      }
	      if (selectedIndex == 2){
	          CharacterInventory.numberOfManaPotions++;
	      }
	      if (selectedIndex == 3){
	          CharacterInventory.numberOfFullRestores++;
	      }
	    }
	      
	    
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
            {
            }
	    }
	    
	    if (selectedIndex == 4) {
	        
	       return; 
	    }
	    }
	    }
        }
    
