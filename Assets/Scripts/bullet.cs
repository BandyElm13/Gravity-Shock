using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] private float damage = 20f;
    [SerializeField] private float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Try to get EnemyStats from whatever we hit
        EnemyStats enemy = collision.gameObject.GetComponent<EnemyStats>();

        if (enemy != null)
        {
            enemy.currentHealth -= damage;
        }
    }
}