using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ButtonInteract : MonoBehaviour
{
    [SerializeField] private GameObject inputObject;
    [SerializeField] private Animator animator;
    private bool inTrigger = false;
    private int move = 0;
    private AudioSource aSource;

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for F key input
        if (inTrigger) {
            if (Input.GetKeyDown(KeyCode.F)) {
                aSource.Play();
                if (move == 0) {
                    move = 1;
                    animator.SetBool("Move", true);
                    animator.SetBool("Return", false);
                }
                else {
                    move = 0;
                    animator.SetBool("Move", false);
                    animator.SetBool("Return", true);
                }
            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            // remove object
            inTrigger = true;
            inputObject.SetActive(!inputObject.activeSelf);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            // remove object
            inTrigger = false;
            inputObject.SetActive(!inputObject.activeSelf);
        }
    }
}
