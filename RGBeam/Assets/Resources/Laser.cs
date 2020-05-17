using UnityEngine;
using System.Collections;
public class Laser : MonoBehaviour
{

    private LineRenderer lr;

    private GameObject collision;

    // Use this for initialization
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, hit.point);

                collision = hit.collider.gameObject;

                if (hit.collider.gameObject.GetComponent<CubeScript>())
                    hit.collider.gameObject.GetComponent<CubeScript>().LaserHit = true;

            }
            
        }
        else
        {
            lr.SetPosition(1, transform.forward * 5000);

           
        }
           
    }
}