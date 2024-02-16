using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera4_1 : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            // Move the Camera
            animator.SetBool("Move4_1", true);
            animator.SetBool("Back4_1", false);
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player") {
            animator.SetBool("Move4_1", false);
            animator.SetBool("Back4_1", true);
        }
    }
}
