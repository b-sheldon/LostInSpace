using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3_4 : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            // Move the Camera
            animator.SetBool("Move3_4", true);
            // animator.SetBool("Back4_1", true);
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player") {
            animator.SetBool("Move3_4", false);
            // animator.SetBool("Back4_1", false);
        }
    }
}
