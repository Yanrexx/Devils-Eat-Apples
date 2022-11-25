// Yan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourBasic : MonoBehaviour
{
    public string target;
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3 (0, Time.deltaTime * -speed, 0);
    }
}
