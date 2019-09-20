using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject copperTextbox;

    public GameObject ironTextbox;
    public GameObject ironStatus;

    public GameObject diamondTextBox;
    public GameObject diamondStatus;

    public GameObject stoneTextBox;
    public GameObject stoneStatus;

    public GameObject Mars;
    public GameObject Saturn;

    public void Copper()
    {
        GlobalCopper.copperCount += 1;
    }

    public void BuyIron()
    {
        if(GlobalCash.cashCount <= 0)
        {
            ironStatus.GetComponent<Text>().text = "You don't have enough cash."; // Show this message in a text box on the screen
            ironStatus.GetComponent<Animation>().Play("StatusAnim"); // Apply and animation to the text
        }
        else
        {
            if (Mars.GetComponent<Canvas>().isActiveAndEnabled) // Check if the canvas object for mars is enabled in the scene
            {
                GlobalIron.ironCount += 1;
                GlobalCash.cashCount -= GlobalIron.ironValueMars; // Purchase the iron for the value on mars
            }
            if (Saturn.GetComponent<Canvas>().isActiveAndEnabled) // Check if the canvas for saturn is enabled
            {
                GlobalIron.ironCount += 1;
                GlobalCash.cashCount -= GlobalIron.ironValueSat; // Purchase the iron for the value on saturn
            }
            
        }
    }

    public void SellIron()
    {
        if (GlobalIron.ironCount == 0)
        {
            ironStatus.GetComponent<Text>().text = "You don't have any iron."; // Show this message in a text box on the screen
            ironStatus.GetComponent<Animation>().Play("StatusAnim"); // Apply and animation to the text
        }
        else
        {
            if (Mars.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalIron.ironCount -= 1;
                GlobalCash.cashCount += GlobalIron.ironValueMars;
            }
            if (Saturn.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalIron.ironCount -= 1;
                GlobalCash.cashCount += GlobalIron.ironValueSat;
            }
        }
    }

    public void BuyDiamond()
    {
        if (GlobalCash.cashCount <= 0)
        {
            diamondStatus.GetComponent<Text>().text = "You don't have enough cash."; // Show this message in a text box on the screen
            diamondStatus.GetComponent<Animation>().Play("StatusAnim"); // Apply and animation to the text
        }
        else
        {
            if (Mars.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalDiamonds.diamondCount += 1;
                GlobalCash.cashCount -= GlobalDiamonds.diamondValueMars;
            }
            if (Saturn.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalDiamonds.diamondCount += 1;
                GlobalCash.cashCount -= GlobalDiamonds.diamondValueSat;
            }

        }
    }

    public void SellDiamond()
    {
        if (GlobalDiamonds.diamondCount == 0)
        {
            diamondStatus.GetComponent<Text>().text = "You don't have any diamonds."; // Show this message in a text box on the screen
            diamondStatus.GetComponent<Animation>().Play("StatusAnim"); // Apply and animation to the text
        }
        else
        {
            if (Mars.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalDiamonds.diamondCount -= 1;
                GlobalCash.cashCount += GlobalDiamonds.diamondValueMars;
            }
            if (Saturn.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalDiamonds.diamondCount -= 1;
                GlobalCash.cashCount += GlobalDiamonds.diamondValueSat;
            }
        }
    }

    public void BuyStone()
    {
        if (GlobalCash.cashCount <= 0)
        {
            stoneStatus.GetComponent<Text>().text = "You don't have enough cash."; // Show this message in a text box on the screen
            stoneStatus.GetComponent<Animation>().Play("StatusAnim"); // Apply and animation to the text
        }
        else
        {
            if (Mars.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalStone.stoneCount += 1;
                GlobalCash.cashCount -= GlobalStone.stoneValueMars;
            }
            if (Saturn.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalStone.stoneCount += 1;
                GlobalCash.cashCount -= GlobalStone.stoneValueSat;
            }

        }
    }

    public void SellStone()
    {
        if (GlobalStone.stoneCount == 0)
        {
            stoneStatus.GetComponent<Text>().text = "You don't have any stone."; // Show this message in a text box on the screen
            stoneStatus.GetComponent<Animation>().Play("StatusAnim"); // Apply and animation to the text
        }
        else
        {
            if (Mars.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalStone.stoneCount -= 1;
                GlobalCash.cashCount += GlobalStone.stoneValueMars;
            }
            if (Saturn.GetComponent<Canvas>().isActiveAndEnabled)
            {
                GlobalStone.stoneCount -= 1;
                GlobalCash.cashCount += GlobalStone.stoneValueSat;
            }
        }
    }
}
