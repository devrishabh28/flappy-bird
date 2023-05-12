using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdyScript : MonoBehaviour
{

    [SerializeField] private new Rigidbody2D rigidbody2D;
    [SerializeField] private int flapStrength = 10;
    [SerializeField] private LogicManagerScript logic;
    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindObjectOfType<AudioManager>().play("Background");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
            rigidbody2D.velocity = Vector2.up * flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver();
    }

    public void gameOver()
    {
        isAlive = false;
        logic.gameOver();
    }

    public bool isBirdyAlive()
    {
        return isAlive;
    }
}
