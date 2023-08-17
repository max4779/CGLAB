using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardMove : MonoBehaviour
{
    public float speed;
    public float yforce;
    private Rigidbody rigidbody;
    
    void Start()
    {
        rigidbody= GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        
        Vector3 pos = new Vector3(horizontal, 0, vertical).normalized;
        transform.position += pos * speed * Time.deltaTime;

        if(Input.GetButton("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.01f) {
            rigidbody.AddForce(Vector3.up * yforce, ForceMode.Impulse);
        }

    }
}
