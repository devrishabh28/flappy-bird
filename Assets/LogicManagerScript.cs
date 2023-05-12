using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{

    [SerializeField] private int playerScore;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject gameOverScreen;
    private bool isAlive = true;

    [ContextMenu("Increase Score")]
    public void addScore(int score)
    {

        if (!isAlive)
        {
            Debug.Log("Birdy is already dead!");
            return;
        }

        playerScore += score;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        isAlive = false;
        gameOverScreen.SetActive(true);
    }

    public void goBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void updateBirdyStatus(bool isAlive)
    {
        this.isAlive = isAlive;
    }

}
