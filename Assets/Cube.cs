using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 5f; 
    public float speedRotation = 5f;

    // Update is called once per frame
    void Update()
    {
        float horizontalPosition = Input.GetAxis("Horizontal");
        float verticalPosition = Input.GetAxis("Vertical");

        Vector3 vectorPosition = new Vector3(horizontalPosition,0,verticalPosition);

        transform.position = transform.position + vectorPosition * speed * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(vectorPosition),speedRotation * Time.deltaTime);
    }
}
