using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 0f;
    public Vector2 jumpHeight;
    public float rotationSpeed = 0f;

    private float movex = 0f;
    private float movey = 0f;

    public bool isGrounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    private Rigidbody2D rigi;

    void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    void Start () {

        //Player spawn point
        transform.position = new Vector2(-1, 0.5f);

	}

    // Update is called once per frame
    void FixedUpdate()
    {
        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");

        //move player left and right
        rigi.velocity = new Vector2(movex * speed, rigi.velocity.y);

        transform.Rotate(Vector3.forward, movex * -rotationSpeed);
    }
}
