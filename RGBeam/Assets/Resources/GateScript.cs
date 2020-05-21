using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{

    public bool LaserHit = false;
    public bool Win = false;
    public float win_time = 3.0f;

    float time = 0.0f;

    public Material[] material;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(time);
        if(LaserHit == true)
        {
            time += Time.deltaTime;
            rend.sharedMaterial = material[1];

            if (time >= win_time)
                Win = true;

            LaserHit = false;
        }
        else
        {
            time = 0;
            Win = false;
            rend.sharedMaterial = material[0];
        }
    }
}
