using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidbody;

    // Update is called once per frame
    void FixedUpdate() {
	rigidbody.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
