using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected TowerData data;

    protected List<EnemyController> enemyList;

    //public int damage;
    //public float range;
    //public int cost;
    
    //public Tower nextLevelTower;

    protected virtual void Awake()
    {
        enemyList = new List<EnemyController>();
    }
    public void AddEnemy(EnemyController enemy)
    {
        enemyList.Add(enemy);
    }
    public void RemoveEnemy(EnemyController enemy)
    {
        enemyList.Remove(enemy);
    }
}
