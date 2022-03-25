using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool enableJump = true;

    float movementRate = 0.1f;

    public Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //transform.Rotate(new Vector3(0, transform.position.y, 0), Input.GetAxis("Mouse X") * 2);


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementRate);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movementRate);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementRate);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementRate);
        }



        if (Input.GetKey(KeyCode.Space) && enableJump)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        enableJump = true;

    }

    private void OnCollisionStay(Collision collision)
    {

    }

    private void OnCollisionExit(Collision collision)
    {
        enableJump = false;
    }

}
