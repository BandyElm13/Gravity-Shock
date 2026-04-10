using UnityEngine;

public class EnemyDieKeySpawnOrSomething : MonoBehaviour
{
    //[SerializeField] private GameObject Enemy;
    [SerializeField] private GameObject key;

    void Start()
    {
        key.SetActive(false);
    }
    public void spawnKey()
    {
        key.transform.SetParent(null);
        key.SetActive(true);
    }
}
