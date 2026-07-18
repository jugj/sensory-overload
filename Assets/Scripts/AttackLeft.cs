using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackLeft : MonoBehaviour
{
        
    float delay = 5000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*Time.deltaTime*4f);


        delay = delay - 1;
        if(delay <= 0){
            Destroy(gameObject);
            delay = 5000;
        }
    }
}
