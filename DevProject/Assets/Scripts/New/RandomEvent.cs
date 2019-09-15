using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEvent : MonoBehaviour
{
    public GameObject statusBox; // Retrieve status box to display message
    public float copperCheck; // Used to reference against chance of event
    public int genChance; // Generate the chance of event
    public bool eventActive = false; // Is an event active or not, default as false because one is not active on start
    public int copperLoss; // How much copper the player has lost

    // Update is called once per frame
    void Update()
    {
        copperCheck = GlobalCopper.copperCount / 5; // E.g. 250 copper sets coppercheck to 2.5
        if(eventActive == false)
        {
            StartCoroutine(StartEvent());
        }
    }

    IEnumerator StartEvent()
    {
        eventActive = true; // Don't start again every frame
        genChance = Random.Range(1, 20); // Generate how often an event occurs, a lower number increases the chance of events
        if(copperCheck >= genChance)
        {
            copperLoss = Mathf.RoundToInt(GlobalCopper.copperCount * 0.25f); // Returns 25% of the player's copper count, rounds it to nearest whole number
            statusBox.GetComponent<Text>().text = "Oh no, You lost " + copperLoss + " copper to bandits!"; // Display message in status box of event
            GlobalCopper.copperCount -= copperLoss; // Subtract the loss from the total count
            yield return new WaitForSeconds(1); // Wait for 3 seconds before playing animation
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(2); // Lower the number, more frequent the event
        eventActive = false;
    }
}
