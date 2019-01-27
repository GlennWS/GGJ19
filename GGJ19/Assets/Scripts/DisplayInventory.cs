using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public Canvas canv;
    private bool invIsActive = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && invIsActive == false)
        {
            canv.targetDisplay = 0;
            invIsActive = true;
        } else if (Input.GetKeyDown(KeyCode.I) && invIsActive == true)
        {
            canv.targetDisplay = 7;
            invIsActive = false;
        }
    }
}
