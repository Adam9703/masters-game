using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DayCounter : MonoBehaviour
{
    public int hours;
    public int days;
    public float counter;

    public TextMeshProUGUI dayText;
    public TextMeshProUGUI hourText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll(); // Delete saved data on startup (testing purposes)
        Time.timeScale = 0.1f; // Slow down delta time to 0.1 of real time

        days = 1;
        dayText.text = days.ToString(); // Change the day text to show the number of the day counter

        hourText.text = hours.ToString(); // Change the hour text to number of hours counter

        hours = PlayerPrefs.GetInt("hours", 0); // Set the hours to previously saved hours data on game startup
        days = PlayerPrefs.GetInt("days", 1); // Set days to saved day data on game startup, default days set to 1 if no data found
        counter = PlayerPrefs.GetFloat("counter", 0); // Counter reset to 0 unless saved data is found
    }

    // Update is called once per frame
    void Update()
    {
        // Find a gameobject in the game which includes data.
        // If not an object named GameStatus is not found display error message
        GameObject go = GameObject.Find("GameStatus");
        if(go == null)
        {
            Debug.LogError("Failed to find an object named 'GameStatus'");
            this.enabled = false;
            return;
        }

        HoursCounter(); // Run hours counter once per frame to keep counting up in delta time

        dayText.text = days.ToString();
        hourText.text = hours.ToString();
    }

    void OnDestroy()
    {
        // When a game is reopened the PlayerPrefs are not destroyed
        // The data is saved and last found data is displayed
        Debug.Log("GameStatus was destroyed");
        PlayerPrefs.SetInt("hours", hours);
        PlayerPrefs.SetInt("days", days);
        PlayerPrefs.SetFloat("counter", counter);
    }

    void HoursCounter()
    {
        Debug.Log("HoursCounter");

        // If the counter is = to 24 then reset back to 0 (only 24 hrs in a day)
        if (counter == 24)
            counter = 0;

        counter += Time.deltaTime; // Every frame this is called, counter will count in real time, slowed down slightly by timescale
        hours = (int)counter; // Convert the counter to a whole number (no decimals) and set the hours = to the counter

        if (counter < 24) // If the counter is less than 24 keep counting and do nothing
            return;

        if (counter > 24) // If counter is greater than 24 stop it from counting over
            counter = 24;

        if (counter == 24) // Each time the counter = 24 run the day counter method
            DaysCounter();

        hourText.text = hours.ToString(); // Set the text of hours = to the number of hours counted
    }

    void DaysCounter()
    {
        Debug.Log("DaysCounter");

        days++; // Increase days counter

        dayText.text = days.ToString();
    }
}
