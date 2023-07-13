/* This code is made by SURYAVIJAY D, a XR Dev from Chennai, TN, India

~~~~~~~~~C# Events~~~~~~~~~

*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class EventTestingScript : MonoBehaviour
{
    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;

    //Creating a custom class for event and deriving eventargs
    public class OnSpacePressedEventArgs : EventArgs
    {
        public int spaceCount;
    }


    //Instead of creating EventHandler which is native C# way..
    public event TestEventDelegate OnFloatEvent;
    public delegate void TestEventDelegate(float f);

    //Like wise we can use action
    public event Action<bool, int> OnActionEvent;

    //like wise Unity is having - UnityEvents
    public UnityEvent OnUnityEvent;

    private int spaceCount;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceCount++;
            OnSpacePressed?.Invoke(this, new OnSpacePressedEventArgs { spaceCount = spaceCount });
            //Here : If SPACE BAR pressed!, Update will execute this event.. This Event doesnt know who subscribed it.

            //Like same we are executing this delegate
            OnFloatEvent?.Invoke(5.5f);

            //Like samer we are Executing this action
            OnActionEvent?.Invoke(true, 10);

            //Like same we are executing this unity event
            OnUnityEvent?.Invoke();
            //In unity itself we dragged a cube and stopping the animation while this unity event triggers
        }
    }
}
