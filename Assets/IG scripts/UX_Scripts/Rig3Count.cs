using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rig3Count : MonoBehaviour
{
    public GameObject triggerBoxE;
    public GameObject triggerBoxF;
    public GameObject triggerBoxG;
    public GameObject triggerBoxH;
    public static int r3Count = 0;
    public Text HUD;

    public static bool setThreeMixed = false;
    private bool clockwise = false;
    private bool counterclockwise = false;
    //private bool directionLocked = false;
    private string previousBoxEntered = ""; // Variable to store the previous trigger box tag

    private List<GameObject> triggerOrder = new List<GameObject>();

    private void Update()
    {
        //HUD.text = r3Count.ToString();
        if (r3Count >= 12)
        {
            setThreeMixed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Rig3Ingredients.ingredients)
        {
            // HUD.text = "ingredients3 true";
            // Check if the collided object is a trigger box
            if (other.CompareTag("TriggerBox"))
            {
                // Add the collided trigger box to the triggerOrder list
                triggerOrder.Add(other.gameObject);
                CheckTriggerOrder(other.gameObject);
            }
        }
    }

    private void CheckTriggerOrder(GameObject triggeredObject) //triggerOrder[0] == triggerBox && triggerOrder[1] == triggerBox
    {
        /*if ((triggerOrder[0] == triggerBoxE && triggerOrder[1] == triggerBoxH)|| (triggerOrder[0] == triggerBoxH && triggerOrder[1] == triggerBoxG) 
            || (triggerOrder[0] == triggerBoxG && triggerOrder[1] == triggerBoxF) || (triggerOrder[0] == triggerBoxF && triggerOrder[1] == triggerBoxE))*/
        if(triggerOrder[0] == triggerBoxE && triggerOrder[1] == triggerBoxH)
        { 
            clockwise = true;
            counterclockwise = false;
            ClockwiseCount(triggeredObject);
            HUD.text = "clockwise EH";
        }
        else if (triggerOrder[0] == triggerBoxH && triggerOrder[1] == triggerBoxG)
        {
            clockwise = true;
            counterclockwise = false;
            ClockwiseCount(triggeredObject);
            HUD.text = "clockwise HG";
        }
        else if (triggerOrder[0] == triggerBoxG && triggerOrder[1] == triggerBoxF)
        {
            clockwise = true;
            counterclockwise = false;
            ClockwiseCount(triggeredObject);
            HUD.text = "clockwise GF";
        }
        else if (triggerOrder[0] == triggerBoxF && triggerOrder[1] == triggerBoxE)
        {
            clockwise = true;
            counterclockwise = false;
            ClockwiseCount(triggeredObject);
            HUD.text = "clockwise FE";
        }
        else if (triggerOrder[0] == triggerBoxE && triggerOrder[1] == triggerBoxF)
   /*     else if((triggerOrder[0] == triggerBoxE && triggerOrder[1] == triggerBoxF) || (triggerOrder[0] == triggerBoxF && triggerOrder[1] == triggerBoxG)
            || (triggerOrder[0] == triggerBoxG && triggerOrder[1] == triggerBoxH) || (triggerOrder[0] == triggerBoxH && triggerOrder[1] == triggerBoxE))*/
        {
            counterclockwise = true;
            clockwise = false;
            CounterClockwiseCount(triggeredObject);
            HUD.text = "CounterClockwiseEF";
        }
        else if (triggerOrder[0] == triggerBoxF && triggerOrder[1] == triggerBoxG)
        {
            counterclockwise = true;
            clockwise = false;
            CounterClockwiseCount(triggeredObject);
            HUD.text = "CounterClockwiseFG";
        }
        else if (triggerOrder[0] == triggerBoxG && triggerOrder[1] == triggerBoxH)
        {
            counterclockwise = true;
            clockwise = false;
            CounterClockwiseCount(triggeredObject);
            HUD.text = "CounterClockwiseGH";
        }
        else if (triggerOrder[0] == triggerBoxH && triggerOrder[1] == triggerBoxE)
        {
            counterclockwise = true;
            clockwise = false;
            CounterClockwiseCount(triggeredObject);
            HUD.text = "CounterClockwiseHE";
        }
        else
        {
            // If none of the specified conditions match, reset triggerOrder
            triggerOrder.Clear();
            // Restart the tracking by adding the current triggered object
            //triggerOrder.Add(triggeredObject);
            HUD.text = "Reset TriggerOrder. Try again";
        }
    }

    private void ClockwiseCount(GameObject other)
    {
        if (other == triggerBoxE)
        {
            //HUD.text = "Entered Trigger Box E";
            if (previousBoxEntered == "TriggerBoxF")
            {
                r3Count++;
                
                //HUD.text = r3Count.ToString();
            }
            previousBoxEntered = "TriggerBoxE"; // Update previous trigger box
        }
        else if (other == triggerBoxH)
        {
           // HUD.text = "Entered Trigger Box H";
            if (previousBoxEntered == "TriggerBoxE")
            {
                r3Count++;
                //HUD.text = r3Count.ToString();
            }
            previousBoxEntered = "TriggerBoxH"; // Update previous trigger box
        }
        else if (other == triggerBoxG)
        {
            //HUD.text = "Entered Trigger Box G";
            if (previousBoxEntered == "TriggerBoxH")
            {
                r3Count++;
                //HUD.text = r3Count.ToString();
            }
            previousBoxEntered = "TriggerBoxG"; // Update previous trigger box
        }
        else if (other == triggerBoxF)
        {
            //HUD.text = "Entered Trigger Box F";
            if (previousBoxEntered == "TriggerBoxG")
            {
                r3Count++;
                //HUD.text = r3Count.ToString();
            }
            previousBoxEntered = "TriggerBoxF"; // Update previous trigger box
        }
    }

    private void CounterClockwiseCount(GameObject other)
    {
        if (other == triggerBoxE)
        {
            //HUD.text = "Entered Trigger Box E";
            if (previousBoxEntered == "TriggerBoxH")
            {
                r3Count++;
                //HUD.text = r3Count.ToString();
            }
            previousBoxEntered = "TriggerBoxE"; // Update previous trigger box
        }
        else if (other == triggerBoxH)
        {
           // HUD.text = "Entered Trigger Box H";
            if (previousBoxEntered == "TriggerBoxG")
            {
                r3Count++;
                //HUD.text = r3Count.ToString();
            }
            previousBoxEntered = "TriggerBoxH"; // Update previous trigger box
        }
        else if (other == triggerBoxG)
        {
            //HUD.text = "Entered Trigger Box G";
            if (previousBoxEntered == "TriggerBoxF")
            {
                r3Count++;
                //HUD.text = r3Count.ToString();
            }
            previousBoxEntered = "TriggerBoxG"; // Update previous trigger box
        }
        else if (other == triggerBoxF)
        {
            //HUD.text = "Entered Trigger Box F";
            if (previousBoxEntered == "TriggerBoxE")
            {
                r3Count++;
                //HUD.text = r3Count.ToString();
            }
            previousBoxEntered = "TriggerBoxF"; // Update previous trigger box
        }
    }

}
