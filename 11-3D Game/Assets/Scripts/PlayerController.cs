using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour
{
    public Rigidbody ball;
    public Transform camera;
    public Text powerUI;
    public Text strokesUI;
    public float power = 0;
    public int strokes = 0;
    public int counter = 0;
    private Vector3[] position = new[] {
        new Vector3(-4.657f, 0.051f, -4.44f), // hole 1
        new Vector3(-3.837f, 0.051f, -4.558f), // hole 2
        new Vector3(-0.676f, 0.051f, -4.566f) // hole 3
    };


    // Start is called before the first frame update
    void Start()
    {
        ball.position = position[0];
    }

    // Update is called once per frame
    void Update()
    {
        ball.transform.eulerAngles = new Vector3(0, camera.transform.eulerAngles.y, 0);
        if (Input.GetKeyDown("1"))
        {
            power = 0.05f;
            powerUI.text = "Power: 1";
        }
        if (Input.GetKeyDown("2"))
        {
            power = 0.10f;
            powerUI.text = "Power: 2";
        }
        if (Input.GetKeyDown("3"))
        {
            power = 0.15f;
            powerUI.text = "Power: 3";
        }
        if (Input.GetKeyDown("4"))
        {
            power = 0.20f;
            powerUI.text = "Power: 4";
        }
        if (Input.GetKeyDown("5"))
        {
            power = 0.25f;
            powerUI.text = "Power: 5";
        }
        if (Input.GetKeyDown("6"))
        {
            power = 0.30f;
            powerUI.text = "Power: 6";
        }
        if (Input.GetKeyDown("7"))
        {
            power = 0.35f;
            powerUI.text = "Power: 7";
        }
        if (Input.GetKeyDown("8"))
        {
            power = 0.40f;
            powerUI.text = "Power: 8";
        }
        if (Input.GetKeyDown("9"))
        {
            power = 0.45f;
            powerUI.text = "Power: 9";
        }
        if (Input.GetMouseButtonDown(0))
        {
            Putt();
        }
    }

    private void Putt()
    {
        strokes++;
        strokesUI.text = "Strokes: " + Convert.ToString(strokes);
        ball.AddForce(transform.forward * power, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            Destroy(collision.gameObject);
            ball.velocity = new Vector3(0, 0, 0);
            counter++;
            ball.position = position[counter];
        }
    }
}