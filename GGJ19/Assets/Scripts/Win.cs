using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject donation;
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            donation.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            donation.SetActive(false);
        }
    }

    void Update()
    {
        if (donation.activeSelf == true && Input.GetKeyDown(KeyCode.T))
        {
            for (int i = 0; i < Inventory.GetItemsSize(); i++)
            {
                Inventory.StoreAllItems();
            }
            audioData.Play(0);
        }
    }
}
