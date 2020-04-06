using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int life = 100, ammo = 100;
    public DynamicJoystick joystick;
    public Rigidbody rb;
    public float horizontalSpeed;
    public float horizontalLimit = 5.3f;
    private PlayerBox playerBox;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed;
    public Animator animator;
    private SceneManager sceneManager;
    //private bool canMove = true;
    private void Start()
    {
        sceneManager = FindObjectOfType<SceneManager>();
        playerBox = FindObjectOfType<PlayerBox>();
    }
    private void Update()
    {
        if (sceneManager.started)
        {
            Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;

            rb.velocity = new Vector3(0, 0, playerBox.velocity);
            //rb.AddForce(new Vector3(0, 0, playerBox.velocity * Time.deltaTime), ForceMode.Force);
            //Girar a la derecha
            if (joystick.Horizontal > 0.3f)
            {
                direction = new Vector3(1f, rb.velocity.y, rb.velocity.z);
                animator.SetBool("right", true);
            }

            //Girar a la izquierda
            if (joystick.Horizontal < -0.3f)
            {
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

            rb.velocity = new Vector3(horizontalSpeed * direction.x, rb.velocity.y, rb.velocity.z);

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -horizontalLimit, horizontalLimit),
                transform.position.y,
                transform.position.z);

            //Disparar con el botón espacio
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fireBullet();
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger");
        Enemy enemy =  other.GetComponentInParent<Enemy>();
        life -= enemy.crashDamage; // life = life - enemy.crashDamage;
        //Destroy(other.gameObject);
    }

    public void fireBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = firePoint.transform.position; // mirar si poner en otro punto 
        //b.transform.rotation = Quaternion.Euler(_rotation);
        bulletSpeed += playerBox.velocity;
        b.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 1) * (bulletSpeed);
    }

}
