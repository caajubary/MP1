using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject smoke;
    public float speed;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (time == 50)
        {
            Destroy(this.gameObject);
            Instantiate(smoke, gameObject.transform.position, gameObject.transform.rotation);
        }
        time++;
        this.transform.position += transform.up * Time.deltaTime * speed;
    }
}
