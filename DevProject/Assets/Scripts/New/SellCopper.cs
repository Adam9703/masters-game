using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCopper : MonoBehaviour
{
    public GameObject textbox;
    public GameObject statusBox;

    public AudioSource playSound;

    public void ClickButton()
    {
        if(GlobalCopper.copperCount == 0)
        {
            statusBox.GetComponent<Text>().text = "You don't have any copper to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalCopper.copperCount -= 1;
            GlobalCash.cashCount += 1;
            playSound.Play();
        }
    }
}
