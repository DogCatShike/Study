using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A11 : MonoBehaviour
{
    void Start()
    {
        //Func1();
        //Func2();
        //Func3();
        //Func4(7);
        Func5(1, 6);
    }

    void Func1()
    {
        int i = 100;
        int number = 0;
        while(i >= 100 && i <= 999)
        {
            if(isNarcissistic(i))
            {
                number++;
                Debug.Log(i);
            }
            i++;
        }

        Debug.Log("水仙花数总数是：" + number);
    }
    bool isNarcissistic(int x)
    {
        int a = x % 10;
        int b = x % 100 / 10;
        int c = x / 100;
        
        if(a*a*a + b*b*b + c*c*c == x)
        {
            return true;
        }
        return false;
    }

    void Func2()
    {
        int[] x = {3, 8, 98, 65, 753, 66, 11};
        int max = x[0];
        int min = x[0];
        float avg = 0;
        int add = 0;

        foreach(var v in x)
        {
            if(max < v)
                max = v;
            if(min > v)
                min = v;
            avg += v;
            add += v;
        }
        avg /= x.Length;
        Debug.LogFormat("最大值{0}，最小值{1}，平均值{2}，和{3}", max, min, avg, add);
    }

    void Func3()
    {
        for(int a=1; a<=9; a++)
        {
            for(int b=0; b<=9; b++)
            {
                for(int c=1; c<=9; c++)
                {
                    if(a*100 + b*10 + c + c*100 + b*10 + a == 1333)
                        Debug.LogFormat("A: {0}, B: {1}, C: {2}", a, b, c);
                }
            }
        }
    }

    void Func4(int x)
    {
        if(isPrime(x))
            Debug.Log("是质数");
        else
            Debug.Log("不是质数");
    }
    bool isPrime(int x)
    {
        for(int i=2; i<x; i++)
        {
            if(x % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    void Func5(int x, int y)
    {

    }
}
