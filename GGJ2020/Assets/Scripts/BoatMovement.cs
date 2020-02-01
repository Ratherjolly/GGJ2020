using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {

        

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float random = Random.Range(1f, 3f);

            if (random > 2)
            {
                thrust = 0.5f;
            }
            else if (random > 1)
            {
                thrust = 0.1f;
            }
            else
            {
                thrust = 0.2f;
            }

            rb.AddForce(-thrust, 0, 0, ForceMode.Impulse);
        }
            

        if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
    }
}