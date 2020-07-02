using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    [SerializeField]

    GameObject highScore;
    [SerializeField]
    GameObject gameUI;
    [SerializeField]
    GameObject menuUI;
    
    void Awake(){
        Time.timeScale=0;
        highScore.GetComponent<Text>().text=PlayerPrefs.GetInt("HighScore").ToString();
    }
    
    public void StartGame(){
        Time.timeScale=1;
        ball.GetComponentInChildren<SphereCollider>().enabled=true;
        menuUI.SetActive(false);       
        gameUI.SetActive(true);

    }

}
