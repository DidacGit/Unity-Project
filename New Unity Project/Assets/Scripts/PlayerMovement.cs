using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float velocity = 2000f;
    // Update is called once per frame
    void FixedUpdate() {
	rb.AddForce(new Vector3(0, 0, velocity * Time.deltaTime), ForceMode.Force);
    }
}
