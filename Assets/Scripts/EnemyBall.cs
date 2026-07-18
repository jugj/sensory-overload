using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleWeapon : MonoBehaviour
{
    [SerializeField]
    private string playerName = "Player(Clone)";

    [SerializeField]
    private Vector3 positionOffset = new Vector3(1f, 0f, 0f);

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
            Debug.LogWarning($"Error '{playerName}' not founfd!");
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
            if (player != null)
            {
                playerTransform = player.transform;
            }
        }

        if (playerTransform != null)
        {
            transform.position = playerTransform.position + positionOffset;
        }
    }
}
