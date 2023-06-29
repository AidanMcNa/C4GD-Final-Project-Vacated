using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject endScreen2;
    public GameObject objectives;
    // Start is called before the first frame update
    void Start()
    {
        endScreen.SetActive(false);
        endScreen2.SetActive(false);
       
    }
    
    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {
        if (gameObject.tag == "ExitBox")
        {
            // destroy this object
            endScreen.SetActive(true);
            endScreen2.SetActive(true);
            objectives.SetActive(false);
            Destroy(gameObject);


        }
    }
    
}
