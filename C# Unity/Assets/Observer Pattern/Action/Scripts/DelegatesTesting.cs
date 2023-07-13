/* This code is made by SURYAVIJAY D, a XR Dev from Chennai, TN, India

~~~~~~~~~C# Actions~~~~~~~~~

*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DelegatesTesting : MonoBehaviour
{
    [SerializeField] ActionOnTimer actionOnTimer;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        //Im gonna call Timer script where it will count the value to 0 in descending order! If its done it will return ActionCall back
        actionOnTimer.SetTimer(10, () =>
        {
            Debug.Log("Timer is complete!");
        });

    }

    //This is for visualization purpose!
    private void Update()
    {
        int a = (int)actionOnTimer.timer;
        if (a == 0)
        {
            textMeshProUGUI.text = "Timer is complete!";
        }
        else
        {
            textMeshProUGUI.text = a.ToString();
        }

    }

}
