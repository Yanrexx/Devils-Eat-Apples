// Yan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
