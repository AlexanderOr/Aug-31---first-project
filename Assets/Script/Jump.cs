using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{    
    public float jumpforce;
    public Rigidbody reggiebody;
// Update is called once per frame
void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 forcevector = transform.up * jumpforce;
            reggiebody.AddForce(forcevector);
            print("down");
        }
        else if (Input.GetButton("Jump"))
        {
            print("hold");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            print("up");
        }
    }
}
