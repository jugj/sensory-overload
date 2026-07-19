using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sec12Down : MonoBehaviour
{
    [SerializeField] private float countdownTime = 10f;
    [SerializeField] private float duration = 1000f;
    bool down = false;

    private float currentTime;

    void Start()
    {
        currentTime = countdownTime;
    }

    void Update()
    {
         if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0f)
            {
                currentTime = countdownTime;
                down = true;
            }
        }

        if(down == true){
                    transform.position = new Vector3(-5,0,0);
                    duration = duration - 1f;
                }

        if(down == false){
                    transform.position = new Vector3(-5,10,0);
                    duration = 1000f;
                }
        if(duration <= 0){
            down = false;
        }
    }
}
