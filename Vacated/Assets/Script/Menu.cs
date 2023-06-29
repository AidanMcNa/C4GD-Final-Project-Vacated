using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private Button button;
    public GameObject titleScreen;
    public GameObject titleScreenComponent;
    public GameObject objectives;
    public GameObject endScreen;
    public GameObject endScreen2;
    // Start is called before the first frame update
    void Start()
    {
        objectives.SetActive(false);
        endScreen.SetActive(false);
        endScreen2.SetActive(false);
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        titleScreen.SetActive(false);
        titleScreenComponent.SetActive(false);
        objectives.SetActive(true);
    }

}
