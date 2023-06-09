using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] float speed;


    private Vector3 targetPoint;

    private EnemyController enemy;
    private int damage;

    public void SetTarget(EnemyController enemy)
    {
        this.enemy = enemy;
        targetPoint = enemy.transform.position;
        StartCoroutine(ArrowRoutine());
    }

    public void SetDamage(int damage)
    {
        this.damage = damage;
    }


    IEnumerator ArrowRoutine()
    {
        while (true)
        {
            //// enemy 풀링시 널 체크 주의
            //if(enemy == null)
            //{
            //    GameManager.Resource.Destroy(gameObject);
            //    yield break;
            //}

            
            if (enemy != null)
            {
                targetPoint = enemy.transform.position;
                transform.LookAt(targetPoint);
            }

            //Vector3 vector = enemy.transform.position - transform.position;
            //Vector3 dir = vector.normalized;

            //transform.Translate(dir * speed * Time.deltaTime, Space.World);

            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
            
            if(Vector3.Distance(targetPoint, transform.position) < 0.1f)
            {
                if(enemy != null)
                {
                    Attack(enemy);
                }

                // 공격과 화살 사라지는거 구현
                GameManager.Resource.Destroy(gameObject);
                yield break;
            }

            yield return null;
        }
    }
    public void Attack(EnemyController enemy)
    {
        enemy?.TakeHit(damage);
    }
}
