using UnityEngine;

public class NightVisionCamera : VisionCamera {

    protected override VisionModes VisionMode
    {
        get { return VisionModes.Night; }
    }

    protected override void Init()
    {
        base.Init();
        SwitchCameraOff();
    }
}
