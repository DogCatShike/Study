using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A9 : MonoBehaviour
{
    void Start()
    {
        Week week = Week.Friday;
        Func1(week);

        Func2();
    }

    enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    void Func1(Week week)
    {
        switch(week)
        {
            case Week.Monday: Debug.Log("周一做的事"); break;
            case Week.Tuesday: Debug.Log("周二做的事"); break;
            case Week.Wednesday: Debug.Log("周三做的事"); break;
            case Week.Thursday: Debug.Log("周四做的事"); break;
            case Week.Friday: Debug.Log("周五做的事"); break;
            case Week.Saturday: Debug.Log("周六做的事"); break;
            case Week.Sunday: Debug.Log("周天做的事"); break;
        }
    }

    enum PrimitiveType
    {
        Cube = 1,
        Capsule = 2,
        Cylinder = 3,
        Plane = 4,
        Quad = 5
    }
    void Func2()
    {
        Debug.LogFormat("{0} = {1}", PrimitiveType.Cube.ToString(), (int)PrimitiveType.Cube);
        Debug.LogFormat("{0} = {1}", PrimitiveType.Capsule.ToString(), (int)PrimitiveType.Capsule);
        Debug.LogFormat("{0} = {1}", PrimitiveType.Cylinder.ToString(), (int)PrimitiveType.Cylinder);
        Debug.LogFormat("{0} = {1}", PrimitiveType.Plane.ToString(), (int)PrimitiveType.Plane);
        Debug.LogFormat("{0} = {1}", PrimitiveType.Quad.ToString(), (int)PrimitiveType.Quad);
    }
}
