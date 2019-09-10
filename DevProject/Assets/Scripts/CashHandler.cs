using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CashHandler : MonoBehaviour
{
    public int playerCash;
    public int playerUranium;
    public TextMeshProUGUI cashText;
    public TextMeshProUGUI uraniumText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll(); // Delete saved data (testing purposes)
        playerCash = 100; // Player starts with 100 cash
        cashText.text = playerCash.ToString(); // .text references text box in unity editor, tostring converts int to characters

        playerUranium = 20;
        uraniumText.text = playerUranium.ToString();

        playerCash = PlayerPrefs.GetInt("cash", 100); // Load data from PlayerPrefs, this may be from previous scene

        playerUranium = PlayerPrefs.GetInt("uranium", 20);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("GameStatus");
        if(go == null)
        {
            Debug.LogError("Failed to find an object named 'GameStatus'");
            this.enabled = false;
            return;
        }

        cashText.text = playerCash.ToString();
        uraniumText.text = playerUranium.ToString();
    }

    void OnDestroy()
    {
        Debug.Log("GameStatus was destroyed");
        // Saves data to the save file
        // This will happen whenever this object is destroyed i.e scene change or program exit
        PlayerPrefs.SetInt("cash", playerCash);
        PlayerPrefs.SetInt("uranium", playerUranium);
    }

    // Amount of money to be added each time it is run
    public void addCash(int cashToAdd)
    {
        playerCash += cashToAdd; // Takes cash to add number and adds the value on top of player cash
        cashText.text = playerCash.ToString();
    }

    public void subtractCash(int cashToSubtract)
    {
        if(playerCash - cashToSubtract < 0)
        {
            Debug.Log("We don't have enough cash");
        }
        else
        {
            playerCash -= cashToSubtract;
            cashText.text = playerCash.ToString();
        }
    }

    // Amount of uranium to be added each time it is run
    public void addUranium(int uraniumToAdd)
    {
        playerUranium += uraniumToAdd; // Takes uranium to add number and adds the value on top of player uranium
        uraniumText.text = playerUranium.ToString();
    }

    public void subtractUranium(int uraniumToSubtract)
    {
        if (playerUranium - uraniumToSubtract < 0)
        {
            Debug.Log("We don't have enough uranium");
        }
        else
        {
            playerUranium -= uraniumToSubtract;
            uraniumText.text = playerUranium.ToString();
        }
    }
}
