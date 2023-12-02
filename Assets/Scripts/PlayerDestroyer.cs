using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyDamager enemy))
            Destroy(gameObject); 
    }
}