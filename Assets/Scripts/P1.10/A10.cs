using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A10 : MonoBehaviour
{
    void Start()
    {
        //Func1();
        //Func2();
        //Func3();
        //Func4();
        Func5();
    }

    void Func1()
    {
        for(int i=1; i<=100; i++)
        {
            if(i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    void Func2()
    {
        int a = 0;
        int b = 0;
        for(int i=1; i<=1000; i++)
        {
            if(i % 7 == 0)
            {
                a += i;
                b++;

                if(b == 5)
                {
                    Debug.Log(a);
                    a = 0;
                    b = 0;
                }
            }
        }
    }

    void Func3()
    {
        int a = 0;
        for(int i=1; i<=100; i++)
        {
            if(i % 3 == 0 && i % 5 != 0)
            {
                a++;
            }
        }
        Debug.Log(a);
    }

    void Func4()
    {
        for(int i=2; i<=1000; i++)
        {
            if(isPrime(i))
            {
                Debug.Log(i);
            }
        }
    }
    bool isPrime(int a)
    {
        for(int i=2; i<a; i++)
        {
            if(a % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    void Func5()
    {
        string table = "";
        for(int x=1; x<=9; x++)
        {
            for(int y=1; y<=x; y++)
            {
                table += y+ "*"+ x+ "="+ y*x + "  ";
            }
            table += "\r\n";
        }
        Debug.Log(table);
    }
}
