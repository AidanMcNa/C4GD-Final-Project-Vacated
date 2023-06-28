using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractKey1 : MonoBehaviour
{
    public int sequence;
    // Start is called before the first frame update
    void Start()
    {
        sequence = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (gameObject.tag == "Bedroom1Key" && sequence == 0)
        {
            // destroy this object
            Destroy(gameObject);
        }
    }
    

}
