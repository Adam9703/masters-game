using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    public static string playerNameStr;

    public Text playerName;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = playerNameStr;
    }

}
