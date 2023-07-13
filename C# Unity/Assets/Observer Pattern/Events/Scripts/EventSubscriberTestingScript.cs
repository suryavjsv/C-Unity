/* This code is made by SURYAVIJAY D, a XR Dev from Chennai, TN, India

~~~~~~~~~C# Events~~~~~~~~~

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventSubscriberTestingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventTestingScript eventTesting = GetComponent<EventTestingScript>();
        eventTesting.OnSpacePressed += EventTesting_OnSpacePressed; //Subscribing Event!

        eventTesting.OnFloatEvent += EventTesting_OnFloatEvent;

        eventTesting.OnActionEvent += EventTesting_OnActionEvent;
    }

    private void EventTesting_OnActionEvent(bool arg1, int arg2)
    {
        Debug.Log(arg2+ " " + arg1);    
    }


    private void EventTesting_OnFloatEvent(float f)
    {
       Debug.Log(f * 5);
       /* EventTestingScript eventTesting = GetComponent<EventTestingScript>();
        eventTesting.OnFloatEvent -= EventTesting_OnFloatEvent;*/
    }

    private void EventTesting_OnSpacePressed(object sender, EventTestingScript.OnSpacePressedEventArgs e)
    {
        Debug.Log("Event Subscribed!!! _ SPACE PRESSED    " + e.spaceCount);
        EventTestingScript eventTesting = GetComponent<EventTestingScript>();
        eventTesting.OnSpacePressed-= EventTesting_OnSpacePressed; //Unsubscribing Event after its done!
    }

    
}
