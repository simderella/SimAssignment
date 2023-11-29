using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnJumpEvent;
    private Animator anim;
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
    public void CallJumpEvent(Action button)
    {
        anim = GetComponent<Animator>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Jump Ʈ���Ÿ� Ȱ��ȭ�Ͽ� ���� �ִϸ��̼��� �����մϴ�.
            anim.SetTrigger("New Trigger");
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

}
