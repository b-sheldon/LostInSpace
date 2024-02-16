using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up, 60 * Time.deltaTime);
        this.transform.position = this.transform.position + new Vector3(0.0f, (float) (0.0015 * Mathf.Sin(Time.time)), 0.0f);
    }
}
