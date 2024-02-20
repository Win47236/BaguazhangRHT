using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Rig3Ingredients : MonoBehaviour
{
    private bool plantIsThere = false;
    private bool flowerIsThere = false;
    public static bool ingredients = false;
    public static bool pestle3IsThere = false;

    public Text HUD;
    void Update()
    {
        if (plantIsThere && flowerIsThere && pestle3IsThere)
        {
            ingredients = true;
           // HUD.text = "ingredients3 true";
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
           // HUD.text = "plant3 true";
        }
        if (other.CompareTag("Flower")) //if (other.gameObject == flower)
        {
            flowerIsThere = true;
            //HUD.text = "flower3 true";
        }
        if (other.CompareTag("pestle3")) //if (other.gameObject == pestle1)
        {
            pestle3IsThere = true;
            //HUD.text = "pestle3 true";
        }
        //in theory if the pestle is in the bowl (ie pestle = true) and if the player has to move the pestle between two triggers, I don't need to see if the player is holding the pestle, they have to be.
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plant")) //if (other.gameObject == plant)
        {
            plantIsThere = false;
            //HUD.text = "plant3 false";
        }
        if (other.CompareTag("Flower")) //if (other.gameObject == flower)
        {
            flowerIsThere = false;
            //HUD.text = "flower3 false";
        }
        if (other.CompareTag("pestle3")) //if (other.gameObject == pestle1)
        {
            pestle3IsThere = false;
            //HUD.text = "pestle3 false";
        }
    }
}
