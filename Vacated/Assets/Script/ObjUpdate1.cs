using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjUpdate1 : MonoBehaviour
{
    public AudioSource playSound;
    public TMP_Text canvasText;
    public string objective;
    public TMP_Text canvasText2;
    public string explination;
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
        canvasText.text = objective;
        canvasText2.text = explination;
        playSound.Play();
        Destroy(gameObject);


    }
}
