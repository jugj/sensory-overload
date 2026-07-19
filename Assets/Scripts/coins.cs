using UnityEngine;

public class coin : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;
    
    private CoinManager coinManager;
    private GameObject coinManagerObject;
    
    private void Start()
    {
        coinManagerObject = GameObject.FindWithTag("CoinManager");
        coinManager = coinManagerObject.GetComponent<CoinManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && !hasTriggered)
    {
        hasTriggered = true;
        coinManager.ChangeCoins(value);
        Destroy(gameObject);
    }
    }

}