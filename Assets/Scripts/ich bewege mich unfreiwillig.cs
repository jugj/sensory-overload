using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ichbewegemichunfreiwillig : MonoBehaviour
{
    [SerializeField]
    float geschwindigkeit = 3f;
    [SerializeField]
    float sprungkraft = 3f;
    [SerializeField]
    float fallkraft = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")){
            transform.Translate(Vector2.right*Time.deltaTime*geschwindigkeit);
        }
  if(Input.GetKey("left")){
            transform.Translate(Vector2.left*Time.deltaTime*geschwindigkeit);
        }
          if(Input.GetKey("up")){
            transform.Translate(Vector2.up*Time.deltaTime*sprungkraft);
        }
if(Input.GetKey("down")){
            transform.Translate(Vector2.down*Time.deltaTime*fallkraft);
        }
    }
}
