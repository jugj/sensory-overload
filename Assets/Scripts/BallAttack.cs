using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAttack : MonoBehaviour
{
    [SerializeField]
    float y_spawn_pos = -1.5f;
    [SerializeField]
    float x_spawn_pos = -1.5f;

    int balldelay = 300;

    [SerializeField]
    GameObject ball_active;
    [SerializeField]
    GameObject ball;

    void SpawnBall(){
        Vector2 spawnpoint = new Vector2(x_spawn_pos, y_spawn_pos);
        ball_active = Instantiate(ball, spawnpoint, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        balldelay = balldelay - 1;
        if(balldelay <= 0){
            SpawnBall();
            balldelay = 300;
        }

    }
}
