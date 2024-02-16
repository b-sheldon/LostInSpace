using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2_2 : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            // Move the Camera
            animator.SetBool("Move2_2", true);
            animator.SetBool("Back2_3", true);
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player") {
            animator.SetBool("Move2_2", false);
            animator.SetBool("Back2_3", false);
        }
    }
}
