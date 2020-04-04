using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBox : MonoBehaviour
{
    public Rigidbody rb;

    public float velocity = 2000f;
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(0, 0, velocity * Time.deltaTime), ForceMode.Force);
    }
}
