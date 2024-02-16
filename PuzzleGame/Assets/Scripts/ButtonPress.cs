using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairButtonPress : MonoBehaviour
{
    private int move = 0;
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction, Color.red, 30.0f);
            
            if (Physics.Raycast(ray, out hit, 200.0f)) {
                if(hit.transform.gameObject == this.transform.gameObject) {
                    Debug.Log("clicked on the stair button");
                    // toggle input object on/off
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
    }
}
