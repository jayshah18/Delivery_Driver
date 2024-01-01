using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool has_package=false;
    
    [SerializeField] float destroy_delay = 0.5f;
    [SerializeField] Color32 has_package_color = new Color32(1,1,1,1);
    [SerializeField] Color32 no_package_color = new Color32(0,0,0,1 );

    SpriteRenderer sr;
    void Start() {
        sr = GetComponent<SpriteRenderer>();    
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }
    void OnTriggerEnter2D(Collider2D other) {
        
        
        if(other.tag == "Package" && !has_package)
        {
            Debug.Log("Package picked up!");
            has_package = true;
            sr.color = has_package_color;
            Destroy(other.gameObject, destroy_delay);
        }

        if(other.tag == "Customer" && has_package==true)
        {
            Debug.Log("Delivery Done!");
            has_package = false;
            sr.color = no_package_color;
        }    
        
    }
}
