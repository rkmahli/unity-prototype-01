using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps_player : MonoBehaviour
{
    public Transform cameraTrasform;
    void FixedUpdate()
    {
        StandardMouseControls.turnHorizontallyByMouse(transform);
        StandardKeyboardControls.walkAndSprintWSAD(transform);
    }

}
