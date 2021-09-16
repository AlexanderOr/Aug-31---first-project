using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed = 2f;
    
    // Update is called once per frame
    void Update()
    {
        //we store the current position value of the transform of the object this component is in
        //basically we store the current position of the object
        Vector3 temp = this.transform.position;

        //we add speed to the current X vaule of temp
        temp.x += speed * Time.deltaTime;

        //we assign temp as the new position of the object.
        //we're teleporting the object in very small amount really quickly
        this.transform.position = temp;
    }
}
