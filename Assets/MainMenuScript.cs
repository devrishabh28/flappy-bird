using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    void Start()
    {
        GameObject.FindObjectOfType<AudioManager>().play("Background");
    }

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
