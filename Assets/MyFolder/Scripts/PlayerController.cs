using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 dir;
    private Camera cam;

    [SerializeField]
    private float speed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.z = Input.GetAxisRaw("Vertical");
        dir.y = 0;
        dir = dir.normalized * speed;

        dir.y = rb.velocity.y;

        rb.velocity = dir;

        transform.localEulerAngles = cam.transform.localEulerAngles;
    }
}
