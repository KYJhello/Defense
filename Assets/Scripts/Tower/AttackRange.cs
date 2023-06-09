using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttackRange : MonoBehaviour
{
    //public Tower tower;
    public LayerMask enemyMask;

    public UnityEvent<EnemyController> OnInRangeEnemy;
    public UnityEvent<EnemyController> OnOutRangeEnemy;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("¹º°¡ µé¾î¿È");
        if(enemyMask.IsContain(other.gameObject.layer))
        {
            EnemyController enemy = other.GetComponent<EnemyController>();
            enemy.OnDied.AddListener(() => { OnOutRangeEnemy?.Invoke(enemy); });
            OnInRangeEnemy?.Invoke(enemy);
            //tower.AddEnemy(enemy);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("¹º°¡ ³ª°¨");

        if (enemyMask.IsContain(other.gameObject.layer))
        {
            EnemyController enemy = other.GetComponent<EnemyController>();
            OnOutRangeEnemy?.Invoke(enemy);
            //tower.RemoveEnemy(enemy);
        }
    }
}
