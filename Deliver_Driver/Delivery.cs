using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(0, 0, 0 ,0);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float timeToDestroy = 0f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Packeg pickup");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, timeToDestroy);
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Recive");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
