using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStartTrigger : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            // Move the Camera
            animator.SetBool("Back1_2", true);
            animator.SetBool("Move1_2", false);
            animator.SetBool("Back1_3", false);
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player") {
            // Move the Camera
            animator.SetBool("Back1_2", false);
        }
    }
}
