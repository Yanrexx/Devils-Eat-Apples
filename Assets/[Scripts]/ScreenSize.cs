// Yan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Last boolean is for fullscreen
        Screen.SetResolution(900, 700, true);
    }
}
