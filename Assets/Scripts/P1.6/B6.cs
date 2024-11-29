using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B6 : MonoBehaviour
{
    void Start()
    {
        Fun1(93);
    }

    public void Fun1(int money)
    {
        /*
        int twenty = money / 20;
        int ten = ( money - (twenty * 20) ) / 10;
        int five = ( money - (twenty * 20) - (ten * 10) ) / 5;
        int one = money - (twenty * 20) - (ten * 10) - (five * 5);
        */
        
        int twenty = money / 20;
        money = money % 20;
        int ten = money / 10;
        money = money % 10;
        int five = money / 5;
        money = money % 5;
        int one = money;
        
        Debug.LogFormat("{0}张二十块，{1}张十块，{2}张五块，{3}张一块。", twenty, ten, five, one);
    }
}
