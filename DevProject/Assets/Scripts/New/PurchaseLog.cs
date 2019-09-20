using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoMine; // A gameobject to reference the auto mine copper script
    public GameObject autoSell; // A gameobject to reference the auto sell copper script

    public void StartAutoMine()
    {
        
        autoMine.SetActive(true); // Set the automine script to activate when the player has bought a miner upgrade
        GlobalCash.cashCount -= GlobalMiner.minerValue; // Subtract the cost of the miner from the player's cash
        GlobalMiner.minerValue *= 2; // Multiply the miner cost by 2 so it doubles each time they buy one
        GlobalMiner.turnOffButton = true; // Turn the button off if they they cant afford one
        GlobalMiner.minePerSec += 1; // Add to the mine per sec variable in miner so it mines 1 copper per sec
        GlobalMiner.numberOfMiners += 1; // Increase the number of miners by 1 so it can be shown on display
    }

    // This function works the same as the auto mine but with shop values instead
    public void StartAutoSell()
    {
        autoSell.SetActive(true);
        GlobalCash.cashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 2;
        GlobalShop.turnOffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }
}
