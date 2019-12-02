using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody ball;
    public Transform camera;
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
        }
        if (Input.GetKeyDown("2"))
        {
            power = 0.10f;
        }
        if (Input.GetKeyDown("3"))
        {
            power = 0.15f;
        }
        if (Input.GetKeyDown("4"))
        {
            power = 0.20f;
        }
        if (Input.GetKeyDown("5"))
        {
            power = 0.25f;
        }
        if (Input.GetKeyDown("6"))
        {
            power = 0.30f;
        }
        if (Input.GetKeyDown("7"))
        {
            power = 0.35f;
        }
        if (Input.GetKeyDown("8"))
        {
            power = 0.40f;
        }
        if (Input.GetKeyDown("9"))
        {
            power = 0.45f;
        }
        if (Input.GetKeyDown("down"))
        {

        }
        if (Input.GetMouseButtonDown(0))
        {
            Putt();
        }
    }

    private void Putt()
    {
        strokes++;
        ball.AddForce(transform.forward * power, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            Destroy(collision.gameObject);
            counter++;
            ball.position = position[counter];
        }
    }
}