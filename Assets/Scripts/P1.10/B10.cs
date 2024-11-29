using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B10 : MonoBehaviour
{
    void Start()
    {
        //Func1();
        Func2();
    }

    void Func1()
    {
        for(int g=0; g<=20; g++)
        {
            for(int m=0; m<=33; m++)
            {
                int c = 100-g-m;
                if(g*15 + m*9 + c == 300)
                {
                    Debug.LogFormat("公鸡:{0} 母鸡:{1} 鸡雏:{2}", g, m, c);
                }
            }
        }
    }

    void Func2()
    {
        int peach = 1;
        for(int i=10; i>=1; i--)
        {
            peach = (peach+1) * 2;
        }
        Debug.Log(peach);
    }
}
