using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalIron : MonoBehaviour
{
    // Mars
    // Variables for buying and selling iron buttons
    public GameObject fakeButtonMars, fakeTextMars, realButtonMars, realTextMars,
        fakeSellButtonMars, fakeSellTextMars, realSellButtonMars, realSellTextMars;

    // Saturn
    // Variables for buying and selling iron buttons
    public GameObject fakeButtonSat, fakeTextSat, realButtonSat, realTextSat, 
        fakeSellButtonSat, fakeSellTextSat, realSellButtonSat, realSellTextSat;

    public int currentCash;
    public static int ironValueMars = 4; // Default value for iron on mars
    public static int ironValueSat = 7; // Default value for iron on saturn
    public static bool turnOffButton = false; // Set turn off button to false by default
    public GameObject ironDisplay;
    public static int ironCount;
    public int internalIron;

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.cashCount; // Makes sure the current cash for this script references the real cash value

        internalIron = ironCount; // Retrieve the player's current iron count and set to a new variable
        ironDisplay.GetComponent<Text>().text = "Iron: " + internalIron; // Display the count by retrieving the text object

        fakeTextMars.GetComponent<Text>().text = "Buy - $" + ironValueMars;
        realTextMars.GetComponent<Text>().text = "Buy - $" + ironValueMars;

        fakeSellTextMars.GetComponent<Text>().text = "Sell - $" + ironValueMars;
        realSellTextMars.GetComponent<Text>().text = "Sell - $" + ironValueMars;

        fakeTextSat.GetComponent<Text>().text = "Buy - $" + ironValueSat;
        realTextSat.GetComponent<Text>().text = "Buy - $" + ironValueSat;

        fakeSellTextSat.GetComponent<Text>().text = "Sell - $" + ironValueSat;
        realSellTextSat.GetComponent<Text>().text = "Sell - $" + ironValueSat;

        // Check if the players current cash is more than the cost of the iron on each store
        // If it is, they have enough money to buy an item so set the button to interactable
        if (currentCash >= ironValueMars || currentCash >= ironValueSat)
        {
            fakeButtonMars.SetActive(false);
            realButtonMars.SetActive(true);

            fakeButtonSat.SetActive(false);
            realButtonSat.SetActive(true);
        }
        // If the player has 1 or more iron then they can sell it to the store
        if (ironCount >= 1)
        {
            fakeSellButtonMars.SetActive(false);
            realSellButtonMars.SetActive(true);

            fakeSellButtonSat.SetActive(false);
            realSellButtonSat.SetActive(true);
        }
        // If the player doesn't have enough then set the turn off button to true so that it is not interactable
        if (turnOffButton == true)
        {
            realButtonMars.SetActive(false);
            fakeButtonMars.SetActive(true);

            realSellButtonSat.SetActive(false);
            fakeSellButtonSat.SetActive(true);

            turnOffButton = false;
        }
    }

}
