using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 5;

        a <<= 3;//乘以2的3次方，而不是3的3次方
        Debug.Log(a);
    }

}
