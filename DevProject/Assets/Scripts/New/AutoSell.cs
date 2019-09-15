using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool SellingCopper = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;

    // Update is called once per frame
    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec; // When the amount of miners' increases the copper gained per second is increased
        InternalIncrease = CashIncrease;
        if(SellingCopper == false)
        {
            SellingCopper = true;
            StartCoroutine(SellTheCopper());
        }
    }

    IEnumerator SellTheCopper()
    {
        if(GlobalCopper.copperCount == 0)
        {
            // can't do anything
        }
        else
        {
            GlobalCash.cashCount += InternalIncrease;
            GlobalCopper.copperCount -= 1;
            yield return new WaitForSeconds(1);
            SellingCopper = false;
        }
    }
}
