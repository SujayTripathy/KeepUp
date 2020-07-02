using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject ball;
    void Awake(){
        Time.timeScale=0;
    }
    
    public void StartGame(){
        Time.timeScale=1;
        menu.SetActive(false);
        ball.GetComponentInChildren<SphereCollider>().enabled=true;
    }

}
