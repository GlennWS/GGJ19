using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    static Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Items/accessory_preview");

    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(int id, string title, string description,
        Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i].name.Equals(title))
            {
                icon = sprites[i];
            }
        }
        //this.icon = Resources.Load<Sprite>("Sprites/Items/" + title + ".png");
        this.stats = stats;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i].name.Equals(title))
            {
                icon = sprites[i];
            }
        }
        //this.icon = Resources.Load<Sprite>("Sprites/Items/" + item.title + ".png");
        this.stats = item.stats;
    }
}
