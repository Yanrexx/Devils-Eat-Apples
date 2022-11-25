using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public Image healthBar;
    public float healthAmount = 100f;


    void Start()
    {
        
    }


    void Update()
    {
        if(healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.Return)) // For testing Damage
        {
            TakeDamage(34);
        }

     
    }


    void OnCollisionEnter2D(Collision2D obj) // For collision damage
    {
        if (obj.gameObject.tag == "Enemy")
        healthAmount = healthAmount - 34f;

    }


    public void TakeDamage(float damage) // For testing taking damage (I can't really tell if the health bar is working since I have no enemies here)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

  

}
