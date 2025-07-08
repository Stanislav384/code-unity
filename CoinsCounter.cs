using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    public int coins = 0;

    public void CollectCoins()
    {
        coins++;
        Debug.Log("Coins collected: " + coins);
    }
}
