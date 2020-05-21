using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinished : MonoBehaviour
{
    public GameObject[] gates;
    public GameObject canvas;

    private float timer = 0.0f;

    bool completed = false;
    bool next_lvl = false;

    // Start is called before the first frame update
    void Start()
    {
        //canvas = GameObject.Find("Canvas"); 
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject gate in gates)
        {
            if (gate.GetComponent<GateScript>())
            {
                if (gate.GetComponent<GateScript>().Win == true)
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
            next_lvl = true;
        }

        if (next_lvl == true)
        {
            timer += Time.deltaTime;
            canvas.SetActive(true);

            if (timer >= 3.0f)
            {     
                gameObject.SetActive(false);
                canvas.SetActive(false);
                Time.timeScale = 0; 
            }
        }
    }
}
