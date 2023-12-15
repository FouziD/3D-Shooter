using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;

    private RaycastHit hit;
    private Ray ray;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("NPC"))
                {

                    Debug.Log("you are dead");
                    Destroy(hit.collider.gameObject);
                  
                }
            }
        }
        
    }
}
