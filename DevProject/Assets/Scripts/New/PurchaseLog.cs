using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoMine;
    public GameObject autoSell;

    public void StartAutoMine()
    {
        
        autoMine.SetActive(true);
        GlobalCash.cashCount -= GlobalMiner.minerValue;
        GlobalMiner.minerValue *= 2;
        GlobalMiner.turnOffButton = true;
        GlobalMiner.minePerSec += 1;
        GlobalMiner.numberOfMiners += 1;
    }

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
