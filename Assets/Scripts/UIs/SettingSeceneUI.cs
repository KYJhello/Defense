using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingSeceneUI : SeceneUI
{
    protected override void Awake()
    {
        base.Awake();

        buttons["InfoButton"].onClick.AddListener(() => { OpenInfoWindowUI(); });
        buttons["VolumeButton"].onClick.AddListener(() => { Debug.Log("Volume"); });
        buttons["SettingButton"].onClick.AddListener(() => { OpenPausePopUpUI(); });
    }

    public void OpenInfoWindowUI()
    {
        GameManager.UI.ShowWindowUI("UI/InfoWindowUI");
    }

    public void OpenPausePopUpUI()
    {
        GameManager.UI.ShowPopUpUI("UI/SettingPopUpUI");
    }

    public void ClickInfoButton()
    {
        
    }
}
