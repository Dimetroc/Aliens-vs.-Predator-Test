using UnityEngine;

/// <summary>
/// Base class for various vision modes cameras
/// </summary>
public class VisionCamera : MonoBehaviour {

	void Awake ()
	{
	    var modeSwitcher = FindObjectOfType<VisionModeSwitcher>();
	    if (modeSwitcher == null)
	    {
	        Debug.LogError("Vision mode switcher is not found in the scene!");
            return;
	    }
	    modeSwitcher.VisionModeChanged += OnVisionModeChanged;
	}

    protected virtual void OnVisionModeChanged(VisionModes newVisionMode)
    {
        
    }
}
