using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EndGame : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    [SerializeField] private GameObject inputObject;
    [SerializeField] private GameObject explosion;
    private bool inTrigger = false;
    private AudioSource aSource;

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger) {
            if (Input.GetKeyDown(KeyCode.F)) {
                // Trigger explosion
                aSource.Play();
                Explode();
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

    private void Explode()
    {
        explosion.SetActive(true);
        explosion.GetComponent<ParticleSystem>().Play();
        ParticleSystem.EmissionModule em = explosion.GetComponent<ParticleSystem>().emission;
        em.enabled = true;
        animator.SetBool("MoveFinal", true);
        // object[] obj = GameObject.FindSceneObjectsOfType(typeof (GameObject));
        // foreach (object o in obj)
        // {
        //     GameObject g = (GameObject) o;
        //     MeshRenderer meshRenderer = g.GetComponent<MeshRenderer>();
        //     if (meshRenderer != null) {
        //         if (g.GetComponent<Rigidbody>() == null) g.AddComponent<Rigidbody>();
        //         foreach (Collider collider in g.GetComponents<Collider>()) {
        //             Destroy(collider);
        //         }
        //         g.GetComponent<Rigidbody>().AddExplosionForce(eForce, ePos, eRadius);
        //     }
        // }
    }
}
