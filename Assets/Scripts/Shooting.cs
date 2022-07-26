using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shot;
    private Transform playerpos;
    // Start is called before the first frame update
    void Start()
    {
        playerpos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, playerpos.position, Quaternion.identity);
        }
    }
}
