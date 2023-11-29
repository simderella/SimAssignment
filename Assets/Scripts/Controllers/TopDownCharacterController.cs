using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnJumpEvent;
    private Animator animator;
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
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

}
