using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class OpenDoor : MonoBehaviour
{
    [SerializeField] public int doorCount;
    private AudioSource aSource;
    private bool played = false;

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.instance.count >= doorCount) {
            this.gameObject.GetComponent<Animator>().SetBool("collected", true);
            if (!played) {
                aSource.Play();
                played = true;
            }
        }
    }
}
