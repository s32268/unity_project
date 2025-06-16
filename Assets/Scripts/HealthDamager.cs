using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))] 
public class HealthDamager : MonoBehaviour
{
    public float damage = 40;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        HandleTakeDamage(collisionObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        HandleTakeDamage(collisionObject);
    }


    private void HandleTakeDamage(GameObject collisionObject)
    {
        Debug.Log("Take damage 1");
        if (!collisionObject.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Take damage 2");

        PlayerStats stats = collisionObject.GetComponent<PlayerStats>();

        if (stats == null)
        {
            return;
        }
        Debug.Log("Take damage 3");

        stats.TakeDamage(damage);
    }
}
