using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps_camera : MonoBehaviour
{
    void FixedUpdate()
    {
        StandardMouseControls.turnVerticallyByMouse(transform);
        StandardMouseControls.restrictVerticalMouseMovement(transform);
        StandardMouseControls.nullifyZAxisRotation(transform);
    }

}
