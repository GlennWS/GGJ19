using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetection : MonoBehaviour
{
    public GameObject activation;
    float time = 0;
    bool playerOn = false;
    AudioSource mainAudio;
    public AudioClip loseEnergy;
    public AudioClip getJewel;

    void Start()
    {
        mainAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            activation.SetActive(true);
            playerOn = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            activation.SetActive(false);
            playerOn = false;
        }
    }

    public struct lootTier
    {
        public int rangeMin;
        public int rangeMax;
        public int chance;
        public int energyCost;

        public lootTier(int ranMin, int ranMax, int chan, int ec)
        {
            rangeMin = ranMin;
            rangeMax = ranMax;
            chance = chan;
            energyCost = ec;
        }
    };

    enum Challenge { Easy, Medium, Hard };
    Dictionary<Challenge, lootTier> loot = new Dictionary<Challenge, lootTier>() {
        { Challenge.Easy, new lootTier(0, 4, 70, 10) },
        { Challenge.Medium, new lootTier(5, 8, 50, 20) },
        { Challenge.Hard, new lootTier(9, 12, 30, 35) } };

    void Update()
    {
        time += Time.deltaTime;
        
        if (playerOn && Input.GetKeyDown(KeyCode.T) && time > 2.0f)
        {
            time = 0;
            int rand = UnityEngine.Random.Range(0, 101);
            Debug.Log(rand);
            Challenge c = (Challenge)Enum.Parse(typeof(Challenge), gameObject.tag);

            if (rand <= loot[c].chance)
            {
                Inventory.GiveItem( UnityEngine.Random.Range(loot[c].rangeMin, loot[c].rangeMax));
                mainAudio.clip = getJewel;
                mainAudio.Play(0);
            }
            else
            {
                Inventory.SubtractEnergy(loot[c].energyCost);
                mainAudio.clip = loseEnergy;
                mainAudio.Play(0);
            }

            //if (gameObject.tag == "Easy" && rand <= 70)
            //{
            //    Inventory.GiveItem(UnityEngine.Random.Range(0, 4));
            //}
            //else if (gameObject.tag == "Medium" && rand <= 50)
            //{
            //    Inventory.GiveItem(UnityEngine.Random.Range(4, 9));
            //}
            //else if (gameObject.tag == "Hard" && rand <= 30)
            //{
            //    Inventory.GiveItem(UnityEngine.Random.Range(9, 12));
            //}
            //else
            //{
            //    Inventory.SubtractEnergy(5);
            //}
        }
    }
}
