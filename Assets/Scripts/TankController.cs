using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public int speed;
    public GameObject bodyTank;
    public GameObject gun;
    public GameObject bullet;
    public GameObject transhoot;
    public GameObject smoke;
    private float timeCounter;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TankMove();
        TankShoot();        
    }
    private void TankMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);

        if (direction != Vector3.zero)
        {
            this.gameObject.transform.up = direction;
        }
        this.gameObject.transform.position += direction * Time.deltaTime * speed;
    }

    private void TankShoot()
    {
        Vector3 gunDirection = new Vector3(
    Input.mousePosition.x - Screen.width / 2,
    Input.mousePosition.y - Screen.height / 2
    );
        gun.transform.up = gunDirection;

        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet, transhoot.transform.position, transhoot.transform.rotation);
        }
    }
}
