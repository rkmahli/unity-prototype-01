using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotionConstants
{

    public static float COMPLETE_TURN_ANGLE = 360F;
    public static float HALF_TURN_ANGLE = 180F;

    public static float WALKING_SPEED = 0.1F;
    public static float RUNNING_SPEED = 0.3F;
    public static float MOUSE_SENSITIVITY = 10F;

    public static float MAX_LOOK_UP_ANGLE = 40F;
    public static float MIN_LOOK_DOWN_ANGLE = 60F;

    public static float MAX_LOOK_UP_CAMERA_ANGLE = COMPLETE_TURN_ANGLE - MAX_LOOK_UP_ANGLE;
    public static float MIN_LOOK_DOWN_CAMERA_ANGLE = MIN_LOOK_DOWN_ANGLE;


}
