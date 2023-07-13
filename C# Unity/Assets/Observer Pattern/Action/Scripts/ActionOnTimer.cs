/* This code is made by SURYAVIJAY D, a XR Dev from Chennai, TN, India

~~~~~~~~~C# Actions~~~~~~~~~


*/


using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ActionOnTimer : MonoBehaviour
{
    private Action timerCallBack; 

    public float timer;


    public void SetTimer(float timer, Action timerCallBack)
    {
        this.timer = timer;
        this.timerCallBack = timerCallBack;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (IsTimerComplete())
            {
                Debug.Log(timerCallBack);
                timerCallBack();
            }
        }
    }

    public bool IsTimerComplete()
    {
        return timer <= 0f;
    }
}
