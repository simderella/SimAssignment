using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    public Animator anim;
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }
    // Start is called before the first frame update
    public void OnJump(InputValue button)
    {
        Vector2 jumpInput = button.Get<Vector2>();
        //Debug.Log("OnJump" + value.ToString());
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetTriggerParameter();
        }

    }
    private void SetTriggerParameter()
    {
        // Animator에 파라미터 값을 설정
        anim.SetTrigger("new Trigger");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
