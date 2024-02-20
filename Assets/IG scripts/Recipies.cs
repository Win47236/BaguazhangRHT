using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipies : MonoBehaviour
{
    public GameObject ingredient1;
    public GameObject ingredient2;
    public GameObject ingredient3;

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    public GameObject potion1;
    public GameObject potion2;
    public GameObject potion3;
    public GameObject potion4;

    public Transform potionSpawn;
    public Transform redCube;
    public Transform blueCube;
    public Transform yellowCube;

    public GameObject particlePrefab;
    private GameObject currentParticles;
    public float playDuration = 2.0f; //this is where you can change how long the particle system plays for (measured in seconds)

    public static bool potionSpawned = false;
    public static bool ClearOrder = false;

    public Text HUD;

    private void Start()
    {
        cube1 = GameObject.FindWithTag("red");
        cube2 = GameObject.FindWithTag("yellow");
        cube3 = GameObject.FindWithTag("blue");
    }
    private void Update()
    {
        if (Mixing.Mixed && !potionSpawned)
        {
            potionSpawned = true;
            cube1 = GameObject.FindWithTag("red");
            cube2 = GameObject.FindWithTag("yellow");
            cube3 = GameObject.FindWithTag("blue");
            StartParticleSystem();
            respawnGame();
        }
    }

    private void respawnGame()
    {
        destroyandCreate();
        CheckColors();
        resetIngredientsScript();
        resetMixingScript();
    }

    private void destroyandCreate()
    {
        Destroy(cube1);
        Destroy(cube2);
        Destroy(cube3);
        Instantiate(ingredient1, redCube.position, redCube.rotation);
        Instantiate(ingredient2, blueCube.position, blueCube.rotation);
        Instantiate(ingredient3, yellowCube.position, yellowCube.rotation);
    }

    public void resetIngredientsScript()
    {
        /* Ingredients.colorA = "";
         Ingredients.colorB = "";*/
        Ingredients.ingredients = false;
        //HUD.text = "Ingredients bool reset" + Ingredients.ingredients; 
        Ingredients.colorA = null;
        Ingredients.colorB = null;
    }
    public void resetMixingScript()
    {
        Mixing.Count = 0;
        //HUD.text = Mixing.Count.ToString();
        Mixing.Mixed = false;
        ClearOrder = true;
    }
    private void CheckColors()
    {
        string combination = Ingredients.colorA + "_" + Ingredients.colorB;
        //HUD.text = combination;

        switch (combination)
        {
            case "red_yellow":
                Instantiate(potion1, potionSpawn.position, potionSpawn.rotation);
               // potionSpawned = false;
                //HUD.text = "Red_Yellow = orange";
                break;
            case "yellow_red":
                Instantiate(potion1, potionSpawn.position, potionSpawn.rotation);
                // potionSpawned = false;
                //HUD.text = "Red_Yellow = orange";
                break;
            case "red_blue":
                Instantiate(potion2, potionSpawn.position, potionSpawn.rotation);
               // potionSpawned = false;
               // HUD.text = "Red_Blue = purple";
                break;
            case "blue_red":
                Instantiate(potion2, potionSpawn.position, potionSpawn.rotation);
                // potionSpawned = false;
                //HUD.text = "Red_Yellow = orange";
                break;
            case "yellow_blue":
                Instantiate(potion3, potionSpawn.position, potionSpawn.rotation);
                //potionSpawned = false;
               //HUD.text = "Yellow_Blue = green";
                break;
            case "blue_yellow":
                Instantiate(potion3, potionSpawn.position, potionSpawn.rotation);
                // potionSpawned = false;
                //HUD.text = "Red_Yellow = orange";
                break;
            default:
                Instantiate(potion4, potionSpawn.position, potionSpawn.rotation);
               // gameObject.GetComponent<PlayerHealth>().TakeDamage(5f);
                //DealDamage();
                PlayerHealth.CurrentHealth -= 5;
                break;
        }
        
    }

    public void DealDamage()
    {
       
    }
    public void StartParticleSystem()
    {
        // Instantiate the prefab and set its position
        currentParticles = Instantiate(particlePrefab, potionSpawn.position, Quaternion.identity);
        // Start the particle system
        currentParticles.GetComponent<ParticleSystem>().Play();
        // Start a coroutine to stop and destroy the particles after playDuration seconds
        StartCoroutine(StopAndDestroyParticles());
    }

    // Coroutine to stop particle system after playDuration and destroy it
    private IEnumerator StopAndDestroyParticles()
    {
        yield return new WaitForSeconds(playDuration);

        if (currentParticles != null)
        {
            // Stop the particle system
            currentParticles.GetComponent<ParticleSystem>().Stop();
            // Destroy the instantiated particles after stopping
            Destroy(currentParticles, 1.0f); // Optional delay before destroying
        }
    }
}
