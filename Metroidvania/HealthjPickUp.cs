using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthjPickUp : MonoBehaviour
{
    public int healthAmount;

    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PlayerHealthController.instance.HealPlayer(healthAmount);

            if(pickupEffect != null)
            {
                Instantiate(pickupEffect, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}
