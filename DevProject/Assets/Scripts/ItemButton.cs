using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemButton : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI nameLabel; // Name of the item
    public TextMeshProUGUI priceLabel; // Price of the item
    public Image iconImage;

    private Item item;
    private ShopList scrollList;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Click);
    }

    public void Setup(Item currentItem, ShopList currentScrollList)
    {
        item = currentItem; // The item passed in when the function was called, contains name, price and icon image
        
        // Display this data on nameLabel, priceLabel and iconImage
        nameLabel.text = item.itemName;
        priceLabel.text = item.price.ToString();
        iconImage.sprite = item.itemIcon;

        scrollList = currentScrollList; // The button now knows what list is currently belongs to
    }

    public void Click()
    {
        scrollList.TransferItem(item); // Button calls the transfer item on the scroll list it is attached to
    }
}
