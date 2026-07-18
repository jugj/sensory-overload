using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackLeft : MonoBehaviour
{
        
    float delay = 2000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*Time.deltaTime*2f);


        delay = delay - 1;
        if(delay <= 0){
            Destroy(gameObject);
            delay = 2000;
        }
    }
}
