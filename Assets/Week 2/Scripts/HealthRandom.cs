using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRandom : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Slider slider;
    public int maxHealth = 100;
    public int minHealth = 0;
    //----------------------Edit above here --------------------
    public void Awake()
    {
        slider.value = maxHealth;
    }

    // On Click function
    public void OnClick()
    {
        RandomHealth();
    }

    //----------------------Edit below here --------------------
    public void RandomHealth()
    {
        int random = Random.Range(minHealth, maxHealth);
        slider.value = random;
    }
}
