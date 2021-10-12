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
    // �ʱ� ����
    void Start()
    {
        // ���� �ð� �����Ͽ� ���� ����
        createTime = UnityEngine.Random.Range(minTime, maxTime);

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > createTime)
        {
            // enemy ����
            GameObject enemy = Instantiate(enemyFactory);
            // �� ��ġ�� ������ ��
            enemy.transform.position = transform.position;

            currentTime = 0;
            // �� ���� �� �ð� �����ϰ� �� ����
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
