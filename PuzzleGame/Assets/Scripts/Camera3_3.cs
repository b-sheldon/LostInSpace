using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3_3 : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            // Move the Camera
            animator.SetBool("Move3_3", true);
            animator.SetBool("Back3_4", true);
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player") {
            animator.SetBool("Move3_3", false);
            animator.SetBool("Back3_4", false);
        }
    }
}
