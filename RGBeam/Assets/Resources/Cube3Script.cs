using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3Script : MonoBehaviour
{

    public bool LaserHit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   void Update()
    {
        if(LaserHit == true)
        {
            if(gameObject.transform.childCount > 2)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
            }
                

            LaserHit = false;
        }
        else
        {
            if(gameObject.transform.childCount > 2)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
            }
        }
    }
}
