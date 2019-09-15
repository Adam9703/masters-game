using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public GameObject textbox;

    public void ClickButton()
    {
        GlobalCopper.copperCount += 1;
    }
}
