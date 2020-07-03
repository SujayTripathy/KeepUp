using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Advertisment : MonoBehaviour
{
    string gameID="3692577";
    string bannerID="MainMenu";
    bool testMode=true;
    
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID,testMode);
        StartCoroutine(ShowBannerWhenReady());
    }
    public void ShowAd(){
        Advertisement.Show();
    }

    IEnumerator ShowBannerWhenReady(){
        Debug.Log("called");
        while (Advertisement.IsReady (bannerID)) {
            yield return new WaitForSeconds (0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Debug.Log("Ready");
        Advertisement.Banner.Show(bannerID);
        Debug.Log("Showing");
    }
}
