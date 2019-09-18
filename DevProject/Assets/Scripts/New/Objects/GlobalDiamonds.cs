using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDiamonds : MonoBehaviour
{
    // Mars
    // Variables for buying and selling diamonds buttons
    public GameObject fakeButtonMars, fakeTextMars, realButtonMars, realTextMars,
        fakeSellButtonMars, fakeSellTextMars, realSellButtonMars, realSellTextMars;

    // Saturn
    // Variables for buying and selling diamonds buttons
    public GameObject fakeButtonSat, fakeTextSat, realButtonSat, realTextSat, 
        fakeSellButtonSat, fakeSellTextSat, realSellButtonSat, realSellTextSat;

    public int currentCash;
    public static int diamondValueMars = 8;
    public static int diamondValueSat = 5;
    public static bool turnOffButton = false;
    public GameObject diamondDisplay;
    public static int diamondCount;
    public int internalDiamond;

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.cashCount; // Makes sure the current cash for this script references the real cash value

        internalDiamond = diamondCount;
        diamondDisplay.GetComponent<Text>().text = "Diamonds: " + internalDiamond;

        fakeTextMars.GetComponent<Text>().text = "Buy - $" + diamondValueMars;
        realTextMars.GetComponent<Text>().text = "Buy - $" + diamondValueMars;

        fakeSellTextMars.GetComponent<Text>().text = "Sell - $" + diamondValueMars;
        realSellTextMars.GetComponent<Text>().text = "Sell - $" + diamondValueMars;

        fakeTextSat.GetComponent<Text>().text = "Buy - $" + diamondValueSat;
        realTextSat.GetComponent<Text>().text = "Buy - $" + diamondValueSat;

        fakeSellTextSat.GetComponent<Text>().text = "Sell - $" + diamondValueSat;
        realSellTextSat.GetComponent<Text>().text = "Sell - $" + diamondValueSat;

        if (currentCash >= diamondValueMars || currentCash >= diamondValueSat)
        {
            fakeButtonMars.SetActive(false);
            realButtonMars.SetActive(true);

            fakeButtonSat.SetActive(false);
            realButtonSat.SetActive(true);
        }
        if (diamondCount >= 1)
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
