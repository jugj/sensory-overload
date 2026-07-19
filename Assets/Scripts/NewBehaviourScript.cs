using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   [SerializeField]
    float geschwindigkeit = 3f;
    float jeschwindigkeit = 6f;
    float deschwindigkeit = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")){transform.Translate(Vector2.right*Time.deltaTime*geschwindigkeit);}
        if(Input.GetKey("left")){transform.Translate(Vector2.left*Time.deltaTime*geschwindigkeit);}
        if(Input.GetKey("up")){transform.Translate(Vector2.up*Time.deltaTime*jeschwindigkeit);}
        if(Input.GetKey("down")){transform.Translate(Vector2.down*Time.deltaTime*geschwindigkeit);}
        if(Input.GetKey("space")){transform.Translate(Vector2.up*Time.deltaTime*deschwindigkeit);}
    }
}
