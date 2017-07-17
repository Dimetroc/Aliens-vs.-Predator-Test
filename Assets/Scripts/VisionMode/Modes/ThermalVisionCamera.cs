using UnityEngine;

public class ThermalVisionCamera : VisionCamera {

    protected override VisionModes VisionMode
    {
        get { return VisionModes.Thermal; }
    }

    protected override void Init()
    {
        base.Init();
        SwitchCameraOff();
    }
}
