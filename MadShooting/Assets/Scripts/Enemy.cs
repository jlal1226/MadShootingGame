using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        int randValue = UnityEngine.Random.Range(0, 10);
        // 3이하면 플레이어를 향함
        if (randValue < 3)
        {
            // player를 찾음
            GameObject target = GameObject.Find("Player");
            // 목표 벡터 - 자기 자신 벡터
            dir = target.transform.position - transform.position;
            // 방향의 크기를 1로 설정
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
