using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ball_script_extra : MonoBehaviour
{
    public float xPosition = 1f;
    public float yPosition = 1f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("ow my head");
            xSpeed = xSpeed * -1f;
        }

        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("ow my toe");
            ySpeed =  ySpeed * -1f;
        }
    }   
}
