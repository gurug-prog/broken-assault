using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableMock : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            print("hit " + collision.gameObject.name);
            Destroy(this.gameObject);
        }
    }
}
