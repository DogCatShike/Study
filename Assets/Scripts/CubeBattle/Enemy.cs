using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 2;
    public float moveSpeed = 0.5f;
    public int score = 10;
    public Rigidbody rb;
    GameObject playerEntity;
    Player player;

    void Start()
    {
        playerEntity = GameObject.FindWithTag("Player");
        player = playerEntity.GetComponent<Player>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    public void OnDamage(int x)
    {
        hp -= x;

        if(hp <= 0)
        {
            GameManager.instance.ChangeScore(score);
            Destroy(gameObject);
        }
    }

    void Move()
    {
        Vector3 moveTo = playerEntity.transform.position - transform.position;
        moveTo *= Time.deltaTime * moveSpeed;

        transform.LookAt(playerEntity.transform.position);
        
        rb.MovePosition(transform.position + moveTo);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Player")
        {
            player.OnDamage(1);

            Destroy(gameObject);
        }
    }
}
