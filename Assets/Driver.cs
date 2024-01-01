using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steer_speed = 0.5f;
    [SerializeField] float move_speed = 10f;
    [SerializeField] float boost_speed = 20f;
    [SerializeField] float slow_speed = 5f;


    void Start()
    {
         
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost" ){
            move_speed = boost_speed;
        }
        if(other.tag == "Slow"){
            move_speed = slow_speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float steer_amount = Input.GetAxis("Horizontal") * steer_speed * Time.deltaTime;
        float move_amount = Input.GetAxis("Vertical") * move_speed * Time.deltaTime;
        transform.Translate(0,move_amount,0);
        transform.Rotate(0,0,-steer_amount);
    }
}
