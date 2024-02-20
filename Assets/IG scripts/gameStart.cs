using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    public GameObject redCube;
    public GameObject blueCube;
    public GameObject yellowCube;
    public GameObject pestle;

    public Transform redTransform;
    public Transform blueTransform;
    public Transform yellowTransform;
    public Transform pestleSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redCube, redTransform.position, redTransform.rotation);
        Instantiate(blueCube, blueTransform.position, blueTransform.rotation);
        Instantiate(yellowCube, yellowTransform.position, yellowTransform.rotation);
        //Instantiate(pestle, pestleSpawn.position, pestleSpawn.rotation);
    }
}
