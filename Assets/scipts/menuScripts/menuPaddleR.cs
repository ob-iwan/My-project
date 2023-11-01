using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPaddleR : MonoBehaviour
{
    private float yPosition;
    public float ySpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(7f, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(7f, yPosition, 0f);

        yPosition = yPosition + ySpeed * Time.deltaTime;

        if (yPosition <= 3.5)
        {
            ySpeed = ySpeed * -1;
        }

        if (yPosition >= -3.5)
        {
            ySpeed = ySpeed * -1;
        }
    }
}
