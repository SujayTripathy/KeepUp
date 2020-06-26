using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float collectibleLifetime=2;
    void Start()
    {
        Destroy(gameObject,collectibleLifetime);
    }
}
