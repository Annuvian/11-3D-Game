using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody ball;
    public Transform camera;
    public float power = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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

    public void Putt()
    {
        ball.AddForce(transform.forward * power, ForceMode.Impulse);
    }
}