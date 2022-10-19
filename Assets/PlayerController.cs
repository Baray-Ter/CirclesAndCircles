using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;
    private Rigidbody2D rb2d;
    public LineRenderer lr;

    public float speed;


    private void Start() {
        
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.AddForce(new Vector2(rb2d.velocity.x, speed));

        lr.GetComponent<LineRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        transform.parent = other.gameObject.transform.GetChild(0);
        
        rb2d.isKinematic = true;

        lr.positionCount = 2;

        lr.SetPosition(0, other.gameObject.transform.position);
        lr.SetPosition(1, transform.position);
    }
}
