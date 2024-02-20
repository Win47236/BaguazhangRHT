using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public static float CurrentHealth;
    public float maxHealth = 10;
    [SerializeField] private Slider healthSlider;
    public Text HUD;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = maxHealth;
        healthSlider.minValue = 0;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = CurrentHealth;
        //HUD.text = "Health set";
       // InvokeRepeating("DamageTest", 1.0f, 1.0f);
    }
    private void Update()
    {
        if (CurrentHealth <= 0)
        {
            Died();
        }
       // HUD.text = "Your health" + CurrentHealth.ToString();
        healthSlider.value = CurrentHealth;
    }
    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        healthSlider.value = CurrentHealth;
    }
    private void Died()
    {
        //something goes here
        HUD.text = "You Died. Try again";
    }

 /*   public void Health(float health)
    {
        CurrentHealth += health;
        healthSlider.value = CurrentHealth;
    }

    private void DamageTest()
    {
        CurrentHealth -= 1;
        healthSlider.value = CurrentHealth;
        HUD.text = CurrentHealth.ToString();
    }*/
}

