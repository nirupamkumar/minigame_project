using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("Escape key pressed");
            Cursor.lockState = CursorLockMode.None;
            //Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
    }

    public void PauseButton()
    {
        //Debug.Log("Pause button pressed");
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
        //Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        //Debug.Log("Main menu button pressed");
        SceneManager.LoadScene(0);
    }
}
