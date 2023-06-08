using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchorTower : Tower
{
    private void Awake()
    {
        data = GameManager.Resource.Load<TowerData>("Data/ArchorTowerData");
        //data.towers[0].buildTime = 9999;
    }
}
