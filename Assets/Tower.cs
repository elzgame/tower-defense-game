using UnityEngine;

public class Tower : MonoBehaviour
{
    public Transform enemy;
    public GameObject peluru;
    public Transform peluruPoint;

    void Update()
    {
        transform.right = enemy.position - transform.position;
        if(Input.GetMouseButtonDown(0)) {
            Instantiate(peluru, peluruPoint);
        }
    }
}
