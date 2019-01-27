using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UpdateUI : MonoBehaviour
{
    public GameObject score;
    public GameObject energy;
    private ClickDetection clickDetection;

    public void SetClickDetection(ClickDetection cd)
    {
        clickDetection = cd;
    }

    public void ResetClickDetection()
    {
        clickDetection = null;
    }

    void Update()
    {
        score.GetComponentInChildren<TextMeshProUGUI>().text = "Score: " + Inventory.GetScore().ToString();
        energy.GetComponentInChildren<TextMeshProUGUI>().text = "Energy: " + Inventory.GetEnergy().ToString();

        if (clickDetection)
        {
            if (clickDetection.time < 5)
            {
                GameObject.FindGameObjectWithTag("Cooldown Meter").transform.localScale =
                    new Vector3(Mathf.Min(clickDetection.time / 5.0f, 1.0f) , 1.0f, 1.0f);
            }
        }
    }
}
