// Yan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerBehaviour : MonoBehaviour
{
    public float speedX;
    public float speedY;
    public float boundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speedX;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speedY;

        if (x + transform.position.x > boundary)
        {
            transform.position += new Vector3(0, y, 0.0f);
        }
        else if (x + transform.position.x < -boundary)
        {
            transform.position += new Vector3(0, y, 0.0f);
        }
        else
        {
            transform.position += new Vector3(x, y, 0.0f);
        }
    }
}
