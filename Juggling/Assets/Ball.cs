using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseUp() {
        Debug.Log("Click");
        Rigidbody body= transform.GetComponentInChildren<Rigidbody>();
        body.AddForce(Random.Range(-4,4),Random.Range(7.5f,12.5f),0,ForceMode.Impulse);
        body.AddTorque(Random.Range(-5,5),Random.Range(-5,5),Random.Range(-5,5));
    }

}
