/* This code is made by SURYAVIJAY D, a XR Dev from Chennai, TN, India

~~~~~~~~~C# DELEGATES~~~~~~~~~

> C# Delegates store a function in a variable
        - Action
        - Func
        - Delegate
        - Lambda
> Delegates is a essential feature in unity C# - Which can assign a function inside a field 
> Its a extremely powerful concept which can be used in scenerios

*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSSimpleDelegates : MonoBehaviour
{
    /*
        You may wonder what is byte keyword passing as arg
        > byte - 8 Bit unsigned integer
        > Range from 0 to 255
    */
    public delegate void TestOneDelegate(byte x); // SYNTAX : declaring simple delegate with arugument without event
    private TestOneDelegate testOneDelegateFunction;


    public delegate bool TestTwoDelegate(int a);
    private TestTwoDelegate testTwoDelegateFunction;

    public delegate void TestThreeDelegate();
    private TestThreeDelegate testThreeDelegateFunction;
    // Start is called before the first frame update
    void Start()
    {
        // Field                      //Function
        testOneDelegateFunction = FunctionForTest1Delegate;
        testOneDelegateFunction += FunctionForTest2Delegate;
        testOneDelegateFunction(20);

        /*
            It is same which works like
            int a;
            a = 1;
            a += 2;
        
            OP will be | a = 3
            we can assign a function inside a field 
        */


        //Another way of using Delegates with arg         
        testTwoDelegateFunction = (int x) => { return x % 2 == 0; };
        Debug.Log(testTwoDelegateFunction(4)); //OP is True

        //Simple way of using delegates without arg
        testThreeDelegateFunction = () => { Debug.Log("Hi There I'm a 3rd delegate"); } ;
        testThreeDelegateFunction(); //OP is Hi There I'm a 3rd delegate
    }

    void FunctionForTest1Delegate(byte x)
    {
        x *= 2;
        Debug.Log(x);
    }

    void FunctionForTest2Delegate(byte x)
    {
        x += 5;
        Debug.Log(x);
    }


}
