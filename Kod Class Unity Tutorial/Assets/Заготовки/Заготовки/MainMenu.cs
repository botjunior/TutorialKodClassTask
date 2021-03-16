using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public Button start;
    public Button exit;
    // Update is called once per frame
    private void Start()
    {
        start.onClick.AddListener(StartGame);
        exit.onClick.AddListener(ExitGame);
    }
    void Update()
    {
       
    }

    void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
