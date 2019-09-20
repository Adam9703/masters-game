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
    public int saveIron;
    public int saveDiamonds;
    public int saveStone;

    // Start is called before the first frame update
    void Start()
    {
        // This function sets the save variables = to the value of that stored in the playerpref on save click
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

            saveIron = PlayerPrefs.GetInt("SaveIron");
            GlobalIron.ironCount = saveIron;

            saveStone = PlayerPrefs.GetInt("SaveStone");
            GlobalStone.stoneCount = saveStone;

            saveDiamonds = PlayerPrefs.GetInt("SaveDiamonds");
            GlobalDiamonds.diamondCount = saveDiamonds;

            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;
        }
    }
}
