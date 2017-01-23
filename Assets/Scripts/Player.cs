using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 0f;
    public float rotationSpeed = 0f;

    private float movex = 0f;
    private float movey = 0f;

    private bool isGrounded = false;

    private Rigidbody2D rigi;

    private void Awake()
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

        transform.Translate(Vector3.right * movex * speed * Time.deltaTime, Space.World);

        transform.Rotate(Vector3.forward, movex * -1 * rotationSpeed);
    }
}
