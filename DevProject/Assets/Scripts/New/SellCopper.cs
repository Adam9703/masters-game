using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCopper : MonoBehaviour
{
    public GameObject textbox;
    public GameObject statusBox; // Used to notify the player when they are out of copper

    public AudioSource playSound;

    public void ClickButton()
    {
        // Check if the player's copper count is 0 and prevent them from selling nothing and gaining cash
        if(GlobalCopper.copperCount == 0)
        {
            statusBox.GetComponent<Text>().text = "You don't have any copper to sell."; // Show this message in a text box on the screen
            statusBox.GetComponent<Animation>().Play("StatusAnim"); // Apply and animation to the text
        }
        else
        {
            // If the player has enough copper, remove one and give them 1 coin
            GlobalCopper.copperCount -= 1;
            GlobalCash.cashCount += 1;
            playSound.Play();
        }
    }
}
