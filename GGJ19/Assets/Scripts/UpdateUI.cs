using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    public GameObject score;
    public GameObject energy;

    void Update()
    {
        score.GetComponentInChildren<TextMeshProUGUI>().text = "Score: " + Inventory.GetScore().ToString();
        energy.GetComponentInChildren<TextMeshProUGUI>().text = "Energy: " + Inventory.GetEnergy().ToString();
    }
}
