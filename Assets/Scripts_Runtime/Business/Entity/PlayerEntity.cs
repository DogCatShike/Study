using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    public int id;
    public int typeID;
    public Vector2 moveAxis;
    public float speed;
    public int volume;
    public int number = 0;

    public void Move(float dt)
    {
        //设置每帧moveAxis归零，防止不按键后持续移动
        Vector2 moveAxis = Vector2.zero;
        //实例化（不知道有啥用）
        moveAxis.Normalize();

        if(Input.GetKey(KeyCode.W))
        {
            moveAxis.y = 1;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            moveAxis.y = -1;
        }

        if(Input.GetKey(KeyCode.A))
        {
            moveAxis.x = -1;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            moveAxis.x = 1;
        }

        //限制最大速度，防止斜向移动变快
        if(moveAxis.magnitude > 1)
        {
            moveAxis = moveAxis.normalized;
        }

        this.moveAxis = moveAxis;
        //移动（设置坐标）
        this.transform.position += (Vector3)this.moveAxis * dt * speed;
    }

    public void Shout()
    {
        string str = null;
        for(int i = 0; i < volume; i++)
        {
            str += "!";
        }

        if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && number < 10)
        {
            number++;
            Debug.Log("Ah" + str);
        }

        else if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && number == 10)
        {
            number++;
            Debug.Log("憋摁了，烦死了，喊得嗓子都哑了！");
        }

        else if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && number == 11)
        {
            number++;
            Debug.Log("呃......咳咳！");
        }

        else if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && (number >= 12 && number <= 15))
        {
            number++;
            Debug.Log("啊吧啊吧");
        }

        else if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && number >= 16)
        {
            Debug.Log("归零~");
            number = 0;
        }

    }
}
