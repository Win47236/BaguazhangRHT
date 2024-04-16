using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ingredients : MonoBehaviour
{
    private bool oneIsThere = false;
    public static bool twoIsThere = false;
    public static bool threeIsThere = false;
    public static bool fourIsThere = false;
    public static bool ingredients = false;
    public static bool pestleIsThere = false;
    public static string colorA; // Store the colors of colliding objects
    public static string colorB;
    public static string colorC;
    public static string colorD;

    public Text HUD;
    private void Start()
    {
        HUD.text = "ingredients searching";
    }
    void Update()
    {
       // if (oneIsThere && twoIsThere && pestleIsThere)
       if(oneIsThere && pestleIsThere)
        {
            ingredients = true;
            HUD.text = "ingredients true";
        }
        else
        {
            ingredients = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("red") || other.CompareTag("blue") || other.CompareTag("yellow") || other.CompareTag("Untagged"))
        if(!other.CompareTag("Untagged"))
        {
            if (colorA == null)
            {
                colorA = other.tag; // Assign the first color
                oneIsThere = true;
               // HUD.text = "colorA" + colorA;
                //HUD.text = "colorA";
            }
            else if (colorB == null && other.tag != colorA)
            {
                colorB = other.tag; // Assign the second color if different from the first
                twoIsThere = true;
                //HUD.text = "colorB" + colorB;
               // HUD.text = "colorB";
            }
            else if (colorC == null && other.tag != colorA && other.tag != colorB)
            {
                colorC = other.tag; // Assign the second color if different from the first
                threeIsThere = true;
            }
            else if (colorD == null && other.tag != colorA && other.tag != colorB && other.tag != colorC)
            {
                colorD = other.tag; // Assign the second color if different from the first
                //threeIsThere = true;
            }
        }
        if (other.CompareTag("pestle"))
        {
            pestleIsThere = true;
            //HUD.text = "Pestle";
        }
    }

   private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("red") || other.CompareTag("blue") || other.CompareTag("yellow")||other.CompareTag("Untagged"))
        {
            if (other.tag == colorA)
            {
                colorA = null;
                oneIsThere = false;
                // Reset colorA if the object leaving was colorA
               //HUD.text = "colorA null";
            }
            else if (other.tag == colorB)
            {
                colorB = null;
                twoIsThere = false;
                // Reset colorB if the object leaving was colorB
                //HUD.text = "colorB null";
            }
            else if (other.tag == colorC)
            {
                colorC = null;
              
            }
            else if (other.tag == colorD)
            {
                colorD = null;
          
            }
        }
        if (other.CompareTag("pestle"))
        {
            pestleIsThere = false;
            //HUD.text = "pestle null";
        }
    }

}
