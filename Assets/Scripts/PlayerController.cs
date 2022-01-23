using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    float jump = 2;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    Transform gameOver;

    [SerializeField]
    int score = 0;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.velocity = Vector2.up * jump;
        } else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            rb.velocity = Vector2.down * jump;
        } else if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            rb.velocity = Vector2.left * jump;
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            rb.velocity = Vector2.right * jump;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score")) {
            score++;
            scoreText.text = "Pontuação: " + score;
        }

        if (collision.CompareTag("Pipe")) {
            enabled = false;
            gameOver.gameObject.SetActive(true);
            Invoke("Pause", 2);
        }
    }

    void Pause()
    {
        Time.timeScale = 0;
    }
}
