using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps_player : MonoBehaviour
{
    public Transform cameraTrasform;
    void FixedUpdate()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * 10, 0);

        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * 0.1f);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * 0.1f);
        if (Input.GetKey(KeyCode.E)) transform.Translate(Vector3.up * 0.1f);
        if (Input.GetKey(KeyCode.Q)) transform.Translate(Vector3.down * 0.1f);
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * 0.1f);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * 0.1f);
    }
}
