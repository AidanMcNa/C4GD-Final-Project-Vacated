using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SC_NPCFollow : MonoBehaviour
{
    public float speed = 1f;
    //Transform that NPC has to follow
    public Transform transformToFollow;
    //NavMesh Agent variable
    NavMeshAgent agent;
    private Animator anim;
    private float timer;
    public float lap;
    public AudioClip monSound;
    private AudioSource playerAudio;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //Follow the player
        agent.destination = transformToFollow.position;
        agent.speed = speed;
        
        anim.SetBool("move", true);
        
        timer += Time.deltaTime;

        if (timer > lap)
        {
            playerAudio.PlayOneShot(monSound, 1f);

            timer = 0f;

        }
        
    }
}