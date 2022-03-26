using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps_player : MonoBehaviour
{
    public Transform cameraTrasform;

    private bool inCollision = false;
    void FixedUpdate()
    {
        StandardMouseControls.turnHorizontallyByMouse(transform);
        StandardKeyboardControls.walkAndSprintWSAD(transform);

        if (inCollision && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump Force applied");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 200.0f);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        inCollision = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        inCollision = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        inCollision = false;
    }
}
