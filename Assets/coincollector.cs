using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
   public static CoinManager instance;

   public int coin;
   TMP_Text CoinsDisplay;

   private void Awake()
   {
    if (!instance)
    {
        instance = this;
    }
   }

   void Start() {
    GameObject display = GameObject.Find("CoinDisplay");
    CoinsDisplay = display.GetComponent<TextMeshProUGUI>(); 
   }

    public void ChangeCoins(int amount)
    {
        coin += amount;
        CoinsDisplay.text = coin.ToString();
    }
}


