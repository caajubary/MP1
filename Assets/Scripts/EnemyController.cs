using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject bodyTank;
    public GameObject bullet;
    public GameObject gun;
    public GameObject transhoot;
    public GameObject player;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = player.transform.position;
        var gunDirection = direction - transform.position;
        if(gunDirection != Vector3.zero)
        {
            this.gameObject.transform.up = gunDirection;
        }
        this.gameObject.transform.position += gunDirection * Time.deltaTime * speed;
        gun.transform.up = gunDirection;


        if (Random.Range(0,100) %50 == 0)
        {
            Instantiate(bullet, transhoot.transform.position, transform.transform.rotation);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
