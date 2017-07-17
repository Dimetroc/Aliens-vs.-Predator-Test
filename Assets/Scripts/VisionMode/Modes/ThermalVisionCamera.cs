using UnityEngine;

public class ThermalVisionCamera : VisionCamera {

    private const VisionModes VISIONMODE = VisionModes.Thermal;

    protected override void OnVisionModeChanged(VisionModes newVisionMode)
    {
        base.OnVisionModeChanged(newVisionMode);
        if(newVisionMode == VISIONMODE) Debug.Log("I am is on: " + name);
    }
}
