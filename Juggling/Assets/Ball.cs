using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Ball : MonoBehaviour
{
    [SerializeField]
    Advertisment ad;

    [SerializeField]
    Text scoreText;
    
    [SerializeField]
    Text comboText;

    [SerializeField]
    float directionscale=1;
    [SerializeField]
    AudioClip groundSound;
    [SerializeField]
    AudioClip kickSound;
    [SerializeField]
    AudioClip cashCollectSound;
    AudioSource audi;
    Rigidbody body;
    int score=0;
    int bonus=0;

    int numofCollisions=0;
    


    // Start is called before the first frame update
    void Start()
    {   
        body= transform.GetComponentInChildren<Rigidbody>();
        audi=GetComponent<AudioSource>();
    }

  
    private void OnMouseUp() {
        Vector2 ballv2=transform.position;
        Vector2 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float direction=ballv2.x-mousePos.x;
        body.AddForce(direction*directionscale,Random.Range(5,6),0,ForceMode.Impulse);
        body.AddTorque(Random.Range(-5,5),Random.Range(-5,5),Random.Range(-5,5));
        score++;
        audi.PlayOneShot(kickSound);
        scoreText.text=score.ToString();
    }


    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag=="Ground"){
            score=0;
            bonus=0;
            numofCollisions++;
            if(numofCollisions/4==1){
                ad.ShowAd();
                numofCollisions=0;
            }
            Debug.Log(body.velocity.magnitude);
            audi.PlayOneShot(groundSound,body.velocity.magnitude/100);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag=="Collectible"){
            bonus++;
            score+=bonus;
            audi.PlayOneShot(cashCollectSound);
            Debug.Log("collected");
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        scoreText.text=(score+bonus).ToString();
        comboText.text="Combo: "+bonus;
        if(score>PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore",score);
        }
    }

}
