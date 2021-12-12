using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float speed = 20f;

    public static bool isGameOver;

    public GameObject gameoverScreen;

    private void Awake()
    {
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameoverScreen.SetActive(true); // show game over panel
        }
        else
        {
            transform.position += new Vector3(0f, speed, 0f) * Time.deltaTime;
        }
    }
}
