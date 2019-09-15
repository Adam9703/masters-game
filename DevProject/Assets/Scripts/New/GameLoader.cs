using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int saveCopper;
    public int saveCash;
    public int saveMiners;
    public int saveShops;
    public int savedValue;

    // Start is called before the first frame update
    void Start()
    {
        if(MainMenu.isLoading == true)
        {
            saveCopper = PlayerPrefs.GetInt("SaveCopper");
            GlobalCopper.copperCount = saveCopper;

            saveCash = PlayerPrefs.GetInt("SaveCash");
            GlobalCash.cashCount = saveCash;

            saveMiners = PlayerPrefs.GetInt("SaveMiners");
            GlobalMiner.minePerSec = saveMiners;

            saveShops = PlayerPrefs.GetInt("SaveShops");
            GlobalShop.numberOfShops = saveShops;

            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;
        }
    }
}
