using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float horizontalInput;
    float xrange = 20;

    float verticalInput;
    float minZ = -12.5f;
    float maxZ = -7.0f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // di chuyen trai phai
        horizontalInput = Input.GetAxis("Horizontal");
        if ((transform.position.x <= -xrange && horizontalInput < 0) || (transform.position.x >= xrange && horizontalInput > 0))
        {
            return;
        }
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        // di chuyen len xuong
        verticalInput = Input.GetAxis("Vertical");
        if ((transform.position.z <= minZ && verticalInput < 0) || (transform.position.z >= maxZ && verticalInput > 0))
        {
            return;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);

        // Ban dan
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
