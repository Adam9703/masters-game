﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCopper : MonoBehaviour
{
    public bool MiningCopper = false;
    public static int CopperIncrease = 1;
    public int InternalIncrease;

    // Update is called once per frame
    void Update()
    {
        CopperIncrease = GlobalMiner.minePerSec; // When the amount of miners' increases the copper gained per second is increased
        InternalIncrease = CopperIncrease;
        if(MiningCopper == false)
        {
            MiningCopper = true;
            StartCoroutine(MineTheCopper());
        }
    }

    IEnumerator MineTheCopper()
    {
        GlobalCopper.copperCount += InternalIncrease; // Give the players copper count +1
        yield return new WaitForSeconds(1); // Wait for 1 second before setting mining state to false
        MiningCopper = false;
    }
}
