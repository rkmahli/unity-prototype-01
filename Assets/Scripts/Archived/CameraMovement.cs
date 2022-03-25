using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

        transform.Rotate(-Input.GetAxis("Mouse Y")*10, 0, 0);
        transform.Rotate(0, Input.GetAxis("Mouse X")*10, 0);

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(2.0f, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-2.0f, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -2.0f, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 2.0f, 0);
        }

        transform.Rotate(0, 0, -transform.rotation.eulerAngles.z);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 0.1f);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * 0.1f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.down * 0.1f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.1f);
        }


    }
}
