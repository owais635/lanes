using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
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
}
