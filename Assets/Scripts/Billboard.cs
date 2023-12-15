using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform cam;

   
    void Lateupdate()
    {
        transform.LookAt(transform.position + cam.position);
    }
}
