using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipies : MonoBehaviour
{
 //   public GameObject ingredient1;
   // public GameObject ingredient2;
   // public GameObject ingredient3;

    private GameObject cube1;
    private GameObject cube2;
    private GameObject cube3;

    public GameObject potion1;
    public GameObject potion2;
    public GameObject potion3;
    public GameObject potion4;
    public GameObject potion5;
    public GameObject potion6;
    public GameObject potion7;

    public Transform potionSpawn;
    public Transform redCube;
    public Transform blueCube;
    public Transform yellowCube;

    //public GameObject particlePrefab;
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
            //StartParticleSystem();
            respawnGame();
        }
    }

    private void respawnGame()
    {
        destroyandCreate();
        CheckColors();
        resetIngredientsScript();
        resetMixingScript();

        //step 1: destory the ingredients and recreate them
        //step 2: check to see what ingredients were in the bowl and create potion from there
        //step 3: reset ingredients to allow for next mix
        //step 4: after everything else prep the mortar for a new mix
    }

    private void destroyandCreate()
    {
        Destroy(cube1);
        Destroy(cube2);
        Destroy(cube3);
       // Instantiate(ingredient1, redCube.position, redCube.rotation);
        //Instantiate(ingredient2, blueCube.position, blueCube.rotation);
        //Instantiate(ingredient3, yellowCube.position, yellowCube.rotation);
    }

    public void resetIngredientsScript()
    {
        /* Ingredients.colorA = "";
         Ingredients.colorB = "";*/
        Ingredients.ingredients = false;
        HUD.text = "Ingredients bool reset" + Ingredients.ingredients; 
        Ingredients.colorA = null;
        Ingredients.colorB = null;
        Ingredients.colorC = null;
        Ingredients.colorD = null;
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
      /*  if(Ingredients.twoIsThere)
        {
            //script prepped for expansion w/ two ingredient recipies
            string combination2 = Ingredients.colorA + "_" + Ingredients.colorB;
            Instantiate(potion7, potionSpawn.position, potionSpawn.rotation);

            PlayerHealth.CurrentHealth -= 5;
        }
        if (Ingredients.fourIsThere)
        {
            //script prepped for expansion w/ four ingredient recipies
            string combination4 = Ingredients.colorA + "_" + Ingredients.colorB + "_" + Ingredients.colorC + "_" + Ingredients.colorD;
            Instantiate(potion7, potionSpawn.position, potionSpawn.rotation);

            PlayerHealth.CurrentHealth -= 5;
        } */
        if (Ingredients.threeIsThere)
        {
            string combination3 = Ingredients.colorA + "_" + Ingredients.colorB + "_" + Ingredients.colorC;

            //HUD.text = combination3;

            switch (combination3)
            {
                // Potion 1 combinations
                case "birdFlower_orchidFlower_tulipFlower":
                case "birdFlower_tulipFlower_orchidFlower":
                case "orchidFlower_birdFlower_tulipFlower":
                case "orchidFlower_tulipFlower_birdFlower":
                case "tulipFlower_birdFlower_orchidFlower":
                case "tulipFlower_orchidFlower_birdFlower":
                    Instantiate(potion1, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 2 combinations
                case "birdLeaf_orchidLeaf_tulipLeaf":
                case "birdLeaf_tulipLeaf_orchidLeaf":
                case "orchidLeaf_birdLeaf_tulipLeaf":
                case "orchidLeaf_tulipLeaf_birdLeaf":
                case "tulipLeaf_birdLeaf_orchidLeaf":
                case "tulipLeaf_orchidLeaf_birdLeaf":
                    Instantiate(potion2, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 3 combinations
                case "orchidLeaf_tulipFlower_tulipLeaf":
                case "orchidLeaf_tulipLeaf_tulipFlower":
                case "tulipFlower_orchidLeaf_tulipLeaf":
                case "tulipFlower_tulipLeaf_orchidLeaf":
                case "tulipLeaf_orchidLeaf_tulipFlower":
                case "tulipLeaf_tulipFlower_orchidLeaf":
                    Instantiate(potion3, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 4 combinations
                case "orchidFlower_birdFlower_birdLeaf":
                case "orchidFlower_birdLeaf_birdFlower":
                case "birdFlower_orchidFlower_birdLeaf":
                case "birdFlower_birdLeaf_orchidFlower":
                case "birdLeaf_orchidFlower_birdFlower":
                case "birdLeaf_birdFlower_orchidFlower":
                    Instantiate(potion4, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 5 combinations
                case "tulipLeaf_birdLeaf_birdFlower":
                case "tulipLeaf_birdFlower_birdLeaf":
                case "birdLeaf_tulipLeaf_birdFlower":
                case "birdLeaf_birdFlower_tulipLeaf":
                case "birdFlower_tulipLeaf_birdLeaf":
                case "birdFlower_birdLeaf_tulipLeaf":
                    Instantiate(potion5, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 6 combinations
                case "birdFlower_tulipFlower_birdLeaf":
                case "birdFlower_birdLeaf_tulipFlower":
                case "tulipFlower_birdFlower_birdLeaf":
                case "tulipFlower_birdLeaf_birdFlower":
                case "birdLeaf_birdFlower_tulipFlower":
                case "birdLeaf_tulipFlower_birdFlower":
                    Instantiate(potion6, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 1 combinations
                case "orchidFlower_tulipLeaf_orchidLeaf":
                case "orchidFlower_orchidLeaf_tulipLeaf":
                case "tulipLeaf_orchidFlower_orchidLeaf":
                case "tulipLeaf_orchidLeaf_orchidFlower":
                case "orchidLeaf_orchidFlower_tulipLeaf":
                case "orchidLeaf_tulipLeaf_orchidFlower":
                    Instantiate(potion1, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 3 combinations
                case "birdFlower_birdLeaf_orchidLeaf":
                case "birdFlower_orchidLeaf_birdLeaf":
                case "birdLeaf_birdFlower_orchidLeaf":
                case "birdLeaf_orchidLeaf_birdFlower":
                case "orchidLeaf_birdFlower_birdLeaf":
                case "orchidLeaf_birdLeaf_birdFlower":
                    Instantiate(potion6, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 4 combinations
                case "tulipLeaf_tulipFlower_orchidFlower":
                case "tulipLeaf_orchidFlower_tulipFlower":
                case "tulipFlower_tulipLeaf_orchidFlower":
                case "tulipFlower_orchidFlower_tulipLeaf":
                case "orchidFlower_tulipLeaf_tulipFlower":
                case "orchidFlower_tulipFlower_tulipLeaf":
                    Instantiate(potion4, potionSpawn.position, potionSpawn.rotation);
                    break;

                // Potion 5 combinations
                case "orchidLeaf_birdFlower_tulipLeaf":
                case "orchidLeaf_tulipLeaf_birdFlower":
                case "birdFlower_orchidLeaf_tulipLeaf":
                case "birdFlower_tulipLeaf_orchidLeaf":
                case "tulipLeaf_orchidLeaf_birdFlower":
                case "tulipLeaf_birdFlower_orchidLeaf":
                    Instantiate(potion6, potionSpawn.position, potionSpawn.rotation);
                    break;

                default:
                    Instantiate(potion7, potionSpawn.position, potionSpawn.rotation);

                    PlayerHealth.CurrentHealth -= 5;
                    break;
            }
        }
    }

    /*public void StartParticleSystem()
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
    } */
}
