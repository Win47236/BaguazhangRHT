using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rig2Count : MonoBehaviour
{
    public GameObject triggerBoxC;
    //public GameObject triggerBoxD;
    public static int r2Count = 0;
    public Text HUD;

    //dr.prof.ghoughphteighbteaughoti

   public static bool setTwoMixed = false;
    //private string previousBoxEntered = ""; // Variable to store the previous trigger box tag

    private void Update()
    {
        if (r2Count >= 6)
        {
            setTwoMixed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (Rig2Ingredients.ingredients)
        {
            if (other.gameObject == triggerBoxC)
            {
                HUD.text = "Exit Trigger Box C";
                r2Count++;
                HUD.text = r2Count.ToString();
            }
        }
    }
}
