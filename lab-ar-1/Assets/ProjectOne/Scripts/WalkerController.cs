using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerEnter()
    {
        Debug.Log("pointer enter!");
        // Stop animation
        // Make head move
        animator.SetTrigger("Stop");
        animator.SetFloat("WalkSpeed", 0f);
    }

    public void OnPointerExit()
    {
        Debug.Log("pointer exit!");
        // Resume the animation
        // Head stops moving
        animator.SetTrigger("Resume");
        animator.SetFloat("WalkSpeed", 1f);
    }
}