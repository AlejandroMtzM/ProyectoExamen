using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomObserverEventHandler : DefaultObserverEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Debug.Log(" FOUND!  ");
        //Debug.Log($"< color = green > "+ " FOUND!  " + "</ b ></ color >");
    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Debug.Log(" LOST! ");
        //Debug.Log($"< color = red >< b > LOST </ b ></ color >");
    }
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
