using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalUranium : MonoBehaviour
{
    // Mars
    // Variables for buying and selling uranium buttons
    public GameObject fakeButtonMars, fakeTextMars, realButtonMars, realTextMars,
        fakeSellButtonMars, fakeSellTextMars, realSellButtonMars, realSellTextMars;

    // Saturn
    // Variables for buying and selling uranium buttons
    public GameObject fakeButtonSat, fakeTextSat, realButtonSat, realTextSat, 
        fakeSellButtonSat, fakeSellTextSat, realSellButtonSat, realSellTextSat;

    public int currentCash;
    public static int uraniumValueMars = 10;
    public static int uraniumValueSat = 16;
    public static bool turnOffButton = false;
    public GameObject uraniumDisplay;
    public static int uraniumCount;
    public int internalUranium;

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.cashCount; // Makes sure the current cash for this script references the real cash value

        internalUranium = uraniumCount;
        uraniumDisplay.GetComponent<Text>().text = "Uranium: " + internalUranium;

        fakeTextMars.GetComponent<Text>().text = "Buy - $" + uraniumValueMars;
        realTextMars.GetComponent<Text>().text = "Buy - $" + uraniumValueMars;

        fakeSellTextMars.GetComponent<Text>().text = "Sell - $" + uraniumValueMars;
        realSellTextMars.GetComponent<Text>().text = "Sell - $" + uraniumValueMars;

        fakeTextSat.GetComponent<Text>().text = "Buy - $" + uraniumValueSat;
        realTextSat.GetComponent<Text>().text = "Buy - $" + uraniumValueSat;

        fakeSellTextSat.GetComponent<Text>().text = "Sell - $" + uraniumValueSat;
        realSellTextSat.GetComponent<Text>().text = "Sell - $" + uraniumValueSat;

        if (currentCash >= uraniumValueMars || currentCash >= uraniumValueSat)
        {
            fakeButtonMars.SetActive(false);
            realButtonMars.SetActive(true);

            fakeButtonSat.SetActive(false);
            realButtonSat.SetActive(true);
        }
        if (uraniumCount >= 1)
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
