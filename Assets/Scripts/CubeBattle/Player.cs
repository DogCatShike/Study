using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int hp = 5;
    public float moveSpeed = 10;
    public float rotY;
    public Rigidbody rb;
    public Ray ray;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rotY = transform.rotation.y;
    }

    void Update()
    {
        Move();

        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveAxis = new Vector3(h, 0, v);
        moveAxis.Normalize();
        rb.MovePosition(transform.position + moveAxis * Time.deltaTime * moveSpeed);

        float rh = Input.GetAxis("Mouse X");
        rotY += rh;
        transform.localRotation = Quaternion.Euler(0, rotY, 0);
    }

    void Attack()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit hitInfo);
        
        if(hitInfo.transform.tag == "Enemy")
        {
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            enemy.OnDamage(1);
        }
    }

    public void OnDamage(int x)
    {
        hp -= x;
        GameManager.instance.ChangeLife(hp);
        
        if(hp <= 0)
        {
            GameManager.instance.Restart();
        }
    }
}
