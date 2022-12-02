using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeakpoint : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag =="Weak Point")
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
        }
    }
}
