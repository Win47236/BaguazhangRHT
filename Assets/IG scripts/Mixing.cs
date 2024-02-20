using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mixing : MonoBehaviour
{
    public static bool Mixed = false;
    public GameObject triggerBoxA;
    public GameObject triggerBoxB;
    public GameObject triggerBoxC;
    public GameObject triggerBoxD;
    public GameObject triggerBoxE;
    public GameObject triggerBoxF;
    public GameObject triggerBoxG;
    public GameObject triggerBoxH;
    public static int Count = 0;
    public Text HUD;

    private string previousBoxEntered = ""; // Variable to store the previous trigger box tag

    private List<GameObject> triggerOrder = new List<GameObject>();

    private void Update()
    {
        if (Count >= 24)
        {
            Mixed = true;
        }

        else if (Recipies.ClearOrder)
        {
            triggerOrder.Clear();
            Recipies.ClearOrder = false;
            Recipies.potionSpawned = false;
            // HUD.text = "triggerOrder cleared?";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Ingredients.ingredients)
        {
           // HUD.text = "ingredients bool " + Ingredients.ingredients.ToString();
            // Check if the collided object is a trigger box
            if (other.CompareTag("TriggerBox"))
            {
                // Add the collided trigger box to the triggerOrder list
                triggerOrder.Add(other.gameObject);
                CheckTriggerOrder(other.gameObject);
            }
        }
    }

    public void CheckTriggerOrder(GameObject triggeredObject) //triggerOrder[0] == triggerBox && triggerOrder[1] == triggerBox
    {
      if ((triggerOrder[0] == triggerBoxB) || (triggerOrder[0] == triggerBoxH) && triggerOrder[1] == triggerBoxA)
        {
            MixingCounting(triggeredObject);
           // HUD.text = "good start";
        }
        else if ((triggerOrder[0] == triggerBoxC) || (triggerOrder[0] == triggerBoxA) && triggerOrder[1] == triggerBoxB)
        {
            MixingCounting(triggeredObject);
           // HUD.text = "good start";
        }
        else if ((triggerOrder[0] == triggerBoxD) || (triggerOrder[0] == triggerBoxB) && triggerOrder[1] == triggerBoxC)
        {
            MixingCounting(triggeredObject);
            //HUD.text = "good start";
        }
        else if ((triggerOrder[0] == triggerBoxC) || (triggerOrder[0] == triggerBoxE) && triggerOrder[1] == triggerBoxD)
        {
            MixingCounting(triggeredObject);
           // HUD.text = "good start";
        }
        else if ((triggerOrder[0] == triggerBoxF) || (triggerOrder[0] == triggerBoxD) && triggerOrder[1] == triggerBoxE)
        {
            MixingCounting(triggeredObject);
           // HUD.text = "good start";
        }
        else if ((triggerOrder[0] == triggerBoxG) || (triggerOrder[0] == triggerBoxE) && triggerOrder[1] == triggerBoxF)
        {
            MixingCounting(triggeredObject);
            //HUD.text = "good start";
        }
        else if ((triggerOrder[0] == triggerBoxH) || (triggerOrder[0] == triggerBoxF) && triggerOrder[1] == triggerBoxG)
        {
            MixingCounting(triggeredObject);
            //HUD.text = "good start";
        }
        else if ((triggerOrder[0] == triggerBoxA || (triggerOrder[0] == triggerBoxG) && triggerOrder[1] == triggerBoxH))
        {
            MixingCounting(triggeredObject);
            //HUD.text = "good start";
        }

        else
        {
            // If none of the specified conditions match, reset triggerOrder
            triggerOrder.Clear();
           // HUD.text = "Reset TriggerOrder. Try again";
        }
    }

    void MixingCounting(GameObject other)
    {
        if(other == triggerBoxA)
        {
            if(previousBoxEntered == "triggerBoxB" || previousBoxEntered == "triggerBoxH")
            {
                Count++;
                //HUD.text = Count.ToString();
            }
            previousBoxEntered = "triggerBoxA";
        }
        else if (other == triggerBoxB)
        {
            if (previousBoxEntered == "triggerBoxC" || previousBoxEntered == "triggerBoxA")
            {
                Count++;
                //HUD.text = Count.ToString();
            }
            previousBoxEntered = "triggerBoxB";
        }
        else if (other == triggerBoxC)
        {
            if (previousBoxEntered == "triggerBoxB" || previousBoxEntered == "triggerBoxD")
            {
                Count++; 
                //HUD.text = Count.ToString();
            }
            previousBoxEntered = "triggerBoxC";
        }
        else if (other == triggerBoxD)
        {
            if (previousBoxEntered == "triggerBoxE" || previousBoxEntered == "triggerBoxC")
            {
                Count++;
                //HUD.text = Count.ToString();
            }
            previousBoxEntered = "triggerBoxD";
        }
        else if (other == triggerBoxE)
        {
            if (previousBoxEntered == "triggerBoxF" || previousBoxEntered == "triggerBoxD")
            {
                Count++;
               // HUD.text = Count.ToString();
            }
            previousBoxEntered = "triggerBoxE";
        }
        else if (other == triggerBoxF)
        {
            if (previousBoxEntered == "triggerBoxG" || previousBoxEntered == "triggerBoxE")
            {
                Count++;
              //  HUD.text = Count.ToString();
            }
            previousBoxEntered = "triggerBoxF";
        }
        else if (other == triggerBoxG)
        {
            if (previousBoxEntered == "triggerBoxH" || previousBoxEntered == "triggerBoxF")
            {
                Count++;
               // HUD.text = Count.ToString();
            }
            previousBoxEntered = "triggerBoxG";
        }
        else if (other == triggerBoxH)
        {
            if (previousBoxEntered == "triggerBoxG" || previousBoxEntered == "triggerBoxA")
            {
                Count++;
               // HUD.text = Count.ToString();
            }
            previousBoxEntered = "triggerBoxH";
        }
    }
}
