// Yan
using System.Collections;
using System.Collections.Generic;
using Mono.CompilerServices.SymbolWriter;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        float x = target.position.x / 2;

        transform.position = new Vector3(x + offset.x, 
            target.position.y + offset.y, 
            -10);
    }
}
