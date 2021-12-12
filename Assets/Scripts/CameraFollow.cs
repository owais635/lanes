using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void LateUpdate()
    {
        // Debug.Log("player" + transform.position);
        // the player object has been destroyed
        if (playerTransform == null) return;

        Vector3 cameraPosition = transform.position;
        cameraPosition.y = playerTransform.position.y + 3.5f;

        // if (tempPosition.x < minX) tempPosition.x = minX;
        // if (tempPosition.x > maxX) tempPosition.x = maxX;
        transform.position = cameraPosition;
    }
}
