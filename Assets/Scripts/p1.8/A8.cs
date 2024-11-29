using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A8 : MonoBehaviour
{
    void Start()
    {
        Func1(1, 11);
    }

    void Func1(float month, float day)
    {
        string horo = "ERROR!";

        if(month < 1 || month > 12 || day < 1 || day > 31)
        {
            Debug.Log("输入有误");
        }

        else
        {
            switch(month)
            {
                case 1:
                    if(day <= 19)
                        horo = "摩羯座";
                    else
                        horo = "水瓶座"; break;

                case 2:
                    if(day <= 18)
                        horo = "水瓶座";
                    else
                        horo = "双鱼座"; break;

                case 3:
                    if(day <= 20)
                        horo = "双鱼座";
                    else
                        horo = "白羊座"; break;

                case 4:
                    if(day <= 19)
                        horo = "白羊座";
                    else
                        horo = "金牛座"; break;

                case 5:
                    if(day <= 20)
                        horo = "金牛座";
                    else
                        horo = "双子座"; break;

                case 6:
                    if(day <= 21)
                        horo = "双子座";
                    else
                        horo = "巨蟹座"; break;

                case 7:
                    if(day <= 22)
                        horo = "巨蟹座";
                    else
                        horo = "狮子座"; break;

                case 8:
                    if(day <= 22)
                        horo = "狮子座";
                    else
                        horo = "处女座"; break;

                case 9:
                    if(day <= 22)
                        horo = "处女座";
                    else
                        horo = "天秤座"; break;

                case 10:
                    if(day <= 23)
                        horo = "天秤座";
                    else
                        horo = "天蝎座"; break;

                case 11:
                    if(day <= 22)
                        horo = "天蝎座";
                    else
                        horo = "射手座"; break;

                case 12:
                    if(day <= 21)
                        horo = "射手座";
                    else
                        horo = "摩羯座"; break;
            }

            Debug.Log(horo);
        }
    }
}
