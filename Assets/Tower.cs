using UnityEngine;

public class Tower : MonoBehaviour
{

    public Transform enemy;

    void Update()
    {
        transform.right = enemy.position - transform.position;
    }
}
