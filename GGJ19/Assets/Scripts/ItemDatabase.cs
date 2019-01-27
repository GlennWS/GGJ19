using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    void BuildDatabase()
    {
        items = new List<Item>
        {
            new Item(0, "Ruby Necklace", "A valuable Ruby necklace!",
            new Dictionary<string, int>
            {
                {"Value", 10},
            }),

            new Item(1, "Sapphire Necklace", "A valuable Sapphire necklace!",
            new Dictionary<string, int>
            {
                {"Value", 20}
            }),

            new Item(2, "Opal Necklace", "A valuable Opal necklace!",
            new Dictionary<string, int>
            {
                {"Value", 40}
            }),

            new Item(3, "Amethyst Necklace", "A valuable Amethyst necklace!",
            new Dictionary<string, int>
            {
                {"Value", 75}
            }),

            new Item(4, "Ruby Earring", "A valuable Ruby Earring!",
            new Dictionary<string, int>
            {
                {"Value", 125}
            }),

            new Item(5, "Sapphire Earring", "A valuable Sapphire Earring!",
            new Dictionary<string, int>
            {
                {"Value", 150}
            }),

            new Item(6, "Opal Earring", "A valuable Opal Earring!",
            new Dictionary<string, int>
            {
                {"Value", 200}
            }),

            new Item(7, "Amethyst Earring", "A valuable Amethyst Earring!",
            new Dictionary<string, int>
            {
                {"Value", 250}
            }),

            new Item(8, "Ruby Bangle", "A valuable Ruby Bangle!",
            new Dictionary<string, int>
            {
                {"Value", 350}
            }),

            new Item(9, "Sapphire Bangle", "A valuable Sapphire Bangle!",
            new Dictionary<string, int>
            {
                {"Value", 450}
            }),

            new Item(10, "Opal Bangle", "A valuable Opal Bangle!",
            new Dictionary<string, int>
            {
                {"Value", 600}
            }),

            new Item(11, "Amethyst Bangle", "A valuable Amethyst Bangle!",
            new Dictionary<string, int>
            {
                {"Value", 800}
            })
        };
    }
}
