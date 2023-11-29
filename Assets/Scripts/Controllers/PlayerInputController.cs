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
        // Vector ���� �Ǽ��� ��ȯ
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
            // Jump Ʈ���Ÿ� Ȱ��ȭ�Ͽ� ���� �ִϸ��̼��� �����մϴ�.
            anim.SetTrigger("New Trigger");
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

}
