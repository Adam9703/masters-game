using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCash : MonoBehaviour
{
    public static int cashCount;
    public GameObject cashDisplay;
    public int internalCash;

    void Update()
    {
        internalCash = cashCount;
        cashDisplay.GetComponent<Text>().text = "Cash: " + internalCash;
    }
}
