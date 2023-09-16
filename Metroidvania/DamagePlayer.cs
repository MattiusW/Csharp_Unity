using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public int damageAmount = 1;

    public bool destroyOnDamage;
    public GameObject destroyEffect;

    
    private void OnCollisionStay2D(Collision2D collision) //Take damanage on stay next to enemy
    {
        if (collision.gameObject.tag == "Player")
        {
            DealDamage();
        }
    }
    
    /*
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            DealDamage();
        }
    }
    */

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            DealDamage();
        }
    }

    void DealDamage()
    {
        PlayerHealthController.instance.DamagePlayer(damageAmount);

        if(destroyOnDamage)
        {
            if(destroyEffect != null)
            {
                Instantiate(destroyEffect, transform.position, transform.rotation);
            }

            Destroy(gameObject);
        }
    }

   
}
