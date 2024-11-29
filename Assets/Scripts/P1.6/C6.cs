using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C6 : MonoBehaviour
{
    void Start()
    {
        //Debug.Log(Fun1(24));
        //Debug.Log(Fun2(5, 3, 4));
        Fun3(5);
    }

    public int Fun1(int a) 
    { 
        int b = 0; 

        int c = a % 1000;
        b += c / 100;
        c %= 100;
        b += c / 10 * 10;
        c %= 10;
        b += c * 100;

        return b; 
    } 

    public float Fun2(float up,float down,float height) 
    {
        float area;
        area = ( up + down ) * height / 2;
        return area;
    } 

    public void Fun3(float radius) 
    { 
        float length = 2 * radius * Mathf.PI; 
        float area = radius * radius * Mathf.PI; 
        Debug.LogFormat("圆的周长是：{0}，面积是：{1}", length, area); 
    }
}
