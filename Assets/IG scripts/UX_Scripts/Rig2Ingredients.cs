using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Rig2Ingredients : MonoBehaviour
{
    private bool plantIsThere = false;
    private bool flowerIsThere = false;
    public static bool ingredients = false;
    public static bool pestle2IsThere = false;

    public Text HUD;
    void Update()
    {
        if (plantIsThere && flowerIsThere && pestle2IsThere)
        {
            ingredients = true;
            //HUD.text = "ingredients2 true";
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
            //HUD.text = "plant2 true";
        }
        if (other.CompareTag("Flower")) //if (other.gameObject == flower)
        {
            flowerIsThere = true;
           // HUD.text = "flower2 true";
        }
        if (other.CompareTag("pestle2")) //if (other.gameObject == pestle1)
        {
            pestle2IsThere = true;
            //HUD.text = "pestle2 true";
        }
        //in theory if the pestle is in the bowl (ie pestle = true) and if the player has to move the pestle between two triggers, I don't need to see if the player is holding the pestle, they have to be.
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plant")) //if (other.gameObject == plant)
        {
            plantIsThere = false;
           // HUD.text = "plant2 false";
        }
        if (other.CompareTag("Flower")) //if (other.gameObject == flower)
        {
            flowerIsThere = false;
           // HUD.text = "flower2 false";
        }
        if (other.CompareTag("pestle2")) //if (other.gameObject == pestle1)
        {
            pestle2IsThere = false;
           // HUD.text = "pestle2 false";
        }
    }
}
