using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAI : MonoBehaviour
{
    public float speed;
    private Transform playerpos;
    private Player player;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerpos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerpos.position , speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            player.health--;

            Debug.Log(player.health);
            Destroy(gameObject);
        }
     if(collision.CompareTag("Projectile"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
