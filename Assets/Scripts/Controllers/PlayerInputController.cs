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
    public void OnJump(InputValue button)
    {
        anim = GetComponent<Animator>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetBoolParameter("IsJump", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            SetBoolParameter("IsJump", false);
        }

    }
    private void SetBoolParameter(string isJump, bool value)
    {
        // Animator에 파라미터 값을 설정
        anim.SetBool(isJump, value);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

}
