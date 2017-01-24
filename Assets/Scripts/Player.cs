using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 0f;
    public float rotationSpeed = 0f;
    public float jumpHeight = 0f;

    private float movex = 0f;
    private float movey = 0f;

    public bool isGrounded = false;
    public Transform groundCheck1;
    public Transform groundCheck2;

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
        isGrounded = Physics2D.OverlapArea(groundCheck1.position, groundCheck2.position, whatIsGround);

        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");

        //move player left and right
        rigi.velocity = new Vector2(movex * speed, rigi.velocity.y);

        if (isGrounded == true && Input.GetKey(KeyCode.W))
        {
            rigi.velocity = new Vector2(rigi.velocity.x, jumpHeight);
        }
    }
}
