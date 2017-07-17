using UnityEngine;

public class NormalVisionCamera : VisionCamera {

    private const VisionModes VISIONMODE = VisionModes.Normal;

    protected override void OnVisionModeChanged(VisionModes newVisionMode)
    {
        base.OnVisionModeChanged(newVisionMode);
        if (newVisionMode == VISIONMODE) Debug.Log("I am is on: " + name);
    }
}
