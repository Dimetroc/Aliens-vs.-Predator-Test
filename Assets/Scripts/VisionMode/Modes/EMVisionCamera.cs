using UnityEngine;

public class EMVisionCamera : VisionCamera {

    private const VisionModes VISIONMODE = VisionModes.EM;

    protected override void OnVisionModeChanged(VisionModes newVisionMode)
    {
        base.OnVisionModeChanged(newVisionMode);
        if (newVisionMode == VISIONMODE) Debug.Log("I am is on: " + name);
    }
}
