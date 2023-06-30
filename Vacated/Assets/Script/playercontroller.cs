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
    public GameObject wall;
    public GameObject zombie;
    public GameObject trigga;
    public GameObject monsta;
    public GameObject trigga2;

    //public float timeRemaining = 10;
    private bool OnGround = true;
    public AudioClip walkSound;
    public AudioClip grassSound;

    private float timer;
    public float lap;
    public float lap2;

    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > lap2)
        {
            wall.SetActive(true);
            zombie.SetActive(true);
            timer = 0f;

        }
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


        


        if (timer > lap && forwardInput != 0 && OnGround)
        {
            playerAudio.PlayOneShot(walkSound, 1f);

            timer = 0f;
            
        }
        if (timer > lap && forwardInput != 0 && OnGround == false)
        {
            playerAudio.PlayOneShot(grassSound, 1f);

            timer = 0f;
            
        }
        
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Grass"))
        {
            OnGround = false;
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            OnGround= true;
        }
        if (collision.gameObject.CompareTag("trigga"))
        {
            monsta.SetActive(true);
            Debug.Log("Hi");
        }
        if (collision.gameObject.CompareTag("Trigga2"))
        {
            monsta.SetActive(false);
            Debug.Log("Bye");
        }
    }
    


}
