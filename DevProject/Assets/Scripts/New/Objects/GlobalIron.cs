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
    public static int ironValueMars = 4;
    public static int ironValueSat = 7;
    public static bool turnOffButton = false;
    public GameObject ironDisplay;
    public static int ironCount;
    public int internalIron;

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.cashCount; // Makes sure the current cash for this script references the real cash value

        internalIron = ironCount;
        ironDisplay.GetComponent<Text>().text = "Iron: " + internalIron;

        fakeTextMars.GetComponent<Text>().text = "Buy - $" + ironValueMars;
        realTextMars.GetComponent<Text>().text = "Buy - $" + ironValueMars;

        fakeSellTextMars.GetComponent<Text>().text = "Sell - $" + ironValueMars;
        realSellTextMars.GetComponent<Text>().text = "Sell - $" + ironValueMars;

        fakeTextSat.GetComponent<Text>().text = "Buy - $" + ironValueSat;
        realTextSat.GetComponent<Text>().text = "Buy - $" + ironValueSat;

        fakeSellTextSat.GetComponent<Text>().text = "Sell - $" + ironValueSat;
        realSellTextSat.GetComponent<Text>().text = "Sell - $" + ironValueSat;

        if (currentCash >= ironValueMars || currentCash >= ironValueSat)
        {
            fakeButtonMars.SetActive(false);
            realButtonMars.SetActive(true);

            fakeButtonSat.SetActive(false);
            realButtonSat.SetActive(true);
        }
        if (ironCount >= 1)
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
