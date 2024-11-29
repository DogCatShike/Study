using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    void Start()
    {
        /*蜗牛问题
        int day;
        for(day = 0; day <= 100; day++) 
        {
            if((3 - 2) * (day - 1) + 3 == 7)
            {
                break;
            }
        }
        Debug.Log("蜗牛需要" + day + "天才能爬出井边");
        */

        /*一块钱吃桃
        int peach = 10;
        int peachPit = 10;

        while(peachPit >= 3)
        {
            peach++;
            peachPit -= 3;
            peachPit += 1;
        }

        Debug.Log("一块钱可以吃" + peach + "个桃子");
        */

        /*
        小赵 > 士兵;        大学生
        小张 > 大学生;      商人
        小王 != 大学生;     士兵
        */

    }
}
