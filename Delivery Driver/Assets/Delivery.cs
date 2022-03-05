using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 255, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 1);
    [SerializeField] float destroyDelay = 0.01f;
    
    SpriteRenderer spriteRenderer;

    bool hasPackage = false;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!!");
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage){
            Debug.Log(other.tag + " picked up");

            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Delivered to " + other.tag);

            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
