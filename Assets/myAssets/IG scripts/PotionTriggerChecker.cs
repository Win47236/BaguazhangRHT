using UnityEngine;
using UnityEngine.UI;

public class PotionTriggerChecker : MonoBehaviour
{
    // Public variables to assign triggers in the inspector
    public Collider expectedTrigger1;
    public Collider expectedTrigger2;
    public Collider expectedTrigger3;

    // Potion tags to check for
    private string correctPotion1 = "Potion3";
    private string correctPotion2 = "Potion1";
    private string correctPotion3 = "Potion4";

    // Internal state
    private bool potion1Correct = false;
    private bool potion2Correct = false;
    private bool potion3Correct = false;

    public Text HUD;

    private void Update()
    {
        CheckWinCondition();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check each trigger against the colliders and set flags
        if (other == expectedTrigger1 && other.CompareTag(correctPotion1))
        {
            potion1Correct = true;
        }
        else if (other == expectedTrigger2 && other.CompareTag(correctPotion2))
        {
            potion2Correct = true;
        }
        else if (other == expectedTrigger3 && other.CompareTag(correctPotion3))
        {
            potion3Correct = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Unset flags when potions exit their respective trigger areas
        if (other == expectedTrigger1 && other.CompareTag(correctPotion1))
        {
            potion1Correct = false;
        }
        else if (other == expectedTrigger2 && other.CompareTag(correctPotion2))
        {
            potion2Correct = false;
        }
        else if (other == expectedTrigger3 && other.CompareTag(correctPotion3))
        {
            potion3Correct = false;
        }
    }

    private void CheckWinCondition()
    {
        // Check if all conditions are met
        if (potion1Correct && potion2Correct && potion3Correct)
        {
            HUD.text = "You Win!";
        }
    }
}
