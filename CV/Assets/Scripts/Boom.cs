using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 drop = new Vector3(0, -1f, 0);
        rb.AddForce(drop);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().DeHealth(1);
            //Game Over
        }
        else if (other.tag == "BR")
        {
            Destroy(gameObject);            
        }
    }
}
