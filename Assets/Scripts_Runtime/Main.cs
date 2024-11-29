using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    PlayerEntity player;

    //Awake（类似Start，但优先级更高？）
    void Awake()
    {
        //寻找这个名字的Object，因为组件不挂载在物体上，所以不能用this
        //获取PlayerEntity挂载的PlayerEntity组件
        player = GameObject.Find("PlayerEntity").GetComponent<PlayerEntity>();
    }

    void Update()
    {
        //deltaTime：增量时间（运行一帧的时间？）
        float dt = Time.deltaTime;
        PlayerDomain.Move(dt, player);

        PlayerDomain.Shout(player);
    }
}
