using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class A6 : MonoBehaviour
{
    void Start()
    {
        //Fun1();
        //Fun2( 2.12f, 3.25f );
        //Fun3( 100 );
        Debug.Log( Fun4(1, 4)) ;
    }

    public void Fun1()
    {
        int i = 1;
    	++i;
        Debug.LogFormat("i = {0}", i++); //output: i = 2
        int j = 1;
        j++;
        Debug. LogFormat ("j = {0}", ++j); //output: j = 3
    }

    public void Fun2(float a, float b)
    {  
        Debug.LogFormat( "a + b = {0}", a + b );
        Debug.LogFormat( "a - b = {0}", a - b );
        Debug.LogFormat( "a * b = {0}", a * b );
        Debug.LogFormat( "a / b = {0}", a / b );
    }

    public void Fun3(float dollar)
    {
        Debug.Log(dollar * 1.05);
    }

    public string Fun4(int a,int b)
    {
		string result = "";

        float x = (float)a / (float)b * 100;
        result = Math.Round(x, 2) + "%";
		
        return result;
    }
}