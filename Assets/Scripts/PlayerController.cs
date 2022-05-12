using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float horizontalInput;
    float xrange = 20;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if ((transform.position.x <= -xrange && horizontalInput < 0) || (transform.position.x >= xrange && horizontalInput > 0))
        {
            return;
        }
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
