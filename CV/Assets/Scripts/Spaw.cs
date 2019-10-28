using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaw : MonoBehaviour
{
    [SerializeField] GameObject coin;
    [SerializeField] GameObject boom;
    [SerializeField] float secondsBetweenSpawn;

    int ran;    
    float elapsedTime = 0.0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;
            
            ran = Random.Range(0, 2);
            if (ran == 0)
            {
                Instantiate(coin, transform.position, Quaternion.identity);  
            }
            else
            {
                Instantiate(boom, transform.position, Quaternion.identity);
            }

        }
    }

}
