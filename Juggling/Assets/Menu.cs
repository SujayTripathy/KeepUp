using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject ball;
    [SerializeField]
    GameObject gameUI;
    [SerializeField]
    Text highScore;
    void Awake(){
        Time.timeScale=0;
        highScore.text=PlayerPrefs.GetInt("HighScore").ToString();
    }
    
    public void StartGame(){
        Time.timeScale=1;
        menu.SetActive(false);
        ball.GetComponentInChildren<SphereCollider>().enabled=true;
        gameUI.SetActive(true);
    }

}
