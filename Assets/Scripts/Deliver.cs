using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0,0,30);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,-30*Time.deltaTime);
    }
}
