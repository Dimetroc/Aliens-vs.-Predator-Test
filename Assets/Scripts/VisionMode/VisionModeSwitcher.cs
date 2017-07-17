using System;
using UnityEngine;

/// <summary>
/// Script responsible for handling input to switch vision modes
/// </summary>
public class VisionModeSwitcher : MonoBehaviour
{
    public event Action<VisionModes> VisionModeChanged;

	void Update ()
    {
		ProcessInput();
	}

    //TODO Switch to buttons to allow switching key bindings
    
    private void ProcessInput()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            RaiseVisionModeChanged(VisionModes.Normal);
        }
        else if(Input.GetKeyUp(KeyCode.Alpha2))
        {
            RaiseVisionModeChanged(VisionModes.Thermal);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            RaiseVisionModeChanged(VisionModes.Night);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            RaiseVisionModeChanged(VisionModes.EM);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            RaiseVisionModeChanged(VisionModes.Combined);
        }
    }

    private void RaiseVisionModeChanged(VisionModes NewVisionMode)
    {
        if(VisionModeChanged == null) return;
        VisionModeChanged(NewVisionMode);
    }
}
