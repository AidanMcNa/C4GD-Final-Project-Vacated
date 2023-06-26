using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

    public float speed = 20f;
    public float turnSpeed = 20f;
    private float forwardInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle forward
        forwardInput = Input.GetAxis("Vertical");
        //return -1 to 1 if player pressing s or w
        //return 0 if no input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //turn the vehicle right and left 
        horizontalInput = Input.GetAxis("Horizontal");
        //return -1 to 1 if player pressing a or d
        //return 0 if no input
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed);
    }
}
