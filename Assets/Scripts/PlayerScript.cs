using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float geschwindigkeit = 3f;
    [SerializeField]
    float sprungkraft = 5f;
    [SerializeField]
    int HP = 10;
    [SerializeField]
    float sprungkraftMult = 1.0f;
    [SerializeField]
    float geschwindigkeitMult = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")){
            transform.Translate(Vector2.right*Time.deltaTime*geschwindigkeit*geschwindigkeitMult);
        }
        if(Input.GetKey("left")){
            transform.Translate(Vector2.left*Time.deltaTime*geschwindigkeit*geschwindigkeitMult);
        }
        if(Input.GetKey("up")){
            transform.Translate(Vector2.up*Time.deltaTime*sprungkraft*sprungkraftMult);
        }
        if(HP <= 0){
            Destroy(gameObject);
        }
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey("right")){
            transform.Translate(Vector2.right*Time.deltaTime*geschwindigkeit*1.5f*geschwindigkeitMult);
        }
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey("left")){
            transform.Translate(Vector2.left*Time.deltaTime*geschwindigkeit*1.5f*geschwindigkeitMult);
        }
    }
}
