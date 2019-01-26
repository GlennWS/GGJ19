using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static List<Item> characterItems = new List<Item>();
    public static ItemDatabase itemDatabase;
    public static UIInventory inventoryUI;

    private void Start()
    {
        itemDatabase = FindObjectOfType<ItemDatabase>();
        inventoryUI = FindObjectOfType<UIInventory>();
    }

    public static void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public static void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public static Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }

    public static void RemoveItem(int id)
    {
        Item item = CheckForItem(id);
        if (item != null)
        {
            characterItems.Remove(item);
            inventoryUI.RemoveItem(item);
            Debug.Log("Item removed: " + item.title);
        }
    }
}
