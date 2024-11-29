using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B7 : MonoBehaviour
{
    void Start()
    {
        Func1(13.5f, 8.1f);
    }

    void Func1(float km, float time)
    {
        float cost = 0;
        float a;
        
        if(km < 0 || time < 0)
        {
            Debug.Log("数据错误");
        }

        else
        {
            if(km <= 3)
            {
                cost += 10;
            }
            else if(km > 3 && km <= 13)
            {
                a = km - 3;
                cost = cost + 10 + a * 2;
            }
            else
            {
                a = km - 13;
                cost = cost + 30 + a * 3;
            }
        }
        cost += time / 5 * 2;

        int x = (int)cost;
        if(cost - x >= 0.5)
        {
            x++;
        }

        Debug.Log("cost = " + x);
    }
}
