using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public Canvas inv;
    public Canvas help;
    private bool invIsActive = false;
    private bool helpIsActive = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && invIsActive == false)
        {
            inv.targetDisplay = 0;
            invIsActive = true;
        } else if (Input.GetKeyDown(KeyCode.I) && invIsActive == true)
        {
            inv.targetDisplay = 7;
            invIsActive = false;
        }

        if (Input.GetKeyDown(KeyCode.H) && helpIsActive == false)
        {
            help.targetDisplay = 0;
            helpIsActive = true;
        }
        else if (Input.GetKeyDown(KeyCode.H) && helpIsActive == true)
        {
            help.targetDisplay = 7;
            helpIsActive = false;
        }
    }
}
