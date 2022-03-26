using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardMouseControls
{
    public static void turnVerticallyByMouse(Transform transform)
    {
        transform.Rotate(-Input.GetAxis("Mouse Y") * PlayerMotionConstants.MOUSE_SENSITIVITY, 0, 0);
    }

    public static void turnHorizontallyByMouse(Transform transform)
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * PlayerMotionConstants.MOUSE_SENSITIVITY, 0);
    }

    public static void nullifyZAxisRotation(Transform transform)
    {
        transform.Rotate(0, 0, -transform.rotation.eulerAngles.z);
    }

    public static void restrictVerticalMouseMovement(Transform transform)
    {
        if (transform.eulerAngles.x > PlayerMotionConstants.MIN_LOOK_DOWN_CAMERA_ANGLE && transform.eulerAngles.x <= PlayerMotionConstants.HALF_TURN_ANGLE)
        {
            transform.eulerAngles = new Vector3(PlayerMotionConstants.MIN_LOOK_DOWN_CAMERA_ANGLE, transform.eulerAngles.y, transform.eulerAngles.z);
        }

        if (transform.eulerAngles.x < PlayerMotionConstants.MAX_LOOK_UP_CAMERA_ANGLE && transform.eulerAngles.x > PlayerMotionConstants.HALF_TURN_ANGLE)
        {
            transform.eulerAngles = new Vector3(PlayerMotionConstants.MAX_LOOK_UP_CAMERA_ANGLE, transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }
}
