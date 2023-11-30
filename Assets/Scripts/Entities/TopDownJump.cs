using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownJump : MonoBehaviour
{
    private Animator anim;
    private TopDownCharacterController _controller;

    // Start is called before the first frame update
    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();

    }

    // Update is called once per frame
    void Update()
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
}
