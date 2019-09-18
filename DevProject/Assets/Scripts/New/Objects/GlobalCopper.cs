using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCopper : MonoBehaviour
{
    public static int copperCount; // A global variable for the amount of copper the player has
    public GameObject copperDisplay; // A reference to a game object to update the amount of copper in text
    public int internalCopper; // An internal copper count that does not get modified by other scripts

    void Update()
    {
        internalCopper = copperCount;
        // Update the text object with the current amount of copper stored in the internal copper variable
        copperDisplay.GetComponent<Text>().text = "Copper: " + internalCopper;
    }
}
