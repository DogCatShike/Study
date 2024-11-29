using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform m_enemyPrefab;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            Instantiate(m_enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
