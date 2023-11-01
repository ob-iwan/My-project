using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class menuBall : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 4f;
    public float ySpeed = 4f;

    private bool gameReset = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameReset == true)
        {
            transform.position = new Vector3(xPosition, yPosition, 0f);
        }

        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            xSpeed = xSpeed * -1f;
        }

        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }

        if (collision.gameObject.CompareTag("leftWall"))
        {
            gameReset = true;
            xPosition = 0f;
            yPosition = 0f;
        }

        if (collision.gameObject.CompareTag("rightWall"))
        {
            gameReset = true;
            xPosition = 0f;
            yPosition = 0f;
        }
    }
}
