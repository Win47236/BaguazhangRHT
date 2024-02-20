using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rig1Count : MonoBehaviour
{
    public GameObject triggerBoxA;
    public GameObject triggerBoxB;
    public static int r1Count = 0;
    public Text HUD;

    public static bool setOneMixed = false;
    private string previousBoxEntered = ""; // Variable to store the previous trigger box tag

    private void Update()
    {
        if(r1Count >= 6)
        {
            setOneMixed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(Rig1Ingredients.ingredients)
        {
            if (other.gameObject == triggerBoxA)
            {
                HUD.text = "Entered Trigger Box A";
                if (previousBoxEntered == "TriggerBoxB")
                {
                    r1Count++;
                    HUD.text = r1Count.ToString();
                }
                previousBoxEntered = "TriggerBoxA"; // Update previous trigger box
            }
            else if (other.gameObject == triggerBoxB)
            {
                HUD.text = "Entered Trigger Box B";
                if (previousBoxEntered == "TriggerBoxA")
                {
                    r1Count++;
                    HUD.text = r1Count.ToString();
                }
                previousBoxEntered = "TriggerBoxB"; // Update previous trigger box
            }
        }
    }
}
