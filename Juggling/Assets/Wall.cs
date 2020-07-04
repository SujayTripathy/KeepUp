using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Ball"){
            other.gameObject.GetComponentInChildren<Rigidbody>().AddForce(new Vector3 (-other.gameObject.GetComponentInChildren<Rigidbody>().velocity.x*1.2f,0,0),ForceMode.Impulse);
        }
    }
}
