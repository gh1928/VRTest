using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Camera cam;    

    [SerializeField]
    private float speed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    // Update is called once per frame
    private Vector2 direction;
    void Update()
    {
        Vector3 newVelocity = (transform.right * Input.GetAxisRaw("Horizontal") + transform.forward * Input.GetAxisRaw("Vertical")).normalized * speed;
        newVelocity.y = rb.velocity.y;
        rb.velocity = newVelocity;
        rb.angularVelocity = Vector3.zero;
        
        transform.localEulerAngles = new Vector3(0, cam.transform.localEulerAngles.y,0);
    }
}
