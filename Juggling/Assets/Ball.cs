using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Ball : MonoBehaviour
{
    int score=0;
    public Text scoreText;
    AudioSource audi;
    Rigidbody body;
    float last=0;
    bool click=false;


    // Start is called before the first frame update
    void Start()
    {   
        body= transform.GetComponentInChildren<Rigidbody>();
        audi=GetComponent<AudioSource>();
    }

  
    private void OnMouseUp() {
        body.AddForce(Random.Range(-2.5f,2.5f),Random.Range(5,6),0,ForceMode.Impulse);
        body.AddTorque(Random.Range(-5,5),Random.Range(-5,5),Random.Range(-5,5));
        score++;
        audi.Play();
        scoreText.text=score.ToString();
    }


    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag=="Ground"){
            score=0;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag=="Collectible"){
            score+=2;
            Debug.Log("collected");
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        scoreText.text=score.ToString();
    }

}
