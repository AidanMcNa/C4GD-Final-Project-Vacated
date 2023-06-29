using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEncounter : MonoBehaviour
{
    
    
    public AudioClip scarySound;
    public Vector3 point;
    public GameObject wall;
    public GameObject floor;

    private float timer;
    public float lap;

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
        if (gameObject.tag == "Trigger")
        {
            // destroy this object
            AudioSource.PlayClipAtPoint(scarySound, point);
            floor.SetActive(false);

            wall.SetActive(false);
            
        }
    }
}
