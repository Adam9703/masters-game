using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameController : MonoBehaviour
{
    public string playerName;
    public GameObject inputField;
    //public TextMeshProUGUI textDisplay;

    public void StoreName()
    {
        playerName = inputField.GetComponent<TextMeshProUGUI>().text;
        Debug.Log("You entered: " + playerName);
        //textDisplay.GetComponent<TextMeshProUGUI>().text = playerName;
    }
}
