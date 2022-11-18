using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class MyHandTouchHandler : MonoBehaviour, IMixedRealityTouchHandler
{
    #region Event handlers
    public TouchEvent OnTouchCompleted;
    public TouchEvent OnTouchStarted;
    public TouchEvent OnTouchUpdated;
    #endregion

    [SerializeField]
    private float rotateSpeed = 300.0f;


    void IMixedRealityTouchHandler.OnTouchCompleted(HandTrackingInputEventData eventData)
    {
        OnTouchCompleted.Invoke(eventData);

        Debug.Log( "OnTouchCompleted");

        
    }

    void IMixedRealityTouchHandler.OnTouchStarted(HandTrackingInputEventData eventData)
    {
        OnTouchStarted.Invoke(eventData);

        Debug.Log("OnTouchStarted");


       
    }

    void IMixedRealityTouchHandler.OnTouchUpdated(HandTrackingInputEventData eventData)
    {        
        
        OnTouchUpdated.Invoke(eventData);
        Debug.Log("OnTouchUpdated");

        //Vector3.up --> Shorthand for writing Vector3(0, 1, 0).
        this.transform.Rotate(Vector3.up * (rotateSpeed * Time.deltaTime));
            
    }

}