using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBottomWell : MonoBehaviour
{
    public AudioSource playSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        if (gameObject.tag == "WellKey")
        {
            // destroy this object
            playSound.Play();
            Destroy(gameObject);
        }
    }
}

