using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageTower : Tower
{
    private void Awake()
    {
        data = GameManager.Resource.Load<TowerData>("Data/MageTowerData");
    }
}
