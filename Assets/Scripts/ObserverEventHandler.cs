using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ObserverEventHandler : DefaultObserverEventHandler
{

    public UnityEngine.UI.Image detectionImg;
    [Space]
    
    public Color colorFound;
    public Color colorLost;

    // Start is called before the first frame update
    public void OnVuforiaStarted()
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(
        FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        VuforiaBehaviour.Instance.CameraDevice.SetCameraMode(Vuforia.CameraMode.MODE_DEFAULT);
    }



    public void OnPaused(bool paused)
    {
        if (!paused) // Resumed
        {
            //Set again autofocus mode when app is resumed
           VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(
           FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Debug.Log(" FOUND!  ");
        //Debug.Log("<color=green > <b> FOUND!  </ b ></ color >");
        detectionImg.color = colorFound;
        //Image.color = colorFound;
    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Debug.Log(" LOST! ");
        //Debug.Log("<color=red><b> LOST </b></color>");
        detectionImg.color = colorLost;
        //Image.color = colorLost;
    }
}
