using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int [, ,] arr = new int [2, 3, 4]
        {
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            },
            {
                {13, 14, 15, 16},
                {17, 18, 19, 20},
                {21, 22, 23, 24}
            }
        };

        Debug.Log("arr[0, 0, 0]: " + arr[0, 0, 0]);
        Debug.Log("arr[1, 1, 1]: " + arr[1, 1, 1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
