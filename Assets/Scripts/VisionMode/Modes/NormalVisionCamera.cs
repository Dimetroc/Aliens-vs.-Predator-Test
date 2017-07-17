using UnityEngine;

public class NormalVisionCamera : VisionCamera {

    protected override VisionModes VisionMode
    {
        get { return VisionModes.Normal; }
    }

    protected override void OnVisionModeChanged(VisionModes newVisionMode)
    {
        if (newVisionMode == VisionModes.Combined || newVisionMode == VisionMode)
        {
            SwitchCameraOn();
        }
        else
        {
            SwitchCameraOff();
        }
    }
}
