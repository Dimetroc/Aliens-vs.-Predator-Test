using UnityEngine;

public class VisionModeUI : MonoBehaviour {

    void Awake()
    {
        SignUpForVisionModeSwitch();
        SwitchOff();
    }

    private void SignUpForVisionModeSwitch()
    {
        //There are has to be a VisionModeSwitcher component in the scene
        var modeSwitcher = FindObjectOfType<VisionModeSwitcher>();
        modeSwitcher.VisionModeChanged += OnVisionModeChanged;
    }

    private void OnVisionModeChanged(VisionModes newVisionMode)
    {
        if (newVisionMode == VisionModes.Combined)
        {
            SwitchOn();
        }
        else
        {
            SwitchOff();
        }
    }

    private void SwitchOff()
    {
       gameObject.SetActive(false);
    }

    private void SwitchOn()
    {
        gameObject.SetActive(true);
    }
}
