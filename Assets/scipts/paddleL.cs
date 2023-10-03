using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class paddleL : MonoBehaviour
{
    private float yPosition;
    public float ySpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-7f, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-7f, yPosition, 0f);

        if (Input.GetKey(KeyCode.W) && yPosition <= 3.5)
        {
            yPosition = yPosition + ySpeed * Time.deltaTime;
            Debug.Log("W key pressed");
        }

        if (Input.GetKey(KeyCode.S) && yPosition >= -3.5)
        {
            yPosition = yPosition - ySpeed * Time.deltaTime;
            Debug.Log("S key pressed");
        }
    }
}
