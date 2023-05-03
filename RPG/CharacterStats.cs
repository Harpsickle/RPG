using System;
using System.Collections;
using System.Collections.Generic;

class CharacterStats {
    
    public static int charMaxHealth = 20;
    public static int charHealth = 20;
    public static int charDamage = 3;
    public static int charArmor = 0;
    public static int charLevel = 1;
    public static int charExperience = 98;
    public static int charMaxExp = 100;
    public static int charMana = 10;
    public static int charMaxMana = 10;
    
    public static List<string> back = new List<string>() {"Go Back"};
    public static int selectedIndex = 0;
    public static string question = $"Character Stats: {Environment.NewLine}" + 
                                    Environment.NewLine + 
                                    $"Level: {charLevel} EXP: {charExperience}/{charMaxExp} {Environment.NewLine}" + 
                                    $"-------------------------- {Environment.NewLine}" + 
                                    $"HP: {charHealth}/{charMaxHealth} {Environment.NewLine}" + 
                                    $"Mana: {charMana}/{charMaxMana} {Environment.NewLine}" + 
                                    $"Attack Damage: {charDamage} {Environment.NewLine}" +
                                    $"Amor: {charArmor} {Environment.NewLine}" +
                                    Environment.NewLine +
                                    Environment.NewLine;
    
    public void Stats () {
        
        while (true) {
            ChoiceSelect.Selection(back, selectedIndex, question);
	        selectedIndex = ChoiceSelect.overallIndex;
            
            if (back[selectedIndex] == "Go Back") {
                return;
            }
            
        }
      }
    }
  
