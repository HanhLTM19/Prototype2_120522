using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyObject : MonoBehaviour
{
    float topBound = 35;
    float bottomBound = -18;
    float sideBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < bottomBound || transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
    }
}
