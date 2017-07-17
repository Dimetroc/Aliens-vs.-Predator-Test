using UnityEngine;

/// <summary>
/// Base class for various vision modes cameras
/// </summary>
[RequireComponent(typeof(Camera))]
public class VisionCamera : MonoBehaviour
{
    protected virtual VisionModes VisionMode { get {return VisionModes.Normal;} }

    protected Camera _camera;
    protected RenderTexture _renderTexture;

	void Awake ()
	{
	    SetupCamera();
	    SignUpForVisionModeSwitch();
        Init();
	}

    protected virtual void Init()
    {
        
    }

    private void SetupCamera()
    {
        _camera = GetComponent<Camera>();
        _renderTexture = _camera.targetTexture;
    }

    private void SignUpForVisionModeSwitch()
    {
        //There are has to be a VisionModeSwitcher component in the scene
        var modeSwitcher = FindObjectOfType<VisionModeSwitcher>();
        modeSwitcher.VisionModeChanged += OnVisionModeChanged;
    }

    protected virtual void OnVisionModeChanged(VisionModes newVisionMode)
    {
        if (newVisionMode == VisionModes.Combined)
        {
            SwitchCameraRenderTextureModeOn();
        }
        else if (newVisionMode == VisionMode)
        {
            Debug.Log("I am is on: " + name);
            SwitchCameraOn();
        }
        else
        {
            SwitchCameraOff();
        }
    }

    protected virtual void SwitchCameraOff()
    {
        _camera.targetTexture = null;
        _camera.enabled = false;
    }

    protected virtual void SwitchCameraOn()
    {
        _camera.enabled = true;
    }

    protected virtual void SwitchCameraRenderTextureModeOn()
    {
        _camera.targetTexture = _renderTexture;
        _camera.enabled = true;
    }
}
