using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.right);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Destroy enemy");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
