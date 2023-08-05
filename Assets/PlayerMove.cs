using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Text ScoreText;
    Rigidbody rb;
    int score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(horizontalInput, 0, verticalInput));
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Pick Up")
        {
            collision.gameObject.SetActive(false);
            ScoreText.text = "Score: " + (++score).ToString();
        }
    }
}