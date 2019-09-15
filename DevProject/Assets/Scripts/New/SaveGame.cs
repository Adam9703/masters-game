using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public int saveGameCash;
    public static int saveValue = 10;
    public GameObject saveButton;
    public GameObject saveText;

    // Update is called once per frame
    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost - " + saveValue;
        saveGameCash = GlobalCash.cashCount;
        if(saveGameCash >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            saveButton.GetComponent<Button>().interactable = false;

        }
    }

    public void SaveTheGame()
    {
        GlobalCash.cashCount -= saveValue;
        PlayerPrefs.SetInt("SaveCopper", GlobalCopper.copperCount);
        PlayerPrefs.SetInt("SaveCash", GlobalCash.cashCount);
        PlayerPrefs.SetInt("SaveMiners", GlobalMiner.minePerSec);
        PlayerPrefs.SetInt("SaveShops", GlobalShop.numberOfShops);
        saveValue *= 2; // Multiplies the save value by 2 each time, costs more each time you save
        PlayerPrefs.SetInt("SaveValue", saveValue);
    }
}
