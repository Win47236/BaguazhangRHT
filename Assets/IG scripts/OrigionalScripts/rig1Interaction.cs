using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class rig1Interaction : MonoBehaviour
{
    private bool plantIsThere = false;
    private bool flowerIsThere = false;
    public static bool ingredients = false;
    public static bool holdingPestle1 = false; //change this boolian name depending on which pestle you are holding
    public GameObject plant;
    public GameObject flower;
    public Text location;
    private void Start()
    {

        location.text = "welcome to the game.";
    }

     void Update()
    {
        if (plantIsThere && flowerIsThere && holdingPestle1)
        {
            ingredients = true;
            location.text = "ingredients true";
        }
        else
        {
            ingredients = false;
        }
    }

/*    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plant")
        {
            plantIsThere = true;
            location.text = "plant true";
        }
        else
        {
            //plantIsThere = false;
        }
        if (other.gameObject.tag == "Flower")
        {
            flowerIsThere = true;
            location.text = "flower true";
        }
        else
        {
            //plantIsThere = false;
        }

        if (other.gameObject.tag == "pestle1")
        {
            holdingPestle1 = true;
            location.text = "holding a pestle!";
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plant")
        {
            plantIsThere = true;
            location.text = "plant true";
        }
        else
        {
            //plantIsThere = false;
        }
        if (collision.gameObject.tag == "Flower")
        {
            flowerIsThere = true;
            location.text = "flower true";
        }
        else
        {
            //plantIsThere = false;
        }

        if (collision.gameObject.tag == "pestle1")
        {
            holdingPestle1 = true;
            location.text = "holding a pestle!";
        }
    }
}
