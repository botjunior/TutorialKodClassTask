using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScence : MonoBehaviour
{
    // Start is called before the first frame update
    public Button GoToMainMenu;
    void Start()
    {
        GoToMainMenu.onClick.AddListener(ToMain);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
