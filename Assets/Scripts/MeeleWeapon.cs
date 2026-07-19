using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleWeapon : MonoBehaviour
{
    [SerializeField]
    private string playerName = "Player(Clone)";

    [SerializeField]
    private Vector3 positionOffset = new Vector3(1f, 0f, 0f);

    [SerializeField]
    int weaponTime = 0;

    private Transform playerTransform;

    private void Start()
    {
        GameObject player = GameObject.Find(playerName);
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogWarning($"Error '{playerName}' not founfd! (This Warning is to ignore!)");
        }
    }

    private void Update()
    {
        if(Input.GetKey("right")){
            positionOffset = new Vector3(1f, 0f, 0f);
        }

        if(Input.GetKey("left")){
            positionOffset = new Vector3(-1f, 0f, 0f);
        }



        if (playerTransform == null || playerTransform.gameObject == null)
        {
            GameObject player = GameObject.Find(playerName);
            if (player != null && weaponTime <= 0)
            {
                playerTransform = player.transform;
            }
        }

        if (playerTransform != null  && weaponTime <= 0)
        {
            transform.position = playerTransform.position + positionOffset;
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            weaponTime = 50;
        }

        if(weaponTime >= 1){
            transform.Translate(Vector2.right*Time.deltaTime*5);
            weaponTime = weaponTime - 1;
        }

    }

}
