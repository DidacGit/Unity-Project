using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int life = 100, ammo = 100;
    public DynamicJoystick joystick;
    public Rigidbody rb;
    public float speed;
    public float horizontalLimit = 5.3f;
    private PlayerBox playerBox;

    public Animator animator;
    //private bool canMove = true;
    private void Start()
    {
        playerBox = FindObjectOfType<PlayerBox>();
    }
    private void Update()
    {
        Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;

        rb.AddForce(new Vector3(0,
                    0,
                    playerBox.velocity * Time.deltaTime), ForceMode.Force);
        //Girar a la derecha
        if (joystick.Horizontal > 0.3f) {
            direction = new Vector3(1f, rb.velocity.y, rb.velocity.z);
            animator.SetBool("right", true);
        } 
        
        //Girar a la izquierda
        if (joystick.Horizontal < -0.3f){
            direction = new Vector3(-1f, rb.velocity.y, rb.velocity.z);
            animator.SetBool("left", true);

        }

        //No gira, sigue recto
        if (joystick.Horizontal < 0.3f && joystick.Horizontal > -0.3f)
        {
            direction = new Vector3(0, rb.velocity.y, rb.velocity.z);
            animator.SetBool("left", false);
            animator.SetBool("right", false);
        }
            
        rb.velocity = new Vector3(speed * direction.x, rb.velocity.y, rb.velocity.z);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -horizontalLimit, horizontalLimit), 
            transform.position.y, 
            transform.position.z);

    }

}
