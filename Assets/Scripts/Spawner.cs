using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject boulder1;
    public GameObject boulder2;
    public GameObject boulder3;
    public float spawnTime;
    private float rando;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnTimeDelay());
        Instantiate(boulder3, transform.position, Quaternion.identity);
    }

    IEnumerator SpawnTimeDelay()
    {
        while (true)
        {
            rando = Random.value;
            if (rando >= .2)
            {
                Instantiate(boulder1, transform.position, Quaternion.identity);
            }
            if (rando < .2)
            {
                Instantiate(boulder1, transform.position, Quaternion.identity);
            }
            spawnTime = Random.Range(4.0f, 7.0f);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
