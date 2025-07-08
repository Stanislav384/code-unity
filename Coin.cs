using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        CoinsCounter coinsCounter = other.GetComponent<CoinsCounter>();
        coinsCounter.CollectCoins(); // Додає монету
        Destroy(gameObject);   // Знищує монету
    }
}
