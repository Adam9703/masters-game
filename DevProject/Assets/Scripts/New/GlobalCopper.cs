using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCopper : MonoBehaviour
{
    public static int copperCount;
    public GameObject copperDisplay;
    public int internalCopper;

    void Update()
    {
        internalCopper = copperCount;
        copperDisplay.GetComponent<Text>().text = "Copper: " + internalCopper;
    }
}
