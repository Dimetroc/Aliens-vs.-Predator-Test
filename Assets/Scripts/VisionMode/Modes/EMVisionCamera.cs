using UnityEngine;

public class EMVisionCamera : VisionCamera {

    protected override VisionModes VisionMode
    {
        get { return VisionModes.EM; }
    }

    protected override void Init()
    {
        base.Init();
        SwitchCameraOff();
    }
}
