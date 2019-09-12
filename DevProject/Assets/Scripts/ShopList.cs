using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


// A class purely for information about items
[System.Serializable] // Allows you to set the values of the class in the Unity inspector instead of coding each one
public class Item
{
    public string itemName;
    public Sprite itemIcon;
    public int price = 1;
}

public class ShopList : MonoBehaviour
{
    public List<Item> itemList; // This is for storing the items in a list from the item class
    public Transform contentPanel; // Used for organizing the content differently, you can set which panel the list will be attached to using this
    public ShopList otherShop; // This is how each shop panel calls each other's functions
    public TextMeshProUGUI cashDisplay; // Holds a reference to the text showing how much cash the player has
    public ObjectPool buttonObjectPool; // Used to hold reference to the object pool so we can grab or remove more buttons from this
    public float cash = 20f; // Amount of cash the panel has

    // Start is called before the first frame update
    void Start()
    {
        Refresh(); // Call the refresh function as the game starts
    }
    
    // This calls the add button function, called every time something changes e.g. buy or sell an item
    public void Refresh()
    {
        cashDisplay.text = "Cash: " + cash.ToString(); // Update the cash display in the shop
        RemoveButtons();
        AddButtons();
    }

    void OnDestroy()
    {
        // Saves data to the save file
        // This will happen whenever this object is destroyed i.e scene change or program exit
        
    }

    // This goes through the list and calculates how many items are in it
    // It adds buttons for each item to populate the listen
    private void AddButtons()
    {
        // Loop over all the items in the list, stop looping when they have all been counted for
        for (int i = 0; i < itemList.Count; i++)
        {
            Item item = itemList[i]; // Create a new item and set it equal to the current item in the itemList
            GameObject newButton = buttonObjectPool.GetObject(); // Retrieve an object from the object pool and store it in a new button
            newButton.transform.SetParent(contentPanel); // Parent the new button to the content panel, the button is added to the vertical layout on the panel and arranged correctly

            ItemButton itemButton = newButton.GetComponent<ItemButton>(); // Get a reference from the item button script that is attached to the button prefab
            itemButton.Setup(item, this);
        }
    }

    // Loop through all child objects of the content panel and remove them all and place back in the object pool
    private void RemoveButtons()
    {
        // While there are children within the content panel
        while(contentPanel.childCount > 0)
        {
            // As long as there are child objects you can keep removing
            // Store child 0's game object and store in the toRemove variable
            GameObject toRemove = transform.GetChild(0).gameObject;

            // Send each button in the list back to the object pool and add buttons still in the list
            buttonObjectPool.ReturnObject(toRemove);
        }
    }

    public void TransferItem(Item item)
    {
        // Does the other shop have enough cash to buy the item the player is trying to sell
        if(otherShop.cash >= item.price)
        {
            cash += item.price; // The player sells the item and gains cash
            otherShop.cash -= item.price; // The other shop loses cash because they bought the item
            AddItem(item, otherShop); // Adds the item to the other shop by passing in the item details
            RemoveItem(item, this); // Removes the item from this shop

            // Updates the list display of buttons (visual representation)
            Refresh();
            otherShop.Refresh();
        }
    }

    // Add and remove item functions to swap items from one list to another e.g. from merchant to player vice versa
    // Used to add items to the list
    private void AddItem(Item itemToAdd, ShopList shopList)
    {
        shopList.itemList.Add(itemToAdd); 
    }

    // Used to remove items from the list
    private void RemoveItem(Item itemToRemove, ShopList shopList)
    {
        // A for loop to count backwards (down) to allow the removing of items safely
        // Counting up and removing items whilst counting would mess up the count
        for(int i = shopList.itemList.Count -1; i >= 0; i--)
        {
            if (shopList.itemList[i] == itemToRemove){
                shopList.itemList.RemoveAt(i); // Iterate over the list and when you find what you want to remove you remove at the current index
            }
        }
    }
}
