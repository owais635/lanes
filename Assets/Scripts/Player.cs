using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    private float speed = 5;

    public float moveForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float movementX = Input.GetAxisRaw("Horizontal");
        transform.position +=
            new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }

    void FixedUpdate()
    {
        // move player upwards
        // myRigidBody.AddForce(new Vector2(0, speed));
        // myRigidBody.velocity = new  Vector2(0, speed);
    }
}
