using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    [SerializeField] float time;

    private TrailRenderer trail;
    private Vector3 targetPoint;
    //private EnemyController enemy;
    private int damage;
    private float range;

    public void SetTarget(EnemyController enemy)
    {
        //this.enemy = enemy;
        targetPoint = enemy.transform.position;
        StartCoroutine(CanonRoutine());
    }

    public void SetDamage(int damage)
    {
        this.damage = damage;
    }


    IEnumerator CanonRoutine()
    {
        float xSpeed = (targetPoint.x - transform.position.x) / time;
        float zSpeed = (targetPoint.z - transform.position.z) / time;
        float ySpeed = -1 * (0.5f * Physics.gravity.y * time * time + transform.position.y)/time;

        float curTime = 0;
        while (curTime < time)
        {
            curTime += Time.deltaTime;
            ySpeed += Physics.gravity.y * Time.deltaTime;

            transform.position += new Vector3(xSpeed, ySpeed, zSpeed) * Time.deltaTime;

            yield return null;
        }
        Explosion();
        GameManager.Resource.Destroy(gameObject);

    }


    public void Explosion()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, range, LayerMask.GetMask("Enemy"));
        foreach (Collider collider in colliders) {
            EnemyController enemy = collider.GetComponent<EnemyController>();
            enemy?.TakeHit(damage);

            // 폭발로 인한 이동시 아래 함수 활용
            //Rigidbody rb = collider.GetComponent<Rigidbody>();
            //rb?.AddExplosionForce();
        }
    }

    public void Attack(EnemyController enemy)
    {
        // 안에 있던 충돌체들을 가져오는 방식
        Collider[] collider = Physics.OverlapSphere(transform.position, range);
        enemy.TakeHit(damage);
       
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
