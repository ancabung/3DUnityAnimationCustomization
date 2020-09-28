using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        
    }
    public void SetAnimation()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("ActivateAnimation", true);
        }
    }
}
