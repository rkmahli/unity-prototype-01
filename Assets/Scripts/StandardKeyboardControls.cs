using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardKeyboardControls
{


    public static void walkWSAD(Transform transform)
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * PlayerKineticConstants.WALKING_SPEED);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * PlayerKineticConstants.WALKING_SPEED);
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * PlayerKineticConstants.WALKING_SPEED);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * PlayerKineticConstants.WALKING_SPEED);
    }

    public static void walkAndSprintWSAD(Transform transform)
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)) transform.Translate(Vector3.forward * PlayerKineticConstants.RUNNING_SPEED);
        else if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * PlayerKineticConstants.WALKING_SPEED);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * PlayerKineticConstants.WALKING_SPEED);
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * PlayerKineticConstants.WALKING_SPEED);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * PlayerKineticConstants.WALKING_SPEED);
    }
}
