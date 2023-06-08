using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildInGameUI : InGameUI
{
    public TowerPlace towerPlace;

    protected override void Awake()
    {
        base.Awake();

        buttons["Blocker"].onClick.AddListener(() => { GameManager.UI.CloseInGameUI(this); });
        buttons["ArchorButton"].onClick.AddListener(() => { BuildArchorTower(); });
        buttons["CanonButton"].onClick.AddListener(() => { BuildCanonTower(); });
        buttons["MageButton"].onClick.AddListener(() => { BuildMageTower(); });

    }
    public void BuildArchorTower()
    {
        TowerData archorTowerData = GameManager.Resource.Load<TowerData>("Data/ArchorTowerData");
        towerPlace.BuildTower(archorTowerData);
    }
    public void BuildCanonTower()
    {
        TowerData canonTowerData = GameManager.Resource.Load<TowerData>("Data/CanonTowerData");
        towerPlace.BuildTower(canonTowerData);
    }
    public void BuildMageTower()
    {
        TowerData mageTowerData = GameManager.Resource.Load<TowerData>("Data/MageTowerData");
        towerPlace.BuildTower(mageTowerData);
    }

}
