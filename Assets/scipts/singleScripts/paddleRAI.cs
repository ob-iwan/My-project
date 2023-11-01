using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour

{
    public float ySpeed = 4f;

    private float yPosition = 0f;

    public GameObject Ball;

    // Start is called before the first frame update

    void Start()

    {

    }

    // Update is called once per frame

    void Update()

    {

        yPosition = yPosition = ySpeed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, Ball.transform.position.y / 1.75f, transform.position.z);

    }

}