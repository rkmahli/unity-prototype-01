using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps_camera : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(-Input.GetAxis("Mouse Y") * 10, 0, 0);
        
        //transform.Rotate(0, 0, -transform.rotation.eulerAngles.z);
    }
}
