using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class Inventory : MonoBehaviour
{
    [SerializeField] TMP_Text counterText;
    public static Inventory instance;
    public int count = 0;
    private AudioSource aSource;


    void Awake()
    {
        if (instance != null && instance != this) Destroy(gameObject);
        else instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        counterText.SetText("Orbs Collected: " + instance.count);
    }

    public void PlaySound()
    {
        aSource.Play();
    }
 }
