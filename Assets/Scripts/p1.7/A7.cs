using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A7 : MonoBehaviour
{
    void Start()
    {
        Func1(7.6f, 5.3f);
        Func2(1, 1, 1);
        Func3(3, "3", 2);
        Func4(101);
    }

    void Func1(float a, float b)
    {
        if(a > b)
        {
            Debug.Log(a);
        }
        else
        {
            Debug.Log(b);
        }
    }

    void Func2(int a, int b, int c)
    {
        int x, y;
        if(a > b)
        {
            x = a;
            y = b;
        }
        else
        {
            x = b;
            y = a;
        }

        if(x > c)
        {
            x = c;
            if(y > c)
            {
                x = y;
            }
        }

        Debug.Log(x);
    }

    void Func3(int a, string b, int c)
    {
        if(b == "+")
        {
            Debug.Log(a + c);
        }
        else if(b == "-")
        {
            Debug.Log(a - c);
        }
        else if(b == "*")
        {
            Debug.Log(a * c);
        }
        else if(b == "/")
        {
            Debug.Log(a / c);
        }
        else
        {
            Debug.Log("ERROR!");
        }
    }

    void Func4(int score)
    {
        if(score > 100 || score < 0)
        {
            Debug.Log("成绩有误");
        }
        else
        {
            switch(score / 10)
            {
                case 10: Debug.Log("优秀"); break;
                case 9: Debug.Log("优秀"); break;
                case 8: Debug.Log("良好"); break;
                case 7: Debug.Log("一般"); break;
                case 6: Debug.Log("及格"); break;
                default: Debug.Log("不及格"); break;
            }
        }
    }
}
