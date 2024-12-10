using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gobelin : MonoBehaviour
{
    public float health = 10;
    public float maxHealth = 10;
    public TMP_Text healthText;
    public Slider slider;

    private void Update()
    {
        healthText.text = $"Gobelin Health : {health}";
        slider.value = health / maxHealth;

    }

    public void DisplayValue()
    {
        Debug.Log(slider.value);
    }
}
