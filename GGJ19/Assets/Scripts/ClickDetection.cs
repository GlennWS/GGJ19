using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetection : MonoBehaviour
{
    public GameObject activation;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            activation.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            activation.SetActive(false);
        }
    }

    void Update()
    {
        if (activation.activeSelf == true && Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("wassup yo");
        }
    }
}
