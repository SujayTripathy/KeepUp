using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    GameObject collectible;
    [SerializeField]
    float interval=1.5f;
    float last=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time-last>=interval){
            Instantiate(collectible,new Vector3(Random.Range(-2,2),Random.Range(0.67f,5.6f),0.24f),new Quaternion());
            last=Time.time;
        }
    }
}
