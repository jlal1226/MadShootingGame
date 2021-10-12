using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime;
    public float createTime = 1;
    public GameObject enemyFactory;

    float minTime = 1;
    float maxTime = 5;
    // 초기 세팅
    void Start()
    {
        // 랜덤 시간 설정하여 몬스터 생성
        createTime = UnityEngine.Random.Range(minTime, maxTime);

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > createTime)
        {
            // enemy 생성
            GameObject enemy = Instantiate(enemyFactory);
            // 내 위치로 가지고 옴
            enemy.transform.position = transform.position;

            currentTime = 0;
            // 적 생성 후 시간 랜덤하게 재 설정
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
