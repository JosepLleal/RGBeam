using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject[] gates;
    public GameObject NextLevel;

    bool completed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject gate in gates)
        {
            if (gate.GetComponent<GateScript>())
            {
                if(gate.GetComponent<GateScript>().Win == true)
                {
                    completed = true;
                }  
                else
                {
                    completed = false;
                    break;
                }
            }
        }

        if (completed == true)
        {
            NextLevel.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}
