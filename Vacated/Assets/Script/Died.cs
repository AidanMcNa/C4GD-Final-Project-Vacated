using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Died : MonoBehaviour
{
    public GameObject restart;
    public GameObject deadScreen1;
    public GameObject deadScreen2;
    public GameObject objectives;
    // Start is called before the first frame update
    void Start()
    {
        deadScreen1.SetActive(false);
        deadScreen2.SetActive(false);
        restart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (gameObject.tag == "MonsterKill")
        {
            // destroy this object
            deadScreen1.SetActive(true);
            deadScreen2.SetActive(true);
            objectives.SetActive(false);
            restart.SetActive(true);
            Destroy(gameObject);


        }
    }
}
