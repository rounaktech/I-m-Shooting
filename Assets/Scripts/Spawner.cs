using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public Transform[] spawnspots;
    public float timebwsp;
    public float starttimebwsp;
    // Start is called before the first frame update
    void Start()
    {
        timebwsp = starttimebwsp;
    }

    // Update is called once per frame
    void Update()
    {
        if (timebwsp <= 0) {
            int randPos = Random.Range(0, spawnspots.Length);
            Instantiate(enemy, spawnspots[randPos].position, Quaternion.identity);
            timebwsp = starttimebwsp;
                }
        else
        {
            timebwsp -= Time.deltaTime;
        }
    }
}
