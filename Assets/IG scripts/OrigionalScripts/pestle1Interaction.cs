using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class pestle1Interaction : MonoBehaviour
{
    private float count;
    public GameObject pestle1;
    public GameObject pestleCheck;
    public GameObject potion;
    public GameObject plant;
    public GameObject flower;
    public GameObject player;

    public Text location;

    private InputData _inputData;

    //private bool grabbedPestle = false;

    public LayerMask insideMortarLayer;

    Vector3 startPosition;
    Vector3 controllerPosition;

    private void Start()
    {
        _inputData = player.GetComponent<InputData>();
        location.text = "starting script two";
        count = 0;
        location.text = count.ToString();
    }

    private void Update()
    {
        if (rig1Interaction.ingredients)
        {
            makePotion();
        }
    }

    void makePotion()
    {
        //if (_inputData._rightController.TryGetFeatureValue(CommonUsages.gripButton, out bool gripPressed)){}
        bool inRange = Physics.CheckSphere(pestleCheck.transform.position, 1f, insideMortarLayer);
        if (inRange)
        {
            startPosition = pestle1.transform.position;
            if (_inputData._rightController.TryGetFeatureValue(CommonUsages.gripButton, out bool gripPressed))
            {
                if (gripPressed)
                {

                }
            }
            recordControllerMovement();

            if (controllerPosition.x >= 0.05)
            {
                count++;
                location.text = "right \n" + count + "\n" + controllerPosition.ToString();
            }
            if (controllerPosition.x <= 0.02)
            {
                count++;
                location.text = "left \n" + count + "\n" + controllerPosition.ToString();
            }
            if (count >= 6)
            {
                location.text = "418: I'm a teapot!";
                //PotionSpawn();
            }
        }
    }

    void checkControllerPosition()
    {
        //add info here
    }

    void PotionSpawn()
    {
        /* 
        if (count >= 6f)
        {
            Destroy(plant);
            Destroy(flower);
            Instantiate(potion, new Vector3(0, 0, 0), Quaternion.identity); //need to set the coordinates for the first potion spawn

            Instantiate(plant, new Vector3(-7.3f, 0.45f, 3f), Quaternion.identity); //reset the plant to be back on the initial table for player to grab
            Instantiate(flower, new Vector3(-7f, 0.45f, 4f), Quaternion.identity); //reset the flower to be back on the initial table for player to grab
        }
    } */
    }

    void recordControllerMovement()
    {
        _inputData._rightController.TryGetFeatureValue(CommonUsages.devicePosition, out controllerPosition);
        location.text = controllerPosition.ToString();
        //Values will print in (X, Y, Z) format
        //values I got during testing:
        //x: -.11 -0.04  0.05
        //y: 0.75   .77  .80
    }

}
