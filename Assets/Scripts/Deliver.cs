using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float steerSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0,0,30);
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed*Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed*Time.deltaTime;
        if(speedAmount < 0)
        {
            steerAmount = steerAmount* -1;

        }
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);
    }
}
