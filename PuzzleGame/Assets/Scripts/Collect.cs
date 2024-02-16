using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collect : MonoBehaviour
{   
    [SerializeField] private GameObject inputObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            // remove object
            inputObject.SetActive(!inputObject.activeSelf);
            // add coin to inventory and play sound
            Inventory.instance.count++;
            Inventory.instance.PlaySound();
        }
    }
}
