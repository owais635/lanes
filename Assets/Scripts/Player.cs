using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    private const string ENEMY_TAG = "Enemy";

    // Lerp Variables
    private bool shouldLerp;

    private float lerpDirection;

    private float lerpStartX;

    private float lerpTime;

    private const float lerpSpeed = 10;

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
        Vector3 currentPos = transform.position;

        // Start Lerp towards Right and wait for lerp to complete
        if (Input.GetKeyDown(KeyCode.RightArrow) && !shouldLerp)
        {
            shouldLerp = true;
            lerpDirection = 1;
            lerpTime = 0;
            lerpStartX = transform.position.x;
        } // Start Lerp towards Left
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && !shouldLerp)
        {
            shouldLerp = true;
            lerpDirection = -1;
            lerpTime = 0;
            lerpStartX = transform.position.x;
        }

        if (shouldLerp && lerpTime <= 1f)
        {
            Vector3 start =
                new Vector3(lerpStartX,
                    transform.position.y,
                    transform.position.z);

            Vector3 end = start + new Vector3(2 * lerpDirection, 0, 0);

            transform.position = Vector3.Lerp(start, end, lerpTime);

            lerpTime += Time.deltaTime * lerpSpeed;
        }
        else if (shouldLerp && lerpTime > 1f)
        {
            // Round x component to set x coordinate be exactly -2, or 0, or 2.
            transform.position =
                new Vector3(Mathf.RoundToInt(currentPos.x),
                    currentPos.y,
                    currentPos.z);

            // lerp is complete, so reset variables
            shouldLerp = false;
            lerpTime = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == ENEMY_TAG)
        {
            GameManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }
}
