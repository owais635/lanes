using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            Spawn();
        }
    }

    void Spawn()
    {
        Vector3 spawnerPos = transform.position;

        Vector3 pos = new Vector3(spawnerPos.x, spawnerPos.y, spawnerPos.z);
        Instantiate(obstacle, pos, transform.rotation);
    }
}
