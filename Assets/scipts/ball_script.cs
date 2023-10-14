using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class ball_script : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 4f;
    public float ySpeed = 4f;

    private int leftScore = 0;
    private int rightScore = 0;

    public TextMeshProUGUI scoreBoard;

    private bool game = false;
    private bool gameReset = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        print(leftScore + " - " + rightScore);

        scoreBoard.text = leftScore + " - " + rightScore;

        if (gameReset == true)
        {
            transform.position = new Vector3(xPosition, yPosition, 0f);
        }

        if (game == true)
        {
            xPosition = xPosition + xSpeed * Time.deltaTime;
            yPosition = yPosition + ySpeed * Time.deltaTime;
            transform.position = new Vector3(xPosition, yPosition, 0f);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            game = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("hit wall");
            xSpeed = xSpeed * -1f;
        }

        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("hit horizontal wall");
            ySpeed = ySpeed * -1f;
        }

        if (collision.gameObject.CompareTag("leftWall"))
        {
            game = false;
            gameReset = true;
            xPosition = 0f;
            yPosition = 0f;
            rightScore++;
        }

        if (collision.gameObject.CompareTag("rightWall"))
        {
            game = false;
            gameReset = true;
            xPosition = 0f;
            yPosition = 0f;
            leftScore++;
        }
    }
}
