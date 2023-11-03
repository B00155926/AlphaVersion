using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBoxes : MonoBehaviour
{
    public float speed = 5.0f;
    private float zDestroy = -10.0f;
    private Rigidbody objectRb;

//start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }
//update is called once per frame
    void Update()
    {
       objectRb.AddForce(Vector3.forward * -speed);

       if (transform.position.z < zDestroy)
       {
        Destroy(gameObject);
       }
    }

   
}
