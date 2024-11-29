using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int [ , , ] arr = new int[2, 3, 4];
        for( int x = 0; x < 2; x++ )
        {
            for( int y = 0; y < 3; y++ )
            {
                for( int z = 0; z < 4; z++ )
                {
                    arr[x, y, z] = x + y + z;
                }
            }
        }

        Debug.Log(arr[0, 1, 2]); // Output: 3
        Debug.Log(arr[1, 2, 3]); // Output: 6

        arr[1, 2, 3] = 100;
        Debug.Log(arr[1, 2, 3]); // Output: 100
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
