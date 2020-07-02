using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float collectibleLifetime=2;

    Vector3 rotation;
    void Start()
    {
        rotation=new Vector3(Random.Range(-1,1),Random.Range(-1,1),Random.Range(-1,1));
        Destroy(gameObject,collectibleLifetime);
    }
    void Update() {
        transform.Rotate(rotation);
    }
}
