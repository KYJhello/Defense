using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : BaseUI
{
    public Transform followTarget;
    public Vector2 followOffset;

    // 대상을 따라다니기 때문에 카메라와 같은 이치로 레이트 업데이트 적용해야함
    private void LateUpdate()
    {
        // 플레이어가 죽었을경우 같이 사라져야하는 경우 예외처리해야함
        if (followTarget == null)
        {
            
        }
        if(followTarget != null)
        {
            transform.position = Camera.main.WorldToScreenPoint(followTarget.position + (Vector3)followOffset);
        }
    }

    public void SetTarget(Transform target)
    {
        this.followTarget = target;
        if (followTarget != null)
        {
            transform.position = Camera.main.WorldToScreenPoint(followTarget.position + (Vector3)followOffset);
        }
    }
    public void SetOffset(Vector2 offset)
    {
        this.followOffset = offset;
        if (followTarget != null)
        {
            transform.position = Camera.main.WorldToScreenPoint(followTarget.position + (Vector3)followOffset);
        }
    }
}
