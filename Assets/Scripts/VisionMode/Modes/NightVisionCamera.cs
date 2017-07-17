using UnityEngine;

public class NightVisionCamera : VisionCamera {

    private const VisionModes VISIONMODE = VisionModes.Night;

    protected override void OnVisionModeChanged(VisionModes newVisionMode)
    {
        base.OnVisionModeChanged(newVisionMode);
        if (newVisionMode == VISIONMODE) Debug.Log("I am is on: " + name);
    }
}
