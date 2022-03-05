using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float timeToDelete = 0.01f;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!!");
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage){
            Debug.Log(other.tag + " picked up");
            hasPackage = true;
            Destroy(other.gameObject, timeToDelete);
        }
        
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Delivered to " + other.tag);
            hasPackage = false;
        }
    }
}
