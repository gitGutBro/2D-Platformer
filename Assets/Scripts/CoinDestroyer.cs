using UnityEngine;

public class CoinDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerController player))
            Destroy(gameObject);
    }
}