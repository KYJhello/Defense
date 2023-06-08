using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : BaseUI
{
    public Transform followTarget;
    public Vector2 followOffset;

    // ����� ����ٴϱ� ������ ī�޶�� ���� ��ġ�� ����Ʈ ������Ʈ �����ؾ���
    private void LateUpdate()
    {
        // �÷��̾ �׾������ ���� ��������ϴ� ��� ����ó���ؾ���
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
