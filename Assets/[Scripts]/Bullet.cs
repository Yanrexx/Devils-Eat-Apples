// Yan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string target;
    public float longevity = 500;

    private void Update()
    {
        if (longevity <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            longevity -= 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (target != collision.gameObject.name)
        {
            Destroy(collision.gameObject);
        }
    }
}
