using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int hp;
    public int HP {  get { return hp; }  private set { hp = value; OnChangeHP?.Invoke(hp); } }

    public UnityEvent<int> OnChangeHP;
    public UnityEvent OnDied;

    public void TakeHit(int damage)
    {
        hp -= damage;
        //OnChangeHP?.Invoke(hp);

        if (hp <= 0)
        {
            OnDied?.Invoke();
            GameManager.Resource.Destroy(gameObject);
        }
    }
}
