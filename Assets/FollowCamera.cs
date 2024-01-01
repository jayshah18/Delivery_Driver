using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
   
    [SerializeField] GameObject ThingsToFollow;
    void LateUpdate()
    {
        transform.position = ThingsToFollow.transform.position + new Vector3(0,0,-10);
    }
}
