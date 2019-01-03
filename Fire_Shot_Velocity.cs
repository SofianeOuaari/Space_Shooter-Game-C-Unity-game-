using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Shot_Velocity : MonoBehaviour {
      private float speed_velocity=500f;
      private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.forward * speed_velocity * Time.deltaTime);
        Destroy(gameObject, 2f);
	}
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
                
    }
}
