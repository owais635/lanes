using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // [SerializeField]
    // List<float> points = new float[3];
    float[] points = new float[] { -2f, 0, 2f };

    private const string SPAWN_POINT_TAG = "Spawn Point";

    private const string COLLECTOR_POINT_TAG = "Collector Point";

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 collector =
            GameObject.FindWithTag(COLLECTOR_POINT_TAG).transform.position;

        if (transform.position.y <= collector.y)
        {
            Vector3 spawnPoint =
                GameObject.FindWithTag(SPAWN_POINT_TAG).transform.position;

            int randIndex = Random.Range(0, 3);

            // move the Obstacle ahead
            float x = points[randIndex];
            transform.position = new Vector3(x, spawnPoint.y, 0f);
        }
    }
}
