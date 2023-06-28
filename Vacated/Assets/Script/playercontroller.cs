using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

    public float speed = 20f;
    public float turnSpeed = 20f;
    private float forwardInput;
    private float horizontalInput;
    private Animator anim;
    private AudioSource playerAudio;

    //public float timeRemaining = 10;
    private bool OnGround = true;
    public AudioClip walkSound;

    private float timer;
    public float lap;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
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
        anim.SetFloat("forward", forwardInput);

        timer += Time.deltaTime;
        if (timer > lap && forwardInput != 0)
        {
            playerAudio.PlayOneShot(walkSound, 1f);

            timer = 0f;
        }
        
    }

    

}
