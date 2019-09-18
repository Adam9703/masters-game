using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public int saveGameCash;
    public static int saveValue = 10;
    public GameObject saveButton;
    public GameObject saveText;

    // Update is called once per frame
    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost - " + saveValue;
        saveGameCash = GlobalCash.cashCount;

        // Check if the player has enough money to save the game
        // If they have more money than the cost of a save, set the button to interactable (player can click it)
        if(saveGameCash >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            // If they have less money than the save value, disable the button so they can't save
            saveButton.GetComponent<Button>().interactable = false;

        }
    }

    // A function that sets the global variables to a playerpref with a name so it can be 
    // referenced in another script and loaded elsewhere
    public void SaveTheGame()
    {
        // When the player saves the game it removes the correct amount of cash which is based on the saveValue which is 10 coins by default
        GlobalCash.cashCount -= saveValue; 

        // Save the game information into integer player prefs
        PlayerPrefs.SetInt("SaveCopper", GlobalCopper.copperCount);
        PlayerPrefs.SetInt("SaveCash", GlobalCash.cashCount);
        PlayerPrefs.SetInt("SaveMiners", GlobalMiner.minePerSec);
        PlayerPrefs.SetInt("SaveShops", GlobalShop.numberOfShops);
        saveValue *= 2; // Multiplies the save value by 2 each time, costs more each time you save
        PlayerPrefs.SetInt("SaveValue", saveValue); // Save the saveValue again with the new value after calculation cost
    }
}
