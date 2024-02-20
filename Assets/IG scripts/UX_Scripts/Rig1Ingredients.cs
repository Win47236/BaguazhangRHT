using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Rig1Ingredients : MonoBehaviour
{
    private bool plantIsThere = false;
    private bool flowerIsThere = false;
    public static bool ingredients = false;
    public static bool pestle1IsThere = false;

    public Text HUD;
    void Update()
    {
        if (plantIsThere && flowerIsThere && pestle1IsThere)
        {
            ingredients = true;
            //HUD.text = "ingredients1 true";
        }
        else
        {
            ingredients = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plant")) //if (other.gameObject == plant)
        {
            plantIsThere = true;
            //HUD.text = "plant1 true";
        }
        if (other.CompareTag("Flower")) //if (other.gameObject == flower)
        {
            flowerIsThere = true;
            //HUD.text = "flower1 true";
        }
        if (other.CompareTag("pestle1")) //if (other.gameObject == pestle1)
        {
            pestle1IsThere = true;
            //HUD.text = "pestle1 true";
        }
        //in theory if the pestle is in the bowl (ie pestle = true) and if the player has to move the pestle between two triggers, I don't need to see if the player is holding the pestle, they have to be.
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plant")) //if (other.gameObject == plant)
        {
            plantIsThere = false;
          //  HUD.text = "plant1 false";
        }
        if (other.CompareTag("Flower")) //if (other.gameObject == flower)
        {
            flowerIsThere = false;
            //HUD.text = "flower1 false";
        }
        if (other.CompareTag("pestle1")) //if (other.gameObject == pestle1)
        {
            pestle1IsThere = false;
           // HUD.text = "pestle1 false";
        }
    }
}
