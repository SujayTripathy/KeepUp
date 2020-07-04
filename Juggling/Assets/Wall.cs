using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="ball"){
            other.gameObject.GetComponentInChildren<Rigidbody>().AddForce(new Vector3 (-other.gameObject.GetComponentInChildren<Rigidbody>().velocity.x*3,0,0),ForceMode.Impulse);
        }
    }
}
