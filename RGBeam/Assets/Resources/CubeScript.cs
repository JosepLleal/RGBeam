using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public bool LaserHit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(LaserHit == true)
        {
            if(gameObject.transform.childCount > 0)
                gameObject.transform.GetChild(0).gameObject.SetActive(true);

            LaserHit = false;
        }
        else
        {
            if (gameObject.transform.childCount > 0)
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
