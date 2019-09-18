using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStone : MonoBehaviour
{
    // Mars
    // Variables for buying and selling stone buttons
    public GameObject fakeButtonMars, fakeTextMars, realButtonMars, realTextMars,
        fakeSellButtonMars, fakeSellTextMars, realSellButtonMars, realSellTextMars;

    // Saturn
    // Variables for buying and selling stone buttons
    public GameObject fakeButtonSat, fakeTextSat, realButtonSat, realTextSat, 
        fakeSellButtonSat, fakeSellTextSat, realSellButtonSat, realSellTextSat;

    public int currentCash;
    public static int stoneValueMars = 2;
    public static int stoneValueSat = 4;
    public static bool turnOffButton = false;
    public GameObject stoneDisplay;
    public static int stoneCount;
    public int internalStone;

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.cashCount; // Makes sure the current cash for this script references the real cash value

        internalStone = stoneCount;
        stoneDisplay.GetComponent<Text>().text = "Stone: " + internalStone;

        fakeTextMars.GetComponent<Text>().text = "Buy - $" + stoneValueMars;
        realTextMars.GetComponent<Text>().text = "Buy - $" + stoneValueMars;

        fakeSellTextMars.GetComponent<Text>().text = "Sell - $" + stoneValueMars;
        realSellTextMars.GetComponent<Text>().text = "Sell - $" + stoneValueMars;

        fakeTextSat.GetComponent<Text>().text = "Buy - $" + stoneValueSat;
        realTextSat.GetComponent<Text>().text = "Buy - $" + stoneValueSat;

        fakeSellTextSat.GetComponent<Text>().text = "Sell - $" + stoneValueSat;
        realSellTextSat.GetComponent<Text>().text = "Sell - $" + stoneValueSat;

        if (currentCash >= stoneValueMars || currentCash >= stoneValueSat)
        {
            fakeButtonMars.SetActive(false);
            realButtonMars.SetActive(true);

            fakeButtonSat.SetActive(false);
            realButtonSat.SetActive(true);
        }
        if (stoneCount >= 1)
        {
            fakeSellButtonMars.SetActive(false);
            realSellButtonMars.SetActive(true);

            fakeSellButtonSat.SetActive(false);
            realSellButtonSat.SetActive(true);
        }

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
